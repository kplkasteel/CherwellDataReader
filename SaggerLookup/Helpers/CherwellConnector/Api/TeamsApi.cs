using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class TeamsApi : BaseApi, ITeamsApi
{
    #region Variables & Properties

    private static TeamsApi _instance;

    private static readonly object Padlock = new();

    public static TeamsApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new TeamsApi();

                _instance = (TeamsApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Constructor

    private TeamsApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructor

    #region TeamsAddUserToTeamByBatchV1

    public AddUserToTeamByBatchResponse TeamsAddUserToTeamByBatchV1(AddUserToTeamByBatchRequest request,
        string lang = null, string locale = null)
    {
        return TeamsAddUserToTeamByBatchV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<AddUserToTeamByBatchResponse> TeamsAddUserToTeamByBatchV1WithHttpInfo(
        AddUserToTeamByBatchRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling TeamsApi->TeamsAddUserToTeamByBatchV1");

        const string varPath = "/api/V1/addusertoteambybatch";
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

        var exception = ExceptionFactory?.Invoke("TeamsAddUserToTeamByBatchV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AddUserToTeamByBatchResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AddUserToTeamByBatchResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AddUserToTeamByBatchResponse)));
    }

    #endregion TeamsAddUserToTeamByBatchV1

    #region TeamsAddUserToTeamV1

    public object TeamsAddUserToTeamV1(AddUserToTeamRequest dataRequest, string lang = null, string locale = null)
    {
        return TeamsAddUserToTeamV1WithHttpInfo(dataRequest, lang, locale).Data;
    }

    private ApiResponse<object> TeamsAddUserToTeamV1WithHttpInfo(AddUserToTeamRequest dataRequest,
        string lang = null, string locale = null)
    {
        if (dataRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'dataRequest' when calling TeamsApi->TeamsAddUserToTeamV1");

        const string varPath = "/api/V1/addusertoteam";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentType = ApiClient.SelectHeaderContentType(LocalVarHttpContentTypes);

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
        if (dataRequest.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(dataRequest);
        else
            localVarPostBody = dataRequest;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("TeamsAddUserToTeamV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion TeamsAddUserToTeamV1

    #region TeamsAddUserToTeamV2

    public AddUserToTeamResponse TeamsAddUserToTeamV2(AddUserToTeamRequest dataRequest, string lang = null,
        string locale = null)
    {
        return TeamsAddUserToTeamV2WithHttpInfo(dataRequest, lang, locale).Data;
    }

    private ApiResponse<AddUserToTeamResponse> TeamsAddUserToTeamV2WithHttpInfo(AddUserToTeamRequest dataRequest,
        string lang = null, string locale = null)
    {
        if (dataRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'dataRequest' when calling TeamsApi->TeamsAddUserToTeamV2");

        const string varPath = "/api/V2/addusertoteam";
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
        if (dataRequest.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(dataRequest);
        else
            localVarPostBody = dataRequest;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("TeamsAddUserToTeamV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AddUserToTeamResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AddUserToTeamResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AddUserToTeamResponse)));
    }

    #endregion TeamsAddUserToTeamV2

    #region TeamsDeleteTeamV1

    public object TeamsDeleteTeamV1(string teamid, string lang = null, string locale = null)
    {
        return TeamsDeleteTeamV1WithHttpInfo(teamid, lang, locale).Data;
    }

    private ApiResponse<object> TeamsDeleteTeamV1WithHttpInfo(string teamid, string lang = null,
        string locale = null)
    {
        if (teamid == null)
            throw new ApiException(400,
                "Missing required parameter 'teamid' when calling TeamsApi->TeamsDeleteTeamV1");

        var localVarPath = $"/api/V1/Deleteteam/{teamid}";
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

        localVarPathParams.Add("teamid", Configuration.ApiClient.ParameterToString(teamid));
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

        var exception = ExceptionFactory?.Invoke("TeamsDeleteTeamV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion TeamsDeleteTeamV1

    #region TeamsGetTeamV1

    public TeamResponse TeamsGetTeamV1(string teamid, string lang = null, string locale = null)
    {
        return TeamsGetTeamV1WithHttpInfo(teamid, lang, locale).Data;
    }

    private ApiResponse<TeamResponse> TeamsGetTeamV1WithHttpInfo(string teamid, string lang = null,
        string locale = null)
    {
        if (teamid == null)
            throw new ApiException(400,
                "Missing required parameter 'teamid' when calling TeamsApi->TeamsGetTeamV1");

        var localVarPath = $"/api/V1/Getteam/{teamid}";
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

        localVarPathParams.Add("teamid", Configuration.ApiClient.ParameterToString(teamid));
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

        var exception = ExceptionFactory?.Invoke("TeamsGetTeamV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TeamResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TeamResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamResponse)));
    }

    #endregion TeamsGetTeamV1

    #region TeamsGetTeamsV1

    public TeamsResponse TeamsGetTeamsV1(string lang = null, string locale = null)
    {
        return TeamsGetTeamsV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<TeamsResponse> TeamsGetTeamsV1WithHttpInfo(string lang = null, string locale = null)
    {
        const string varPath = "/api/V1/Getteams";
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

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("TeamsGetTeamsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TeamsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TeamsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsResponse)));
    }

    #endregion TeamsGetTeamsV1

    #region TeamsGetTeamsV2

    public TeamsV2Response TeamsGetTeamsV2(string lang = null, string locale = null)
    {
        return TeamsGetTeamsV2WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<TeamsV2Response> TeamsGetTeamsV2WithHttpInfo(string lang = null, string locale = null)
    {
        const string varPath = "/api/V2/Getteams";
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

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("TeamsGetTeamsV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TeamsV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TeamsV2Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsV2Response)));
    }

    #endregion TeamsGetTeamsV2

    #region TeamsGetUsersTeamsV1

    public TeamsResponse TeamsGetUsersTeamsV1(string userRecordId, string lang = null, string locale = null)
    {
        return TeamsGetUsersTeamsV1WithHttpInfo(userRecordId, lang, locale).Data;
    }

    private ApiResponse<TeamsResponse> TeamsGetUsersTeamsV1WithHttpInfo(string userRecordId, string lang = null,
        string locale = null)
    {
        if (userRecordId == null)
            throw new ApiException(400,
                "Missing required parameter 'userRecordId' when calling TeamsApi->TeamsGetUsersTeamsV1");

        var localVarPath = $"/api/V1/Getusersteams/userrecordid/{userRecordId}";
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

        localVarPathParams.Add("userRecordId",
            Configuration.ApiClient.ParameterToString(userRecordId));
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

        var exception = ExceptionFactory?.Invoke("TeamsGetUsersTeamsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TeamsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TeamsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsResponse)));
    }

    #endregion TeamsGetUsersTeamsV1

    #region TeamsGetUsersTeamsV2

    public TeamsV2Response TeamsGetUsersTeamsV2(string userRecordId, string lang = null, string locale = null)
    {
        return TeamsGetUsersTeamsV2WithHttpInfo(userRecordId, lang, locale).Data;
    }

    private ApiResponse<TeamsV2Response> TeamsGetUsersTeamsV2WithHttpInfo(string userRecordId, string lang = null,
        string locale = null)
    {
        if (userRecordId == null)
            throw new ApiException(400,
                "Missing required parameter 'userRecordId' when calling TeamsApi->TeamsGetUsersTeamsV2");

        var localVarPath = $"/api/V2/Getusersteams/userrecordid/{userRecordId}";
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

        localVarPathParams.Add("userRecordId",
            Configuration.ApiClient.ParameterToString(userRecordId));
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

        var exception = ExceptionFactory?.Invoke("TeamsGetUsersTeamsV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TeamsV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TeamsV2Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsV2Response)));
    }

    #endregion TeamsGetUsersTeamsV2

    #region TeamsGetWorkgroupsV1

    public TeamsResponse TeamsGetWorkgroupsV1(string lang = null, string locale = null)
    {
        return TeamsGetWorkgroupsV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<TeamsResponse> TeamsGetWorkgroupsV1WithHttpInfo(string lang = null, string locale = null)
    {
        const string varPath = "/api/V1/Getworkgroups";
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

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("TeamsGetWorkgroupsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TeamsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TeamsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsResponse)));
    }

    #endregion TeamsGetWorkgroupsV1

    #region TeamsGetWorkgroupsV2

    public TeamsV2Response TeamsGetWorkgroupsV2(string lang = null, string locale = null)
    {
        return TeamsGetWorkgroupsV2WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<TeamsV2Response> TeamsGetWorkgroupsV2WithHttpInfo(string lang = null, string locale = null)
    {
        const string varPath = "/api/V2/Getworkgroups";
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

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("TeamsGetWorkgroupsV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TeamsV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TeamsV2Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamsV2Response)));
    }

    #endregion TeamsGetWorkgroupsV2

    #region TeamsRemoveCustomerFromWorkgroupV1

    public RemoveCustomerFromWorkgroupResponse TeamsRemoveCustomerFromWorkgroupV1(string workgroupid,
        string customerrecordid, string lang = null, string locale = null)
    {
        return TeamsRemoveCustomerFromWorkgroupV1WithHttpInfo(workgroupid, customerrecordid, lang, locale).Data;
    }

    private ApiResponse<RemoveCustomerFromWorkgroupResponse> TeamsRemoveCustomerFromWorkgroupV1WithHttpInfo(
        string workgroupid, string customerrecordid, string lang = null, string locale = null)
    {
        if (workgroupid == null)
            throw new ApiException(400,
                "Missing required parameter 'workgroupid' when calling TeamsApi->TeamsRemoveCustomerFromWorkgroupV1");
        if (customerrecordid == null)
            throw new ApiException(400,
                "Missing required parameter 'customerrecordid' when calling TeamsApi->TeamsRemoveCustomerFromWorkgroupV1");

        var localVarPath =
            $"/api/V1/removecustomerfromworkgroup/workgroupid/{workgroupid}/customerrecordid/{customerrecordid}";
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

        localVarPathParams.Add("workgroupid",
            Configuration.ApiClient.ParameterToString(workgroupid));
        localVarPathParams.Add("customerrecordid",
            Configuration.ApiClient.ParameterToString(customerrecordid));
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

        var exception = ExceptionFactory?.Invoke("TeamsRemoveCustomerFromWorkgroupV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<RemoveCustomerFromWorkgroupResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (RemoveCustomerFromWorkgroupResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(RemoveCustomerFromWorkgroupResponse)));
    }

    #endregion TeamsRemoveCustomerFromWorkgroupV1

    #region TeamsRemoveUserFromTeamV1

    public object TeamsRemoveUserFromTeamV1(string teamId, string userrecordid, string lang = null,
        string locale = null)
    {
        return TeamsRemoveUserFromTeamV1WithHttpInfo(teamId, userrecordid, lang, locale).Data;
    }

    private ApiResponse<object> TeamsRemoveUserFromTeamV1WithHttpInfo(string teamId, string userrecordid,
        string lang = null, string locale = null)
    {
        if (teamId == null)
            throw new ApiException(400,
                "Missing required parameter 'teamId' when calling TeamsApi->TeamsRemoveUserFromTeamV1");
        if (userrecordid == null)
            throw new ApiException(400,
                "Missing required parameter 'userrecordid' when calling TeamsApi->TeamsRemoveUserFromTeamV1");

        var localVarPath = $"/api/V1/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid}";
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

        localVarPathParams.Add("teamId", Configuration.ApiClient.ParameterToString(teamId));
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

        var exception = ExceptionFactory?.Invoke("TeamsRemoveUserFromTeamV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion TeamsRemoveUserFromTeamV1

    #region TeamsRemoveUserFromTeamV2

    public RemoveUserFromTeamResponse TeamsRemoveUserFromTeamV2(string teamId, string userrecordid,
        string lang = null, string locale = null)
    {
        return TeamsRemoveUserFromTeamV2WithHttpInfo(teamId, userrecordid, lang, locale).Data;
    }

    private ApiResponse<RemoveUserFromTeamResponse> TeamsRemoveUserFromTeamV2WithHttpInfo(string teamId,
        string userrecordid, string lang = null, string locale = null)
    {
        if (teamId == null)
            throw new ApiException(400,
                "Missing required parameter 'teamId' when calling TeamsApi->TeamsRemoveUserFromTeamV2");
        if (userrecordid == null)
            throw new ApiException(400,
                "Missing required parameter 'userrecordid' when calling TeamsApi->TeamsRemoveUserFromTeamV2");

        var varPath = $"/api/V2/removeuserfromteam/teamid/{teamId}/userrecordid/{userrecordid}";
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

        localVarPathParams.Add("teamId", Configuration.ApiClient.ParameterToString(teamId));
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

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("TeamsRemoveUserFromTeamV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<RemoveUserFromTeamResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (RemoveUserFromTeamResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(RemoveUserFromTeamResponse)));
    }

    #endregion TeamsRemoveUserFromTeamV2

    #region TeamsSaveTeamMemberV1

    public SaveTeamMemberResponse TeamsSaveTeamMemberV1(SaveTeamMemberRequest request, string lang = null,
        string locale = null)
    {
        return TeamsSaveTeamMemberV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<SaveTeamMemberResponse> TeamsSaveTeamMemberV1WithHttpInfo(SaveTeamMemberRequest request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling TeamsApi->TeamsSaveTeamMemberV1");

        const string varPath = "/api/V1/saveteammember";
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

        var exception = ExceptionFactory?.Invoke("TeamsSaveTeamMemberV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SaveTeamMemberResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SaveTeamMemberResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SaveTeamMemberResponse)));
    }

    #endregion TeamsSaveTeamMemberV1

    #region TeamsSaveTeamV1

    public TeamSaveResponse TeamsSaveTeamV1(TeamSaveRequest request, string lang = null, string locale = null)
    {
        return TeamsSaveTeamV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<TeamSaveResponse> TeamsSaveTeamV1WithHttpInfo(TeamSaveRequest request, string lang = null,
        string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling TeamsApi->TeamsSaveTeamV1");

        const string varPath = "/api/V1/saveteam";
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

        var exception = ExceptionFactory?.Invoke("TeamsSaveTeamV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TeamSaveResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TeamSaveResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TeamSaveResponse)));
    }

    #endregion TeamsSaveTeamV1

    #region TeamsSaveWorkgroupMemberV1

    public SaveWorkgroupMemberResponse TeamsSaveWorkgroupMemberV1(SaveWorkgroupMemberRequest request,
        string lang = null, string locale = null)
    {
        return TeamsSaveWorkgroupMemberV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<SaveWorkgroupMemberResponse> TeamsSaveWorkgroupMemberV1WithHttpInfo(
        SaveWorkgroupMemberRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling TeamsApi->TeamsSaveWorkgroupMemberV1");

        const string varPath = "/api/V1/saveworkgroupmember";
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

        var exception = ExceptionFactory?.Invoke("TeamsSaveWorkgroupMemberV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SaveWorkgroupMemberResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SaveWorkgroupMemberResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SaveWorkgroupMemberResponse)));
    }

    #endregion TeamsSaveWorkgroupMemberV1
}