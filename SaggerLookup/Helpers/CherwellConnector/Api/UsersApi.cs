using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class UsersApi : BaseApi, IUsersApi
{
    #region Variables & Properties

    private static UsersApi _instance;

    private static readonly object Padlock = new();

    public static UsersApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new UsersApi();

                _instance = (UsersApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Contructors

    private UsersApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Contructors

    #region UsersDeleteUserBatchV1

    public UserBatchDeleteResponse UsersDeleteUserBatchV1(UserBatchDeleteRequest request, string lang = null,
        string locale = null)
    {
        return UsersDeleteUserBatchV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<UserBatchDeleteResponse> UsersDeleteUserBatchV1WithHttpInfo(UserBatchDeleteRequest request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling UsersApi->UsersDeleteUserBatchV1");

        const string varPath = "/api/V1/Deleteuserbatch";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (request.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(request);
        else
            localVarPostBody = request;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersDeleteUserBatchV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserBatchDeleteResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserBatchDeleteResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(UserBatchDeleteResponse)));
    }

    #endregion UsersDeleteUserBatchV1

    #region UsersDeleteUserBatchV2

    public UserBatchDeleteV2Response UsersDeleteUserBatchV2(UserBatchDeleteRequest request, string lang = null,
        string locale = null)
    {
        return UsersDeleteUserBatchV2WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<UserBatchDeleteV2Response> UsersDeleteUserBatchV2WithHttpInfo(
        UserBatchDeleteRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling UsersApi->UsersDeleteUserBatchV2");

        const string varPath = "/api/V2/Deleteuserbatch";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (request.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(request);
        else
            localVarPostBody = request;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersDeleteUserBatchV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserBatchDeleteV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserBatchDeleteV2Response)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(UserBatchDeleteV2Response)));
    }

    #endregion UsersDeleteUserBatchV2

    #region UsersDeleteUserV1

    public UserDeleteResponse UsersDeleteUserV1(string userrecordid, string lang = null, string locale = null)
    {
        return UsersDeleteUserV1WithHttpInfo(userrecordid, lang, locale).Data;
    }

    private ApiResponse<UserDeleteResponse> UsersDeleteUserV1WithHttpInfo(string userrecordid, string lang = null,
        string locale = null)
    {
        if (userrecordid == null)
            throw new ApiException(400,
                "Missing required parameter 'userrecordid' when calling UsersApi->UsersDeleteUserV1");

        var localVarPath = $"/api/V1/Deleteuser/userrecordid/{userrecordid}";
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

        localVarPathParams.Add("userrecordid",
            Configuration.ApiClient.ParameterToString(userrecordid));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersDeleteUserV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserDeleteResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserDeleteResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserDeleteResponse)));
    }

    #endregion UsersDeleteUserV1

    #region UsersDeleteUserV2

    public UserDeleteV2Response UsersDeleteUserV2(string userrecordid, string lang = null, string locale = null)
    {
        return UsersDeleteUserV2WithHttpInfo(userrecordid, lang, locale).Data;
    }

    private ApiResponse<UserDeleteV2Response> UsersDeleteUserV2WithHttpInfo(string userrecordid, string lang = null,
        string locale = null)
    {
        if (userrecordid == null)
            throw new ApiException(400,
                "Missing required parameter 'userrecordid' when calling UsersApi->UsersDeleteUserV2");

        var localVarPath = $"/api/V2/Deleteuser/userrecordid/{userrecordid}";
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

        localVarPathParams.Add("userrecordid",
            Configuration.ApiClient.ParameterToString(userrecordid));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersDeleteUserV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserDeleteV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserDeleteV2Response)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(UserDeleteV2Response)));
    }

    #endregion UsersDeleteUserV2

    #region UsersGetListOfUsers

    public UserListResponse UsersGetListOfUsers(string loginidfilter, bool? stoponerror = null, string lang = null,
        string locale = null)
    {
        return UsersGetListOfUsersWithHttpInfo(loginidfilter, stoponerror, lang, locale).Data;
    }

    private ApiResponse<UserListResponse> UsersGetListOfUsersWithHttpInfo(string loginidfilter,
        bool? stoponerror = null, string lang = null, string locale = null)
    {
        if (loginidfilter == null)
            throw new ApiException(400,
                "Missing required parameter 'loginidfilter' when calling UsersApi->UsersGetListOfUsers");

        const string varPath = "/api/V1/Getlistofusers";
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

        localVarQueryParams.AddRange(
            Configuration.ApiClient.ParameterToKeyValuePairs("", "loginidfilter",
                loginidfilter));
        if (stoponerror != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "stoponerror",
                    stoponerror));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersGetListOfUsers", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserListResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserListResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserListResponse)));
    }

    #endregion UsersGetListOfUsers

    #region UsersGetUserBatchV1

    public UserBatchReadResponse UsersGetUserBatchV1(UserBatchReadRequest request, string lang = null,
        string locale = null)
    {
        return UsersGetUserBatchV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<UserBatchReadResponse> UsersGetUserBatchV1WithHttpInfo(UserBatchReadRequest request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling UsersApi->UsersGetUserBatchV1");

        const string varPath = "/api/V1/Getuserbatch";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (request.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(request);
        else
            localVarPostBody = request;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersGetUserBatchV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserBatchReadResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserBatchReadResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(UserBatchReadResponse)));
    }

    #endregion UsersGetUserBatchV1

    #region UsersGetUserByLoginIdV1

    public User UsersGetUserByLoginIdV1(string loginid, string lang = null, string locale = null)
    {
        return UsersGetUserByLoginIdV1WithHttpInfo(loginid, lang, locale).Data;
    }

    private ApiResponse<User> UsersGetUserByLoginIdV1WithHttpInfo(string loginid, string lang = null,
        string locale = null)
    {
        if (loginid == null)
            throw new ApiException(400,
                "Missing required parameter 'loginid' when calling UsersApi->UsersGetUserByLoginIdV1");

        var localVarPath = $"/api/V1/Getuserbyloginid/loginid/{loginid}";
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

        localVarPathParams.Add("loginid", Configuration.ApiClient.ParameterToString(loginid));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersGetUserByLoginIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<User>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (User)Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
    }

    #endregion UsersGetUserByLoginIdV1

    #region UsersGetUserByLoginIdV2

    public User UsersGetUserByLoginIdV2(string loginid, string loginidtype, string lang = null,
        string locale = null)
    {
        return UsersGetUserByLoginIdV2WithHttpInfo(loginid, loginidtype, lang, locale).Data;
    }

    private ApiResponse<User> UsersGetUserByLoginIdV2WithHttpInfo(string loginid, string loginidtype,
        string lang = null, string locale = null)
    {
        if (loginid == null)
            throw new ApiException(400,
                "Missing required parameter 'loginid' when calling UsersApi->UsersGetUserByLoginIdV2");
        if (loginidtype == null)
            throw new ApiException(400,
                "Missing required parameter 'loginidtype' when calling UsersApi->UsersGetUserByLoginIdV2");

        const string varPath = "/api/V2/Getuserbyloginid";
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

        localVarQueryParams.AddRange(
            Configuration.ApiClient.ParameterToKeyValuePairs("", "loginid", loginid));
        localVarQueryParams.AddRange(
            Configuration.ApiClient.ParameterToKeyValuePairs("", "loginidtype", loginidtype));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersGetUserByLoginIdV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<User>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (User)Configuration.ApiClient.Deserialize(localVarResponse, typeof(User)));
    }

    #endregion UsersGetUserByLoginIdV2

    #region UsersGetUserByLoginIdV3

    public UserV2 UsersGetUserByLoginIdV3(string loginid, string loginidtype, string lang = null,
        string locale = null)
    {
        return UsersGetUserByLoginIdV3WithHttpInfo(loginid, loginidtype, lang, locale).Data;
    }

    private ApiResponse<UserV2> UsersGetUserByLoginIdV3WithHttpInfo(string loginid, string loginidtype,
        string lang = null, string locale = null)
    {
        if (loginid == null)
            throw new ApiException(400,
                "Missing required parameter 'loginid' when calling UsersApi->UsersGetUserByLoginIdV3");
        if (loginidtype == null)
            throw new ApiException(400,
                "Missing required parameter 'loginidtype' when calling UsersApi->UsersGetUserByLoginIdV3");

        const string varPath = "/api/V3/Getuserbyloginid";
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

        localVarQueryParams.AddRange(
            Configuration.ApiClient.ParameterToKeyValuePairs("", "loginid", loginid));
        localVarQueryParams.AddRange(
            Configuration.ApiClient.ParameterToKeyValuePairs("", "loginidtype", loginidtype));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersGetUserByLoginIdV3", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserV2>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserV2)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserV2)));
    }

    #endregion UsersGetUserByLoginIdV3

    #region UsersGetUserByPublicIdV1

    public UserReadResponse UsersGetUserByPublicIdV1(string publicid, string lang = null, string locale = null)
    {
        return UsersGetUserByPublicIdV1WithHttpInfo(publicid, lang, locale).Data;
    }

    private ApiResponse<UserReadResponse> UsersGetUserByPublicIdV1WithHttpInfo(string publicid, string lang = null,
        string locale = null)
    {
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling UsersApi->UsersGetUserByPublicIdV1");

        var varPath = $"/api/V1/Getuserbypublicid/publicid/{publicid}";
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

        localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersGetUserByPublicIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserReadResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserReadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReadResponse)));
    }

    #endregion UsersGetUserByPublicIdV1

    #region UsersGetUserByPublicIdV2

    public UserReadV2Response UsersGetUserByPublicIdV2(string publicid, string lang = null, string locale = null)
    {
        return UsersGetUserByPublicIdV2WithHttpInfo(publicid, lang, locale).Data;
    }

    private ApiResponse<UserReadV2Response> UsersGetUserByPublicIdV2WithHttpInfo(string publicid,
        string lang = null, string locale = null)
    {
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling UsersApi->UsersGetUserByPublicIdV2");

        var localVarPath = $"/api/V2/Getuserbypublicid/publicid/{publicid}";
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

        localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersGetUserByPublicIdV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserReadV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserReadV2Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReadV2Response)));
    }

    #endregion UsersGetUserByPublicIdV2

    #region UsersGetUserByRecId

    public UserV2 UsersGetUserByRecId(string recid, string lang = null, string locale = null)
    {
        return UsersGetUserByRecIdWithHttpInfo(recid, lang, locale).Data;
    }

    private ApiResponse<UserV2> UsersGetUserByRecIdWithHttpInfo(string recid, string lang = null,
        string locale = null)
    {
        if (recid == null)
            throw new ApiException(400,
                "Missing required parameter 'recid' when calling UsersApi->UsersGetUserByRecId");

        var localVarPath = $"/api/V1/Getuserbyrecid/recid/{recid}";
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

        localVarPathParams.Add("recid", Configuration.ApiClient.ParameterToString(recid));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersGetUserByRecId", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserV2>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserV2)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserV2)));
    }

    #endregion UsersGetUserByRecId

    #region UsersSaveUserBatchV1

    public UserBatchSaveResponse UsersSaveUserBatchV1(UserBatchSaveRequest request, string lang = null,
        string locale = null)
    {
        return UsersSaveUserBatchV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<UserBatchSaveResponse> UsersSaveUserBatchV1WithHttpInfo(UserBatchSaveRequest request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling UsersApi->UsersSaveUserBatchV1");

        const string varPath = "/api/V1/saveuserbatch";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (request.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(request);
        else
            localVarPostBody = request;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersSaveUserBatchV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserBatchSaveResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserBatchSaveResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(UserBatchSaveResponse)));
    }

    #endregion UsersSaveUserBatchV1

    #region UsersSaveUserBatchV2

    public UserBatchSaveV2Response UsersSaveUserBatchV2(UserBatchSaveV2Request request, string lang = null,
        string locale = null)
    {
        return UsersSaveUserBatchV2WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<UserBatchSaveV2Response> UsersSaveUserBatchV2WithHttpInfo(UserBatchSaveV2Request request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling UsersApi->UsersSaveUserBatchV2");

        const string varPath = "/api/V2/saveuserbatch";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (request.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(request);
        else
            localVarPostBody = request;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersSaveUserBatchV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserBatchSaveV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserBatchSaveV2Response)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(UserBatchSaveV2Response)));
    }

    #endregion UsersSaveUserBatchV2

    #region UsersSaveUserV1

    public UserSaveResponse UsersSaveUserV1(UserSaveRequest request, string lang = null, string locale = null)
    {
        return UsersSaveUserV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<UserSaveResponse> UsersSaveUserV1WithHttpInfo(UserSaveRequest request, string lang = null,
        string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling UsersApi->UsersSaveUserV1");

        const string varPath = "/api/V1/saveuser";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (request.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(request);
        else
            localVarPostBody = request;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersSaveUserV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserSaveResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserSaveResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSaveResponse)));
    }

    #endregion UsersSaveUserV1

    #region UsersSaveUserV2

    public UserSaveV2Response UsersSaveUserV2(UserSaveV2Request request, string lang = null, string locale = null)
    {
        return UsersSaveUserV2WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<UserSaveV2Response> UsersSaveUserV2WithHttpInfo(UserSaveV2Request request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling UsersApi->UsersSaveUserV2");

        const string varPath = "/api/V2/saveuser";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (request.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(request);
        else
            localVarPostBody = request;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("UsersSaveUserV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserSaveV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserSaveV2Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserSaveV2Response)));
    }

    #endregion UsersSaveUserV2
}