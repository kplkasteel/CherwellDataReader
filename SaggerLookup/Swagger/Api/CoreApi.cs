using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICoreApi : IApiAccessor
    {
        /// <summary>
        /// Get built-in images
        /// </summary>
        /// <remarks>
        /// Operation that gets built-in images. If you are requesting an icon (.ico), you can specify width and height.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Image name and folder location in the Image Manager. Parameter must begin with \&quot;[PlugIn]Images;\&quot; and then a period-separated list of folders. Example: \&quot;[PlugIn]Images;Images.Common.Cherwell.ico\&quot;.</param>
        /// <param name="width">Specify the width (icons only). (optional)</param>
        /// <param name="height">Specify the height (icons only). (optional)</param>
        /// <returns>byte[]</returns>
        byte[] CoreGetGalleryImageV1(string name, int? width = null, int? height = null);

        /// <summary>
        /// Create or update a gallery image
        /// </summary>
        /// <remarks>
        /// Endpoint to Create or update a gallery image. To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">To create a new gallery image leave the StandIn key blank. To update a gallery image provide the StandIn key of the gallery image you want to update.&lt;/br&gt;There are three different ImageTypes allowed: Imported, Url, and File. To use the Imported image type, provide the filename in the Name property, with extension, and provide the image data in a Base64 encoded format in the Base64EncodedImageData property. The max file size is 512k.&lt;/br&gt;To use the Url image type,  provide the full network share path to the file in the Name property, ie: \&quot;\\\\\\\\\\\\\\\\networkshare\\\\\\somefolder\\\\\\somefile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;To use the File image type, provide the full path to the file in the Name property, ie: \&quot;C:\\\\\\somefolder\\\\\\somfile.jpg\&quot;. If the file is not accessible to all users it will not visible to all users.&lt;/br&gt;When creating or updating an image, Name and ImageType are always required, and if the image type is \&quot;Imported\&quot;, then the Base64EncodedImageData is also required. &lt;/br&gt;scope, scopeowner, and folder can all be updated independently.</param>
        /// <returns>SaveGalleryImageResponse</returns>
        SaveGalleryImageResponse CoreSaveGalleryImageV1(SaveGalleryImageRequest request);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public  class CoreApi : ICoreApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CoreApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }


        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set => _exceptionFactory = value;
        }

        public byte[] CoreGetGalleryImageV1(string name, int? width = null, int? height = null)
        {
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling CoreApi->CoreGetGalleryImageV1");

            const string localVarPath = "/api/V1/getgalleryimage/name/{name}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            var localVarHttpContentTypes = new string[] {
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccepts = new[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // path parameter
            if (width != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "width", width)); // query parameter
            if (height != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "height", height)); // query parameter

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("CoreGetGalleryImageV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<byte[]>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (byte[])Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[]))).Data;
        }

        public SaveGalleryImageResponse CoreSaveGalleryImageV1(SaveGalleryImageRequest request)
        {
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling CoreApi->CoreSaveGalleryImageV1");

            const string localVarPath = "/api/V1/savegalleryimage";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

            var localVarHttpContentTypes = new[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccepts = new[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("CoreSaveGalleryImageV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SaveGalleryImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaveGalleryImageResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaveGalleryImageResponse))).Data;
        }
    }
}