using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class OneStepActionsApi : BaseApi, IOneStepActionsApi
{
    #region Variables & Properties

    private static OneStepActionsApi _instance;

    private static readonly object Padlock = new();

    public static OneStepActionsApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new OneStepActionsApi();

                _instance = (OneStepActionsApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Constructors

    private OneStepActionsApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructors

    #region OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1

    public ManagerData OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1(string association,
        string scope, string scopeowner, string folder, bool? links = null, string lang = null,
        string locale = null)
    {
        return OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1WithHttpInfo(association, scope,
            scopeowner, folder, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData>
        OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1WithHttpInfo(string association,
            string scope, string scopeowner, string folder, bool? links = null, string lang = null,
            string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1");
        if (folder == null)
            throw new ApiException(400,
                "Missing required parameter 'folder' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1");

        var localVarPath =
            $"/api/V1/Getonestepactions/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

        localVarPathParams.Add("association",
            Configuration.ApiClient.ParameterToString(association));
        localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope));
        localVarPathParams.Add("scopeowner",
            Configuration.ApiClient.ParameterToString(scopeowner));
        localVarPathParams.Add("folder", Configuration.ApiClient.ParameterToString(folder));
        if (links != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links));
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

        var exception =
            ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1",
                localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerFolderV1

    #region OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1

    public ManagerData OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1(string association,
        string scope, string scopeowner, bool? links = null, string lang = null, string locale = null)
    {
        return OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1WithHttpInfo(association, scope,
            scopeowner, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1WithHttpInfo(
        string association, string scope, string scopeowner, bool? links = null, string lang = null,
        string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1");

        var localVarPath =
            $"/api/V1/Getonestepactions/association/{association}/scope/{scope}/scopeowner/{scopeowner}";
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

        localVarPathParams.Add("association",
            Configuration.ApiClient.ParameterToString(association));
        localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope));
        localVarPathParams.Add("scopeowner",
            Configuration.ApiClient.ParameterToString(scopeowner));
        if (links != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links));
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

        var exception = ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion OneStepActionsGetOneStepActionsByAssociationScopeScopeOwnerV1

    #region OneStepActionsGetOneStepActionsByAssociationScopeV1

    public ManagerData OneStepActionsGetOneStepActionsByAssociationScopeV1(string association, string scope,
        bool? links = null, string lang = null, string locale = null)
    {
        return OneStepActionsGetOneStepActionsByAssociationScopeV1WithHttpInfo(association, scope, links, lang,
            locale).Data;
    }

    private ApiResponse<ManagerData> OneStepActionsGetOneStepActionsByAssociationScopeV1WithHttpInfo(
        string association, string scope, bool? links = null, string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationScopeV1");

        var localVarPath = $"/api/V1/Getonestepactions/association/{association}/scope/{scope}";
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

        localVarPathParams.Add("association",
            Configuration.ApiClient.ParameterToString(association));
        localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope));
        if (links != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links));
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

        var exception =
            ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationScopeV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion OneStepActionsGetOneStepActionsByAssociationScopeV1

    #region OneStepActionsGetOneStepActionsByAssociationV1

    public ManagerData OneStepActionsGetOneStepActionsByAssociationV1(string association, bool? links = null,
        string lang = null, string locale = null)
    {
        return OneStepActionsGetOneStepActionsByAssociationV1WithHttpInfo(association, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> OneStepActionsGetOneStepActionsByAssociationV1WithHttpInfo(string association,
        bool? links = null, string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling OneStepActionsApi->OneStepActionsGetOneStepActionsByAssociationV1");

        var localVarPath = $"/api/V1/Getonestepactions/association/{association}";
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

        localVarPathParams.Add("association",
            Configuration.ApiClient.ParameterToString(association));
        if (links != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links));
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

        var exception =
            ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsByAssociationV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion OneStepActionsGetOneStepActionsByAssociationV1

    #region OneStepActionsGetOneStepActionsV1

    public ManagerData OneStepActionsGetOneStepActionsV1(bool? links = null, string lang = null,
        string locale = null)
    {
        return OneStepActionsGetOneStepActionsV1WithHttpInfo(links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> OneStepActionsGetOneStepActionsV1WithHttpInfo(bool? links = null,
        string lang = null, string locale = null)
    {
        const string varPath = "/api/V1/Getonestepactions";
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

        if (links != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links));
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

        var exception = ExceptionFactory?.Invoke("OneStepActionsGetOneStepActionsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion OneStepActionsGetOneStepActionsV1

    #region OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1

    public OneStepActionResponse OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1(string standinkey,
        string busobid, string busobrecid, string lang = null, string locale = null)
    {
        return OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1WithHttpInfo(standinkey, busobid, busobrecid,
            lang, locale).Data;
    }

    private ApiResponse<OneStepActionResponse> OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1WithHttpInfo(
        string standinkey, string busobid, string busobrecid, string lang = null, string locale = null)
    {
        if (standinkey == null)
            throw new ApiException(400,
                "Missing required parameter 'standinkey' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1");

        var localVarPath =
            $"/api/V1/runonestepaction/standinkey/{standinkey}/busobid/{busobid}/busobrecid/{busobrecid}";
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

        localVarPathParams.Add("standinkey",
            Configuration.ApiClient.ParameterToString(standinkey));
        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
        localVarPathParams.Add("busobrecid",
            Configuration.ApiClient.ParameterToString(busobrecid));
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

        var exception = ExceptionFactory?.Invoke("OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<OneStepActionResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (OneStepActionResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(OneStepActionResponse)));
    }

    #endregion OneStepActionsRunOneStepActionByKeyForRecordByRecIdV1

    #region OneStepActionsRunOneStepActionByStandInKeyV1

    public OneStepActionResponse OneStepActionsRunOneStepActionByStandInKeyV1(string standinkey, string lang = null,
        string locale = null)
    {
        return OneStepActionsRunOneStepActionByStandInKeyV1WithHttpInfo(standinkey, lang, locale).Data;
    }

    private ApiResponse<OneStepActionResponse> OneStepActionsRunOneStepActionByStandInKeyV1WithHttpInfo(
        string standinkey, string lang = null, string locale = null)
    {
        if (standinkey == null)
            throw new ApiException(400,
                "Missing required parameter 'standinkey' when calling OneStepActionsApi->OneStepActionsRunOneStepActionByStandInKeyV1");

        var localVarPath = $"/api/V1/runonestepaction/standinkey/{standinkey}";
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

        localVarPathParams.Add("standinkey",
            Configuration.ApiClient.ParameterToString(standinkey));
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

        var exception = ExceptionFactory?.Invoke("OneStepActionsRunOneStepActionByStandInKeyV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<OneStepActionResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (OneStepActionResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(OneStepActionResponse)));
    }

    #endregion OneStepActionsRunOneStepActionByStandInKeyV1

    #region OneStepActionsRunOneStepActionV1

    public OneStepActionResponse OneStepActionsRunOneStepActionV1(OneStepActionRequest request, string lang = null,
        string locale = null)
    {
        return OneStepActionsRunOneStepActionV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<OneStepActionResponse> OneStepActionsRunOneStepActionV1WithHttpInfo(
        OneStepActionRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling OneStepActionsApi->OneStepActionsRunOneStepActionV1");

        const string varPath = "/api/V1/runonestepaction";
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

        var exception = ExceptionFactory?.Invoke("OneStepActionsRunOneStepActionV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<OneStepActionResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (OneStepActionResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(OneStepActionResponse)));
    }

    #endregion OneStepActionsRunOneStepActionV1
}