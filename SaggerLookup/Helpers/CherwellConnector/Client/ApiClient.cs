using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using RestSharp;

namespace SwaggerLookup.Helpers.CherwellConnector.Client
{
    public class ApiClient
    {
        private readonly JsonSerializerSettings _serializerSettings = new()
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        public ApiClient(string basePath)
        {
            if (string.IsNullOrEmpty(basePath))
                throw new ArgumentException("basePath cannot be empty");

            Configuration = Configuration.Default;

            var restClientOptions = new RestClientOptions
            {
                BaseUrl = new Uri(basePath),
                MaxTimeout = 10000,
                AutomaticDecompression = DecompressionMethods.GZip,
            };
            RestClient = new RestClient(restClientOptions);
        }

        public Configuration Configuration { get; set; }

        public RestClient RestClient { get; }

        private static RestRequest PrepareRequest(
            string path, Method method, IEnumerable<KeyValuePair<string, string>> queryParams, object postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            var request = new RestRequest(path, method);

            foreach (var param in pathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            foreach (var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            foreach (var param in queryParams)
                request.AddQueryParameter(param.Key, param.Value);

            foreach (var param in formParams)
                request.AddParameter(param.Key, param.Value);

            foreach (var param in fileParams)
                request.AddFile(param.Value.Name, param.Value.GetFile, param.Value.FileName, param.Value.ContentType, param.Value.Options);

            if (postBody != null)
                request.AddParameter(contentType, postBody, ParameterType.RequestBody);

            return request;
        }

        public object CallApi(
            string path, Method method, IEnumerable<KeyValuePair<string, string>> queryParams, object postBody,
            Dictionary<string, string> headerParams, Dictionary<string, string> formParams,
            Dictionary<string, FileParameter> fileParams, Dictionary<string, string> pathParams,
            string contentType)
        {
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType);

            var response = RestClient.Execute(request);

            return response;
        }

        public string ParameterToString(object obj)
        {
            switch (obj)
            {
                case DateTime localTime:
                    return localTime.ToString(Configuration.DateTimeFormat);

                case DateTimeOffset localOffset:
                    return localOffset.ToString(Configuration.DateTimeFormat);

                case IList localList:
                    {
                        var flattenedString = new StringBuilder();
                        foreach (var param in localList)
                        {
                            if (flattenedString.Length > 0)
                                flattenedString.Append(',');
                            flattenedString.Append(param);
                        }

                        return flattenedString.ToString();
                    }
                default:
                    return Convert.ToString(obj);
            }
        }

        public object Deserialize(RestResponse response, Type type)
        {
            if (type == typeof(byte[]))
                return response.RawBytes;

            if (type == typeof(Stream))
            {
                {
                    var filePath = string.IsNullOrEmpty(Configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : Configuration.TempFolderPath;
                    var regex = new Regex("""Content-Disposition=.*filename=['"]?([^'"\s]+)['"]?$""");
                    if (response.Headers != null)
                        foreach (var header in response.Headers)
                        {
                            var match = regex.Match(header.ToString());
                            if (!match.Success) continue;
                            var fileName = filePath +
                                           SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            if (response.RawBytes != null) File.WriteAllBytes(fileName, response.RawBytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                }
                if (response.RawBytes != null)
                {
                    var stream = new MemoryStream(response.RawBytes);
                    return stream;
                }
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime"))
                if (response.Content != null)
                    return DateTime.Parse(response.Content, null, DateTimeStyles.RoundtripKind);

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable"))
                return ConvertType(response.Content, type);

            try
            {
                if (response.Content != null)
                    return JsonConvert.DeserializeObject(response.Content, type, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }

            throw new InvalidOperationException();
        }

        public static string Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        private static bool IsJsonMime(string mime)
        {
            var jsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");
            return mime != null && (jsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json"));
        }

        public static string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return "application/json";

            foreach (var contentType in contentTypes)
                if (IsJsonMime(contentType.ToLower()))
                    return contentType;

            return contentTypes[0];
        }

        public static string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            return accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase)
                ? "application/json"
                : string.Join(",", accepts);
        }

        private static dynamic ConvertType(dynamic fromObject, Type toObject) => Convert.ChangeType(fromObject, toObject);

        private static string SanitizeFilename(string filename)
        {
            var match = Regex.Match(filename, @".*[/\\](.*)$");

            return match.Success ? match.Groups[1].Value : filename;
        }

        public IEnumerable<KeyValuePair<string, string>> ParameterToKeyValuePairs(string collectionFormat, string name,
            object value)
        {
            var parameters = new List<KeyValuePair<string, string>>();

            if (IsCollection(value) && collectionFormat == "multi")
            {
                var valueCollection = value as IEnumerable;
                parameters.AddRange(from object item in valueCollection
                                    select new KeyValuePair<string, string>(name, ParameterToString(item)));
            }
            else
            {
                parameters.Add(new KeyValuePair<string, string>(name, ParameterToString(value)));
            }

            return parameters;
        }

        private static bool IsCollection(object value)
        {
            return value is IList or ICollection;
        }
    }
}   