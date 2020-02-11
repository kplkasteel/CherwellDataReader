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
    public interface IBusinessObjectApi : IApiAccessor
    {

        /// <summary>
        /// Get Business Object summaries by type
        /// </summary>
        /// <remarks>
        /// Operation that returns a list of Business Object summaries by type (Major, Supporting, Lookup, Groups, and All).
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="type">Use to show:&lt;br /&gt;All - All objects&lt;br /&gt;Major - Major objects only&lt;br /&gt;Supporting - Supporting objects only&lt;br /&gt;Lookup - Lookup objects only&lt;br /&gt;Groups - Groups only</param>
        /// <returns>List&lt;Summary&gt;</returns>
        List<Summary> BusinessObjectGetBusinessObjectSummariesV1(string type);

        /// <summary>
        /// Get a Business Object summary by name
        /// </summary>
        /// <remarks>
        /// Operation that returns a single Business Object summary by name.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobname">Specify a Business Object name to get its summary.</param>
        /// <returns>List&lt;Summary&gt;</returns>
        List<Summary> BusinessObjectGetBusinessObjectSummaryByNameV1(string busobname);

        /// <summary>
        /// Get Business Object templates for create
        /// </summary>
        /// <remarks>
        /// Operation that returns a template to create Business Objects.  The template includes placeholders for field values. You can then send the template with these values to the Business Object Save operation.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify the Business Object ID. Use true to include all required fields or all fields. Specify an optional fields list by adding field names in a comma-delimited list [\&quot;field1\&quot;, \&quot;field2\&quot;]. </param>
        /// <returns>TemplateResponse</returns>

        TemplateResponse BusinessObjectGetBusinessObjectTemplateV1(TemplateRequest request);
        /// <summary>
        /// Get a Business Object schema
        /// </summary>
        /// <remarks>
        /// Operation that returns the schema for a Business Object and, optionally, its related Business Objects.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobId">Specify the Business Object ID.</param>
        /// <param name="includerelationships">Flag to include schemas for related Business Object. Default is false. (optional)</param>
        /// <returns>SchemaResponse</returns>
        SchemaResponse BusinessObjectGetBusinessObjectSchemaV1(string busobId, bool? includerelationships = null);


        /// <summary>
        /// Create or Update a Business Object
        /// </summary>
        /// <remarks>
        /// Operation that creates a new Business Object or updates an existing Business Object. To create, leave record ID and public ID empty. Upon creating or saving, a cache key is returned to use for subsequent requests. If the object is not found in the cache with said cache key, specify record ID or public ID to save and return a new cache key. Set persist &#x3D; true, to actually save the Business Object to disk, persist &#x3D; false will just cache it.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Specify a list of fields from a Business Object template. </param>
        /// <returns>SaveResponse</returns>
        SaveResponse BusinessObjectSaveBusinessObjectV1(SaveRequest request);

        /// <summary>
        /// Upload an attachment by Business Object ID and record ID
        /// </summary>
        /// <remarks>
        /// Operation to upload an attachment to a Business Object record using a Business Object ID and record ID. The body of the request is the byte array of the file part being uploaded.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="filename">Specify the name of the file being uploaded. If no attachment name is provided, the file name is used.</param>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID to attach the file to.</param>
        /// <param name="offset">The offset is the starting index of the file part being uploaded.  If this is the first part then the offset will be zero.</param>
        /// <param name="totalsize">The entire file size in bytes.</param>
        /// <param name="attachmentid">Specify the attachment ID of an uploaded file to upload subsequent parts and ensure each part gets appended to the parts that have already been uploaded. (optional)</param>
        /// <param name="displaytext">Specify the attachment name, which is the display text for the attachment record. (optional)</param>
        /// <returns>ApiResponse of string</returns>
        string BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1(byte[] body, string filename, string busobid, string busobrecid, int? offset, int? totalsize, string attachmentid = null, string displaytext = null);

        /// <summary>
        /// Create or update a related Business Object
        /// </summary>
        /// <remarks>
        /// Operation that creates or updates a related Business Object. To update, specify record ID or public ID. To create, leave record ID and public ID empty.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object specifying the parent the Business Object, the Relationship, and field values for the Business Object to create or update. </param>
        /// <returns>RelatedSaveResponse</returns>
        RelatedSaveResponse BusinessObjectSaveRelatedBusinessObjectV1(RelatedSaveRequest request);

        /// <summary>
        /// Get a Business Object record
        /// </summary>
        /// <remarks>
        /// Operation that returns a Business Object record that includes a list of fields and their record IDs, names, and set values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="busobid">Specify the Business Object ID.</param>
        /// <param name="busobrecid">Specify the Business Object record ID.</param>
        /// <returns>ReadResponse</returns>
        ReadResponse BusinessObjectGetBusinessObjectByRecIdV1(string busobid, string busobrecid);

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BusinessObjectApi : IBusinessObjectApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessObjectApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BusinessObjectApi(string basePath)
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

       

        public List<Summary> BusinessObjectGetBusinessObjectSummariesV1(string type)
        {
            if (type == null)
                throw new ApiException(400, "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSummariesV1");

            const string localVarPath = "/api/V1/getbusinessobjectsummaries/type/{type}";
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

            localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type)); 

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSummariesV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<Summary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Summary>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Summary>))).Data;
        }

        public TemplateResponse BusinessObjectGetBusinessObjectTemplateV1(TemplateRequest request)
        {
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectTemplateV1");

            const string localVarPath = "/api/V1/getbusinessobjecttemplate";
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
                localVarPostBody = Configuration.ApiClient.Serialize(request);
            }
            else
            {
                localVarPostBody = request;
            }

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectTemplateV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TemplateResponse>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (TemplateResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                        typeof(TemplateResponse)))
                .Data;
        }

        public SchemaResponse BusinessObjectGetBusinessObjectSchemaV1(string busobId, bool? includerelationships = null)
        {
            
            if (busobId == null)
                throw new ApiException(400, "Missing required parameter 'busobId' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSchemaV1");

            const string localVarPath = "/api/V1/getbusinessobjectschema/busobid/{busobId}";
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

            localVarPathParams.Add("busobId", Configuration.ApiClient.ParameterToString(busobId)); 
            if (includerelationships != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includerelationships", includerelationships)); // query parameter

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSchemaV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SchemaResponse>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (SchemaResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaResponse)))
                .Data;
        }


        public SaveResponse BusinessObjectSaveBusinessObjectV1(SaveRequest request)
        {
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectV1");

            const string localVarPath = "/api/V1/savebusinessobject";
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

            var exception = ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaveResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaveResponse))).Data;
        }

        public string BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1(byte[] body, string filename,
            string busobid, string busobrecid, int? offset, int? totalsize, string attachmentid = null,
            string displaytext = null)
        {

            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            if (filename == null)
                throw new ApiException(400, "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            if (offset == null)
                throw new ApiException(400, "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
            if (totalsize == null)
                throw new ApiException(400, "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");

            const string localVarPath = "/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

         
            var localVarHttpContentTypes = new[] {
                "application/octet-stream"
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

            localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename)); 
            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid)); 
            localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid));
            localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); 
            localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize)); 
            if (attachmentid != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid", attachmentid)); // query parameter
            if (displaytext != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext", displaytext)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); 
            }
            else
            {
                localVarPostBody = body; 
            }

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string))).Data;
        }

        public RelatedSaveResponse BusinessObjectSaveRelatedBusinessObjectV1(RelatedSaveRequest request)
        {
            
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveRelatedBusinessObjectV1");

            const string localVarPath = "/api/V1/saverelatedbusinessobject";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

            // to determine the Content-Type header
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
                localVarPostBody = Configuration.ApiClient.Serialize(request); 
            }
            else
            {
                localVarPostBody = request; 
            }

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectSaveRelatedBusinessObjectV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<RelatedSaveResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RelatedSaveResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RelatedSaveResponse))).Data;
        }

        public ReadResponse BusinessObjectGetBusinessObjectByRecIdV1(string busobid, string busobrecid)
        {
            
            if (busobid == null)
                throw new ApiException(400, "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByRecIdV1");
            if (busobrecid == null)
                throw new ApiException(400, "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByRecIdV1");

            const string localVarPath = "/api/V1/getbusinessobject/busobid/{busobid}/busobrecid/{busobrecid}";
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

            localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
            localVarPathParams.Add("busobrecid", Configuration.ApiClient.ParameterToString(busobrecid)); 

            
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByRecIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ReadResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadResponse))).Data;
        }

        public List<Summary> BusinessObjectGetBusinessObjectSummaryByNameV1(string busobname)
        {
            if (busobname == null)
                throw new ApiException(400, "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSummaryByNameV1");

            const string localVarPath = "/api/V1/getbusinessobjectsummary/busobname/{busobname}";
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

            localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname)); // path parameter

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSummaryByNameV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<List<Summary>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Summary>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Summary>))).Data;
        }
    }
}