using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class LifecycleApi : BaseApi, ILifecycleApi
{
    #region Variables & Properties

    private static LifecycleApi _instance;

    private static readonly object Padlock = new();

    public static LifecycleApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new LifecycleApi();

                _instance = (LifecycleApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Contructors

    private LifecycleApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Contructors

    #region LifecycleGetRecordStage

    public RecordStatusResponse LifecycleGetRecordStage(string businessObjectDefinitionId, string recordId,
        string lang = null, string locale = null)
    {
        return LifecycleGetRecordStageWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale).Data;
    }

    private ApiResponse<RecordStatusResponse> LifecycleGetRecordStageWithHttpInfo(string businessObjectDefinitionId,
        string recordId, string lang = null, string locale = null)
    {
        if (businessObjectDefinitionId == null)
            throw new ApiException(400,
                "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetRecordStage");
        if (recordId == null)
            throw new ApiException(400,
                "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetRecordStage");

        var localVarPath = $"/api/V1/{businessObjectDefinitionId}/records/{recordId}/stage";
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

        localVarPathParams.Add("businessObjectDefinitionId",
            Configuration.ApiClient.ParameterToString(businessObjectDefinitionId));
        localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId));
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

        var exception = ExceptionFactory?.Invoke("LifecycleGetRecordStage", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<RecordStatusResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (RecordStatusResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(RecordStatusResponse)));
    }

    #endregion LifecycleGetRecordStage

    #region LifecycleGetRecordStatus

    public RecordStatusResponse LifecycleGetRecordStatus(string businessObjectDefinitionId, string recordId,
        string lang = null, string locale = null)
    {
        return LifecycleGetRecordStatusWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale).Data;
    }

    private ApiResponse<RecordStatusResponse> LifecycleGetRecordStatusWithHttpInfo(
        string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
    {
        if (businessObjectDefinitionId == null)
            throw new ApiException(400,
                "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetRecordStatus");
        if (recordId == null)
            throw new ApiException(400,
                "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetRecordStatus");

        var localVarPath = $"/api/V1/{businessObjectDefinitionId}/records/{recordId}/status";
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

        localVarPathParams.Add("businessObjectDefinitionId",
            Configuration.ApiClient.ParameterToString(businessObjectDefinitionId));
        localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId));
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

        var exception = ExceptionFactory?.Invoke("LifecycleGetRecordStatus", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<RecordStatusResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (RecordStatusResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(RecordStatusResponse)));
    }

    #endregion LifecycleGetRecordStatus

    #region LifecycleGetStages

    public StagesResponse LifecycleGetStages(string businessObjectDefinitionId, string lang = null,
        string locale = null)
    {
        return LifecycleGetStagesWithHttpInfo(businessObjectDefinitionId, lang, locale).Data;
    }

    private ApiResponse<StagesResponse> LifecycleGetStagesWithHttpInfo(string businessObjectDefinitionId,
        string lang = null, string locale = null)
    {
        if (businessObjectDefinitionId == null)
            throw new ApiException(400,
                "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetStages");

        var localVarPath = $"/api/V1/{businessObjectDefinitionId}/lifecycle/stages";
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

        localVarPathParams.Add("businessObjectDefinitionId",
            Configuration.ApiClient.ParameterToString(businessObjectDefinitionId));
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

        var exception = ExceptionFactory?.Invoke("LifecycleGetStages", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<StagesResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (StagesResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(StagesResponse)));
    }

    #endregion LifecycleGetStages

    #region LifecycleGetStatuses

    public StatusesResponse LifecycleGetStatuses(string businessObjectDefinitionId, string lang = null,
        string locale = null)
    {
        return LifecycleGetStatusesWithHttpInfo(businessObjectDefinitionId, lang, locale).Data;
    }

    private ApiResponse<StatusesResponse> LifecycleGetStatusesWithHttpInfo(string businessObjectDefinitionId,
        string lang = null, string locale = null)
    {
        if (businessObjectDefinitionId == null)
            throw new ApiException(400,
                "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetStatuses");

        var localVarPath = $"/api/V1/{businessObjectDefinitionId}/lifecycle/statuses";
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

        localVarPathParams.Add("businessObjectDefinitionId",
            Configuration.ApiClient.ParameterToString(businessObjectDefinitionId));
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

        var exception = ExceptionFactory?.Invoke("LifecycleGetStatuses", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<StatusesResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (StatusesResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(StatusesResponse)));
    }

    #endregion LifecycleGetStatuses

    #region LifecycleGetTransitionOptions

    public TransitionOptionsResponse LifecycleGetTransitionOptions(string businessObjectDefinitionId,
        string recordId, string lang = null, string locale = null)
    {
        return LifecycleGetTransitionOptionsWithHttpInfo(businessObjectDefinitionId, recordId, lang, locale).Data;
    }

    private ApiResponse<TransitionOptionsResponse> LifecycleGetTransitionOptionsWithHttpInfo(
        string businessObjectDefinitionId, string recordId, string lang = null, string locale = null)
    {
        if (businessObjectDefinitionId == null)
            throw new ApiException(400,
                "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetTransitionOptions");
        if (recordId == null)
            throw new ApiException(400,
                "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleGetTransitionOptions");

        var localVarPath = $"/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitionOptions";
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

        localVarPathParams.Add("businessObjectDefinitionId",
            Configuration.ApiClient.ParameterToString(businessObjectDefinitionId));
        localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId));
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

        var exception = ExceptionFactory?.Invoke("LifecycleGetTransitionOptions", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TransitionOptionsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TransitionOptionsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(TransitionOptionsResponse)));
    }

    #endregion LifecycleGetTransitionOptions

    #region LifecycleGetTransitions

    public TransitionsResponse LifecycleGetTransitions(string businessObjectDefinitionId, string lang = null,
        string locale = null)
    {
        return LifecycleGetTransitionsWithHttpInfo(businessObjectDefinitionId, lang, locale).Data;
    }

    private ApiResponse<TransitionsResponse> LifecycleGetTransitionsWithHttpInfo(string businessObjectDefinitionId,
        string lang = null, string locale = null)
    {
        if (businessObjectDefinitionId == null)
            throw new ApiException(400,
                "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleGetTransitions");

        var localVarPath = $"/api/V1/{businessObjectDefinitionId}/lifecycle/transitions";
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

        localVarPathParams.Add("businessObjectDefinitionId",
            Configuration.ApiClient.ParameterToString(businessObjectDefinitionId));
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

        var exception = ExceptionFactory?.Invoke("LifecycleGetTransitions", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TransitionsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TransitionsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(TransitionsResponse)));
    }

    #endregion LifecycleGetTransitions

    #region LifecycleTransitionRecord

    public ResponseBase LifecycleTransitionRecord(string businessObjectDefinitionId, string recordId,
        TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null)
    {
        return LifecycleTransitionRecordWithHttpInfo(businessObjectDefinitionId, recordId, transitionRecordRequest,
            lang, locale).Data;
    }

    private ApiResponse<ResponseBase> LifecycleTransitionRecordWithHttpInfo(string businessObjectDefinitionId,
        string recordId, TransitionRecordRequest transitionRecordRequest, string lang = null, string locale = null)
    {
        if (businessObjectDefinitionId == null)
            throw new ApiException(400,
                "Missing required parameter 'businessObjectDefinitionId' when calling LifecycleApi->LifecycleTransitionRecord");
        if (recordId == null)
            throw new ApiException(400,
                "Missing required parameter 'recordId' when calling LifecycleApi->LifecycleTransitionRecord");
        if (transitionRecordRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'transitionRecordRequest' when calling LifecycleApi->LifecycleTransitionRecord");

        var localVarPath = $"/api/V1/{businessObjectDefinitionId}/records/{recordId}/transitions";
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

        localVarPathParams.Add("businessObjectDefinitionId",
            Configuration.ApiClient.ParameterToString(businessObjectDefinitionId));
        localVarPathParams.Add("recordId", Configuration.ApiClient.ParameterToString(recordId));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (transitionRecordRequest.GetType() != typeof(byte[]))
            localVarPostBody =
                ApiClient.Serialize(transitionRecordRequest);
        else
            localVarPostBody = transitionRecordRequest;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("LifecycleTransitionRecord", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ResponseBase>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ResponseBase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseBase)));
    }

    #endregion LifecycleTransitionRecord
}