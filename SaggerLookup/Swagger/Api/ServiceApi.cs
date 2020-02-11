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
    public interface IServiceApi : IApiAccessor
    {
        /// <summary>
        /// Get information about the REST Api and CSM
        /// </summary>
        /// <remarks>
        /// Operation to get information about the REST API and CSM.  The response is latest REST API operation version, CSM version, and CSM system date and time.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns>ServiceInfoResponse</returns>
        ServiceInfoResponse ServiceGetServiceInfoV1();

        /// <summary>
        /// Log out user by token
        /// </summary>
        /// <remarks>
        /// Operation that logs out the user referenced in the authentication token.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void ServiceLogoutUserV1();

        /// <summary>
        /// Get an access token
        /// </summary>
        /// <remarks>
        /// Operation to request an access token for one of the following authentication modes. Or, you can request an access token using a refresh token. An API client key is required in both cases, and the authentication mode you use must be the mode used by the CSM Browser Client. &lt;/br&gt;  Internal - Use a CSM username and password. If no other mode is specified, Internal mode is used.&lt;/br&gt;  Windows - Uses the server variable LOGON_USER to attempt to find a CSM user.  You can also use domain\\username and password.&lt;/br&gt;  LDAP - Uses the LDAP settings configured for CSM and the server variable LOGON_USER to attempt to find a CSM user. You can also use domain\\username and password.&lt;/br&gt;  SAML - Uses the SAML settings configured for CSM to validate credentials and find the CSM user.&lt;/br&gt;  Auto - Uses the enabled authentication types configured for CSM.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType">The type of grant being requested: password or refresh_token.</param>
        /// <param name="clientId">The API client key for the client making the token request.</param>
        /// <param name="clientSecret">The API client secret for the native client making the token request.  This is only required for native clients. (optional)</param>
        /// <param name="username">Specify the login ID for the CSM user who will be granted the access token.  (optional)</param>
        /// <param name="password">Specify the password assigned to the login ID. (optional)</param>
        /// <param name="refreshToken">Specify the refresh token used to grant another access token. (optional)</param>
        /// <param name="authMode">Specify the Authentication Mode to use for requesting an access token. (optional)</param>
        /// <param name="siteName">If for portal specify the Site name to use for requesting an access token. (optional)</param>
        /// <returns>TokenResponse</returns>
        TokenResponse ServiceToken(string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null, string siteName = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public  class ServiceApi : IServiceApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceApi(string basePath)
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

        public ServiceInfoResponse ServiceGetServiceInfoV1()
        {
            const string localVarPath = "/api/V1/serviceinfo";
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

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("ServiceGetServiceInfoV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<ServiceInfoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ServiceInfoResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ServiceInfoResponse))).Data;
        }

        public TokenResponse ServiceToken(string grantType, string clientId, string clientSecret = null, string username = null, string password = null, string refreshToken = null, string authMode = null, string siteName = null)
        {
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling ServiceApi->ServiceToken");
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling ServiceApi->ServiceToken");

            const string localVarPath = "/token";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            var localVarHttpContentTypes = new[] {"application/x-www-form-urlencoded"};
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccepts = new string[] { };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authMode != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "auth_mode", authMode)); // query parameter
            if (siteName != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "site_name", siteName)); // query parameter
            localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter
            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (refreshToken != null) localVarFormParams.Add("refresh_token", Configuration.ApiClient.ParameterToString(refreshToken)); // form parameter

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("ServiceToken", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<TokenResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenResponse))).Data;
        }

        public void ServiceLogoutUserV1()
        {
            const string localVarPath = "/api/V1/logout";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            var localVarHttpContentTypes = new string[] { };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccepts = new string[] {
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("ServiceLogoutUserV1", localVarResponse);
            if (exception != null) throw exception;

            var unused = new ApiResponse<object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null).Data;
        }
    }
}