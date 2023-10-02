using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class QueuesApi : BaseApi, IQueuesApi
{
    #region Variables & Properties

    private static QueuesApi _instance;

    private static readonly object Padlock = new();

    public static QueuesApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new QueuesApi();

                _instance = (QueuesApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Constructors

    
    private QueuesApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructors

    #region AddItemToQueueResponse

    public AddItemToQueueResponse QueuesAddItemToQueueV1(AddItemToQueueRequest request, string lang = null,
        string locale = null)
    {
        return QueuesAddItemToQueueV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<AddItemToQueueResponse> QueuesAddItemToQueueV1WithHttpInfo(AddItemToQueueRequest request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling QueuesApi->QueuesAddItemToQueueV1");

        const string varPath = "/api/V1/additemtoqueue";
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

        var exception = ExceptionFactory?.Invoke("QueuesAddItemToQueueV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AddItemToQueueResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AddItemToQueueResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AddItemToQueueResponse)));
    }

    #endregion AddItemToQueueResponse

    #region QueuesCheckInQueueItemV1

    public CheckInQueueItemResponse QueuesCheckInQueueItemV1(CheckInQueueItemRequest request, string lang = null,
        string locale = null)
    {
        return QueuesCheckInQueueItemV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<CheckInQueueItemResponse> QueuesCheckInQueueItemV1WithHttpInfo(
        CheckInQueueItemRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling QueuesApi->QueuesCheckInQueueItemV1");

        const string varPath = "/api/V1/checkinqueueitem";
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

        var exception = ExceptionFactory?.Invoke("QueuesCheckInQueueItemV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<CheckInQueueItemResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (CheckInQueueItemResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(CheckInQueueItemResponse)));
    }

    #endregion QueuesCheckInQueueItemV1

    #region QueuesCheckOutQueueItemV1

    public CheckOutQueueItemResponse QueuesCheckOutQueueItemV1(CheckOutQueueItemRequest request, string lang = null,
        string locale = null)
    {
        return QueuesCheckOutQueueItemV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<CheckOutQueueItemResponse> QueuesCheckOutQueueItemV1WithHttpInfo(
        CheckOutQueueItemRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling QueuesApi->QueuesCheckOutQueueItemV1");

        const string varPath = "/api/V1/checkoutqueueitem";
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

        var exception = ExceptionFactory?.Invoke("QueuesCheckOutQueueItemV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<CheckOutQueueItemResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (CheckOutQueueItemResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(CheckOutQueueItemResponse)));
    }

    #endregion QueuesCheckOutQueueItemV1

    #region QueuesGetQueuesFolderV1

    public ManagerData QueuesGetQueuesFolderV1(string scope, string scopeowner, string folder, bool? links = null,
        string lang = null, string locale = null)
    {
        return QueuesGetQueuesFolderV1WithHttpInfo(scope, scopeowner, folder, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> QueuesGetQueuesFolderV1WithHttpInfo(string scope, string scopeowner,
        string folder, bool? links = null, string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling QueuesApi->QueuesGetQueuesFolderV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling QueuesApi->QueuesGetQueuesFolderV1");
        if (folder == null)
            throw new ApiException(400,
                "Missing required parameter 'folder' when calling QueuesApi->QueuesGetQueuesFolderV1");

        var localVarPath = $"/api/V1/Getqueues/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

        var exception = ExceptionFactory?.Invoke("QueuesGetQueuesFolderV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion QueuesGetQueuesFolderV1

    #region QueuesGetQueuesScopeOwnerV1

    public ManagerData QueuesGetQueuesScopeOwnerV1(string scope, string scopeowner, bool? links = null,
        string lang = null, string locale = null)
    {
        return QueuesGetQueuesScopeOwnerV1WithHttpInfo(scope, scopeowner, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> QueuesGetQueuesScopeOwnerV1WithHttpInfo(string scope, string scopeowner,
        bool? links = null, string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling QueuesApi->QueuesGetQueuesScopeOwnerV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling QueuesApi->QueuesGetQueuesScopeOwnerV1");

        var localVarPath = $"/api/V1/Getqueues/scope/{scope}/scopeowner/{scopeowner}";
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

        var exception = ExceptionFactory?.Invoke("QueuesGetQueuesScopeOwnerV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion QueuesGetQueuesScopeOwnerV1

    #region QueuesGetQueuesScopeV1

    public ManagerData QueuesGetQueuesScopeV1(string scope, bool? links = null, string lang = null,
        string locale = null)
    {
        return QueuesGetQueuesScopeV1WithHttpInfo(scope, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> QueuesGetQueuesScopeV1WithHttpInfo(string scope, bool? links = null,
        string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling QueuesApi->QueuesGetQueuesScopeV1");

        var localVarPath = $"/api/V1/Getqueues/scope/{scope}";
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

        var exception = ExceptionFactory?.Invoke("QueuesGetQueuesScopeV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion QueuesGetQueuesScopeV1

    #region QueuesGetQueuesV1

    public ManagerData QueuesGetQueuesV1(bool? links = null, string lang = null, string locale = null)
    {
        return QueuesGetQueuesV1WithHttpInfo(links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> QueuesGetQueuesV1WithHttpInfo(bool? links = null, string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/Getqueues";
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

        var exception = ExceptionFactory?.Invoke("QueuesGetQueuesV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion QueuesGetQueuesV1

    #region QueuesRemoveItemFromQueueV1

    public RemoveItemFromQueueResponse QueuesRemoveItemFromQueueV1(RemoveItemFromQueueRequest request,
        string lang = null, string locale = null)
    {
        return QueuesRemoveItemFromQueueV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<RemoveItemFromQueueResponse> QueuesRemoveItemFromQueueV1WithHttpInfo(
        RemoveItemFromQueueRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling QueuesApi->QueuesRemoveItemFromQueueV1");

        const string varPath = "/api/V1/removeitemfromqueue";
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

        var exception = ExceptionFactory?.Invoke("QueuesRemoveItemFromQueueV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<RemoveItemFromQueueResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (RemoveItemFromQueueResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(RemoveItemFromQueueResponse)));
    }

    #endregion QueuesRemoveItemFromQueueV1
}