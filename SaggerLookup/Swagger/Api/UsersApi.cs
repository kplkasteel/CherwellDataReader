using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using RestSharp;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsersApi : IApiAccessor
    {
        /// <summary>
        /// Get a user by login ID and login ID type
        /// </summary>
        /// <remarks>
        /// Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginId">Specify the user&#39;s login ID.</param>
        /// <param name="loginIdType">Specify the login ID type.</param>
        /// <returns>UserV2</returns>
        UserV2 UsersGetUserByLoginIdV3(string loginId, string loginIdType);

        /// <summary>
        /// Create or update a user
        /// </summary>
        /// <remarks>
        /// Operation to create or update a user.  The response is a collection because if you use a public ID, more than one user could be updated since public IDs may not be unique.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="request">Request object to specify user parameters and fields with values to be created or updated. The loginId and either the Business Object record ID or Public ID are required.</param>
        /// <returns>UserSaveV2Response</returns>
        UserSaveV2Response UsersSaveUserV2(UserSaveV2Request request);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public  class UsersApi : IUsersApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsersApi(string basePath)
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

        /// <summary>
        /// Get a user by login ID and login ID type Operation to get detailed user information by login ID. Use to get user record IDs and account settings, for example.
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="loginId">Specify the user&#39;s login ID.</param>
        /// <param name="loginIdType">Specify the login ID type.</param>
        /// <returns>UserV2</returns>   
        [SuppressMessage("ReSharper", "StringLiteralTypo")]
        public UserV2 UsersGetUserByLoginIdV3(string loginId, string loginIdType)
        {
            if (loginId == null)
                throw new ApiException(400,
                    "Missing required parameter 'loginid' when calling UsersApi->UsersGetUserByLoginIdV3");

            if (loginIdType == null)
                throw new ApiException(400,
                    "Missing required parameter 'loginidtype' when calling UsersApi->UsersGetUserByLoginIdV3");

            const string localVarPath = "/api/V3/getuserbyloginid";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            var localVarHttpContentTypes = new string[] { };

            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccepts = new[]
            {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };

            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "loginid", loginId)); // query parameter
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "loginidtype", loginIdType)); // query parameter

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var exception = ExceptionFactory?.Invoke("UsersGetUserByLoginIdV3", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserV2>((int)localVarResponse.StatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserV2)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserV2))).Data;
        }

        public UserSaveV2Response UsersSaveUserV2(UserSaveV2Request request)
        {
           
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling UsersApi->UsersSaveUserV2");

            const string localVarPath = "/api/V2/saveuser";
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

            var exception = ExceptionFactory?.Invoke("UsersSaveUserV2", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<UserSaveV2Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserSaveV2Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSaveV2Response))).Data;
        }
    }
}