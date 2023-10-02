using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class ApprovalApi : BaseApi, IApprovalApi
{
    #region Variables & Properties

    private static ApprovalApi _instance;

    private static readonly object Padlock = new();

    #endregion Variables & Properties

    #region Constructors


    public static ApprovalApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new ApprovalApi();

                _instance = (ApprovalApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    private ApprovalApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructors

    #region ApprovalActionApprovalV1

    public SaveResponse ApprovalActionApprovalV1(string approvalRecId, string approvalAction, string lang = null,
        string locale = null)
    {
        return ApprovalActionApprovalV1WithHttpInfo(approvalRecId, approvalAction, lang, locale).Data;
    }

    private ApiResponse<SaveResponse> ApprovalActionApprovalV1WithHttpInfo(string approvalRecId,
        string approvalAction, string lang = null, string locale = null)
    {
        if (approvalRecId == null)
            throw new ApiException(400,
                "Missing required parameter 'approvalRecId' when calling ApprovalApi->ApprovalActionApprovalV1");
        if (approvalAction == null)
            throw new ApiException(400,
                "Missing required parameter 'approvalAction' when calling ApprovalApi->ApprovalActionApprovalV1");

        var varPath = $"/api/V1/approval/{approvalRecId}/{approvalAction}";
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

        localVarPathParams.Add("approvalRecId",
            Configuration.ApiClient.ParameterToString(approvalRecId));
        localVarPathParams.Add("approvalAction",
            Configuration.ApiClient.ParameterToString(approvalAction));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("ApprovalActionApprovalV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SaveResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SaveResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaveResponse)));
    }

    #endregion ApprovalActionApprovalV1

    #region ApprovalGetApprovalByRecIdV1

    public ApprovalReadResponse ApprovalGetApprovalByRecIdV1(string approvalRecId, string lang = null,
        string locale = null)
    {
        return ApprovalGetApprovalByRecIdV1WithHttpInfo(approvalRecId, lang, locale).Data;
    }

    private ApiResponse<ApprovalReadResponse> ApprovalGetApprovalByRecIdV1WithHttpInfo(string approvalRecId,
        string lang = null, string locale = null)
    {
        if (approvalRecId == null)
            throw new ApiException(400,
                "Missing required parameter 'approvalRecId' when calling ApprovalApi->ApprovalGetApprovalByRecIdV1");

        var varPath = $"/api/V1/approval/{approvalRecId}";
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

        localVarPathParams.Add("approvalRecId",
            Configuration.ApiClient.ParameterToString(approvalRecId));
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

        var exception = ExceptionFactory?.Invoke("ApprovalGetApprovalByRecIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ApprovalReadResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ApprovalReadResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(ApprovalReadResponse)));
    }

    #endregion ApprovalGetApprovalByRecIdV1

    #region ApprovalGetMyApprovalsV1

    public ApprovalsResponse ApprovalGetMyApprovalsV1(string lang = null, string locale = null)
    {
        return ApprovalGetMyApprovalsV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<ApprovalsResponse> ApprovalGetMyApprovalsV1WithHttpInfo(string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/Getmyapprovals";
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

        var exception = ExceptionFactory?.Invoke("ApprovalGetMyApprovalsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ApprovalsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ApprovalsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApprovalsResponse)));
    }

    #endregion ApprovalGetMyApprovalsV1

    #region ApprovalGetMyPendingApprovalsV1

    public ApprovalsResponse ApprovalGetMyPendingApprovalsV1(string lang = null, string locale = null)
    {
        return ApprovalGetMyPendingApprovalsV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<ApprovalsResponse> ApprovalGetMyPendingApprovalsV1WithHttpInfo(string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/Getmypendingapprovals";
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

        var exception = ExceptionFactory?.Invoke("ApprovalGetMyPendingApprovalsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ApprovalsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ApprovalsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApprovalsResponse)));
    }

    #endregion ApprovalGetMyPendingApprovalsV1
}