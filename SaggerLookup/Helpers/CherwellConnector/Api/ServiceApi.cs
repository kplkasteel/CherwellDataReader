using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Enum;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class ServiceApi : BaseApi, IServiceApi
{
    private bool _checkToken;
    private ServiceInfoResponse _serviceInfo;
    public ServiceInfoResponse ServiceInfo => _serviceInfo ??= Instance.ServiceGetServiceInfoV1();

    public ServiceApi(string basePath, GrantTypes grantType, string clientId,
        string username, string password, AuthModes authMode)
    {
        BasePath = basePath;
        GrantType = grantType;
        ClientId = clientId;
        UserName = username;
        Password = password;
        AuthMode = authMode;
        Configuration = new Configuration { BasePath = BasePath };

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    public ServiceTokenStatus CheckTokenResponse()
    {
        System.Threading.SpinWait.SpinUntil(() => !_checkToken);

        _checkToken = true;

        #region NewToken

        //Checks if the token is not null or if there is a existing a access token and request one of token is missing
        if (TokenResponse == null || string.IsNullOrEmpty(TokenResponse?.AccessToken))
        {
            TokenResponse = Instance.ServiceToken(GrantType.ToString(), ClientId, null, UserName, Password, null, AuthMode.ToString());

            if (TokenResponse != null)
            {
                _checkToken = false;
                return ServiceTokenStatus.Renewed;
            }

            for (var i = 0; i < 2; i++) // 3 attempts to retrieve the token. If  it fails 3 times token status will be set to failed and no further attempt will be possible
            {
                TokenResponse = Instance.ServiceToken(GrantType.ToString(), ClientId, null, UserName, Password, null,
                    AuthMode.ToString());
                if (TokenResponse != null) break;

            }
            _checkToken = false;
            return TokenResponse == null ? ServiceTokenStatus.Failed : ServiceTokenStatus.Renewed; ;
        }

        #endregion

        #region RenewToken

        //Checks if token is still valid and renews to token if token has expired
        var expiration = Convert.ToDateTime(TokenResponse.Expires, CultureInfo.GetCultureInfo(ServiceInfo.CsmCulture))
            .ToLocalTime().AddMinutes(-5);
        if (TokenResponse != null && expiration >= DateTime.Now)
        {
            _checkToken = false;
            return ServiceTokenStatus.Success;
        }

        Configuration = new Configuration { BasePath = BasePath };

        TokenResponse = Instance.ServiceToken(GrantType.ToString(), ClientId, null, UserName, Password, null,
            AuthMode.ToString());

        if (TokenResponse != null)
        {
            _checkToken = false;
            return TokenResponse == null ? ServiceTokenStatus.Failed : ServiceTokenStatus.Renewed;
        }

        for (var i = 0; i < 2; i++) // 3 attempts to retrieve the token. If  it fails 3 times token status will be set to failed and no further attempt will be possible
        {
            TokenResponse = Instance.ServiceToken(GrantType.ToString(), ClientId, null, UserName, Password, null,
                AuthMode.ToString());
            if (TokenResponse != null) break;

        }

        _checkToken = false;
        return TokenResponse == null ? ServiceTokenStatus.Failed : ServiceTokenStatus.Renewed;


        #endregion
    }

    internal IApiAccessor CheckApiHeader(IApiAccessor apiAccessor)
    {
        var tokenStatus = CheckTokenResponse();
        if (tokenStatus == ServiceTokenStatus.Failed) return null;
        if (!Configuration.DefaultHeader.Any() ||
            tokenStatus == ServiceTokenStatus.Renewed)
            Configuration.AddDefaultHeader("Authorization",
                "Bearer " + TokenResponse.AccessToken);

        return apiAccessor;
    }

    #region Variables & Properties

    public string Password { get; set; }

    public string UserName { get; }

    public string ClientId { get; }

    public string BasePath { get; }

    public AuthModes AuthMode { get; }

    public GrantTypes GrantType { get; }

    public TokenResponse TokenResponse { get; private set; }

    public static ServiceApi Instance { get; set; }

    #endregion Variables & Properties

    #region ServiceGetServiceInfoV1

    public ServiceInfoResponse ServiceGetServiceInfoV1(string lang = null, string locale = null)
    {
        return ServiceGetServiceInfoV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<ServiceInfoResponse> ServiceGetServiceInfoV1WithHttpInfo(string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/serviceinfo";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();

        var localVarHttpContentTypes = Array.Empty<string>();
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("ServiceGetServiceInfoV1", localVarResponse);
        if (exception != null) 
            throw exception;

        return new ApiResponse<ServiceInfoResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ServiceInfoResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(ServiceInfoResponse)));
    }

    #endregion ServiceGetServiceInfoV1

    #region ServiceLogoutUserV1

    public object ServiceLogoutUserV1(string lang = null, string locale = null)
    {
        try
        {
            TokenResponse = null;
            return ServiceLogoutUserV1WithHttpInfo(lang, locale).Data;
        }
        catch (Exception)
        {
            TokenResponse = null;
            return null;
        }
    }

    private ApiResponse<object> ServiceLogoutUserV1WithHttpInfo(string lang = null, string locale = null)
    {
        const string varPath = "/api/V1/logout";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();

        var localVarHttpContentTypes = Array.Empty<string>();
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccepts = Array.Empty<string>();
        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);

        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("ServiceLogoutUserV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion ServiceLogoutUserV1

    #region ServiceToken

    public TokenResponse ServiceToken(string grantType, string clientId, string clientSecret = null,
        string username = null, string password = null, string refreshToken = null, string authMode = null,
        string siteName = null)
    {
        return ServiceTokenWithHttpInfo(grantType, clientId, clientSecret, username, password, refreshToken,
            authMode, siteName).Data;
    }

    private ApiResponse<TokenResponse> ServiceTokenWithHttpInfo(string grantType, string clientId,
        string clientSecret = null, string username = null, string password = null, string refreshToken = null,
        string authMode = null, string siteName = null)
    {
        if (grantType == null)
            throw new ApiException(400,
                "Missing required parameter 'grantType' when calling ServiceApi->ServiceToken");
        if (clientId == null)
            throw new ApiException(400,
                "Missing required parameter 'clientId' when calling ServiceApi->ServiceToken");

        const string varPath = "/token";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();

        var localVarHttpContentTypes = new[]
        {
            "application/x-www-form-urlencoded"
        };
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccepts = Array.Empty<string>();
        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (authMode != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "auth_mode", authMode));
        if (siteName != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "site_name", siteName));
        localVarFormParams.Add("grant_type",
            Configuration.ApiClient.ParameterToString(grantType));
        localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId));
        if (clientSecret != null)
            localVarFormParams.Add("client_secret",
                Configuration.ApiClient.ParameterToString(clientSecret));
        if (username != null)
            localVarFormParams.Add("username",
                Configuration.ApiClient.ParameterToString(username));
        if (password != null)
            localVarFormParams.Add("password",
                Configuration.ApiClient.ParameterToString(password));
        if (refreshToken != null)
            localVarFormParams.Add("refresh_token",
                Configuration.ApiClient.ParameterToString(refreshToken));

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("ServiceToken", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TokenResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TokenResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TokenResponse)));
    }

    #endregion ServiceToken
}