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
    public interface IOneStepActionsApi : IApiAccessor
    {
        /// <summary>
        /// Get One-Step Actions by Association
        /// </summary>
        /// <remarks>
        /// Operation to get One-Step Actions by Association
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Business Object association to get One-Step Actions for</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <returns>TrebuchetWebApiDataContractsCoreManagerData</returns>
        ManagerData OneStepActionsGetOneStepActionsByAssociationV1(string association, bool? links = null);

        /// <summary>
        /// Run a stand alone One-Step Action
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action that doesn&#39;t run against a Business Object Record.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="standinkey">The key to find the One-Step Action to run</param>
        /// <returns>TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        OneStepActionResponse OneStepActionsRunOneStepActionByStandInKeyV1(string standinkey);

        /// <summary>
        /// Run a One-Step Action using a OneStepActionRequest
        /// </summary>
        /// <remarks>
        /// Operation to run a One-Step Action using a OneStepActionRequest. This request is used to start a One-Step Action run with additional information such as prompt values.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object containing all the properties need to start a One-Step Action.</param>
        /// <returns>TrebuchetWebApiDataContractsOneStepActionsOneStepActionResponse</returns>
        OneStepActionResponse OneStepActionsRunOneStepActionV1(OneStepActionRequest request);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public  class OneStepActionsApi : IOneStepActionsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OneStepActionsApi(string basePath)
        {
            Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesApi"/> class   
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OneStepActionsApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

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

        public ManagerData OneStepActionsGetOneStepActionsByAssociationV1(string association, bool? links = null)
        {
            
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationV1");

            const string localVarPath = "/api/V1/getonestepactions/association/{association}";
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

            localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); 
            if (links != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links));

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ManagerData>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData))).Data;
        }

        public OneStepActionResponse OneStepActionsRunOneStepActionByStandInKeyV1(string standinkey)
        {
           
            if (standinkey == null)
                throw new ApiException(400, "Missing required parameter 'standinkey' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByStandInKeyV1");

            const string localVarPath = "/api/V1/runonestepaction/standinkey/{standinkey}";
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

            localVarPathParams.Add("standinkey", Configuration.ApiClient.ParameterToString(standinkey)); // path parameter

           
            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("OneStepActionsRunOneStepActionByStandInKeyV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<OneStepActionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OneStepActionResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneStepActionResponse))).Data;
        }

        public OneStepActionResponse OneStepActionsRunOneStepActionV1(OneStepActionRequest request)
        {
           
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling OneStepActionsApi->OneStepActionsRunOneStepActionV1");

            var localVarPath = "/api/V1/runonestepaction";
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

            var exception = ExceptionFactory?.Invoke("OneStepActionsRunOneStepActionV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<OneStepActionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OneStepActionResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(OneStepActionResponse))).Data;
        }
    }
}
