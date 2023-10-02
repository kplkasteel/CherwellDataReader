using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class BusinessObjectApi : BaseApi, IBusinessObjectApi
{
    #region Variables & Properties

    private static BusinessObjectApi _instance;

    private static readonly object Padlock = new();

    public static BusinessObjectApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new BusinessObjectApi();

                _instance = (BusinessObjectApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Constructors


    private BusinessObjectApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructors

    #region BusinessObjectDeleteBusinessObjectBatchV1

    public BatchDeleteResponse BusinessObjectDeleteBusinessObjectBatchV1(BatchDeleteRequest request,
        string lang = null, string locale = null)
    {
        return BusinessObjectDeleteBusinessObjectBatchV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<BatchDeleteResponse> BusinessObjectDeleteBusinessObjectBatchV1WithHttpInfo(
        BatchDeleteRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectBatchV1");

        const string varPath = "/api/V1/Deletebusinessobjectbatch";
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectDeleteBusinessObjectBatchV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<BatchDeleteResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (BatchDeleteResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(BatchDeleteResponse)));
    }

    #endregion BusinessObjectDeleteBusinessObjectBatchV1

    #region BusinessObjectDeleteBusinessObjectByPublicIdV1

    public DeleteResponse BusinessObjectDeleteBusinessObjectByPublicIdV1(string busobid, string publicid,
        string lang = null, string locale = null)
    {
        return BusinessObjectDeleteBusinessObjectByPublicIdV1WithHttpInfo(busobid, publicid, lang, locale).Data;
    }

    private ApiResponse<DeleteResponse> BusinessObjectDeleteBusinessObjectByPublicIdV1WithHttpInfo(string busobid,
        string publicid, string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectByPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectByPublicIdV1");

        var varPath = $"/api/V1/Deletebusinessobject/busobid/{busobid}/publicid/{publicid}";
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

        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
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
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectDeleteBusinessObjectByPublicIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<DeleteResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (DeleteResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteResponse)));
    }

    #endregion BusinessObjectDeleteBusinessObjectByPublicIdV1

    #region BusinessObjectDeleteBusinessObjectByRecIdV1

    public DeleteResponse BusinessObjectDeleteBusinessObjectByRecIdV1(string busobid, string busobrecid,
        string lang = null, string locale = null)
    {
        return BusinessObjectDeleteBusinessObjectByRecIdV1WithHttpInfo(busobid, busobrecid, lang, locale).Data;
    }

    private ApiResponse<DeleteResponse> BusinessObjectDeleteBusinessObjectByRecIdV1WithHttpInfo(string busobid,
        string busobrecid, string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectByRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectDeleteBusinessObjectByRecIdV1");

        var varPath = $"/api/V1/Deletebusinessobject/busobid/{busobid}/busobrecid/{busobrecid}";
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

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectDeleteBusinessObjectByRecIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<DeleteResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x =>
            {
                Debug.Assert(x.Value != null, "x.Value != null");
                return x.Value.ToString();
            }),
            (DeleteResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(DeleteResponse)));
    }

    #endregion BusinessObjectDeleteBusinessObjectByRecIdV1

    #region BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1

    public SearchesRelatedBusinessObjectResponse BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1(
        string parentbusobid, string parentbusobrecid, string relationshipid, string publicid, string lang = null,
        string locale = null)
    {
        return BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1WithHttpInfo(parentbusobid, parentbusobrecid,
            relationshipid, publicid, lang, locale).Data;
    }

    private ApiResponse<SearchesRelatedBusinessObjectResponse>
        BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1WithHttpInfo(string parentbusobid,
            string parentbusobrecid, string relationshipid, string publicid, string lang = null,
            string locale = null)
    {
        if (parentbusobid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1");
        if (parentbusobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1");
        if (relationshipid == null)
            throw new ApiException(400,
                "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1");

        var localVarPath =
            $"/api/V1/Deleterelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/publicid/{publicid}";
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

        localVarPathParams.Add("parentbusobid",
            Configuration.ApiClient.ParameterToString(parentbusobid));
        localVarPathParams.Add("parentbusobrecid",
            Configuration.ApiClient.ParameterToString(parentbusobrecid));
        localVarPathParams.Add("relationshipid",
            Configuration.ApiClient.ParameterToString(relationshipid));
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
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchesRelatedBusinessObjectResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchesRelatedBusinessObjectResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchesRelatedBusinessObjectResponse)));
    }

    #endregion BusinessObjectDeleteRelatedBusinessObjectByPublicIdV1

    #region BusinessObjectDeleteRelatedBusinessObjectByRecIdV1

    public SearchesRelatedBusinessObjectResponse BusinessObjectDeleteRelatedBusinessObjectByRecIdV1(
        string parentbusobid, string parentbusobrecid, string relationshipid, string busobrecid, string lang = null,
        string locale = null)
    {
        return BusinessObjectDeleteRelatedBusinessObjectByRecIdV1WithHttpInfo(parentbusobid, parentbusobrecid,
            relationshipid, busobrecid, lang, locale).Data;
    }

    private ApiResponse<SearchesRelatedBusinessObjectResponse>
        BusinessObjectDeleteRelatedBusinessObjectByRecIdV1WithHttpInfo(string parentbusobid,
            string parentbusobrecid, string relationshipid, string busobrecid, string lang = null,
            string locale = null)
    {
        if (parentbusobid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByRecIdV1");
        if (parentbusobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByRecIdV1");
        if (relationshipid == null)
            throw new ApiException(400,
                "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectDeleteRelatedBusinessObjectByRecIdV1");

        var varPath =
            $"/api/V1/Deleterelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobrecid/{busobrecid}";
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

        localVarPathParams.Add("parentbusobid",
            Configuration.ApiClient.ParameterToString(parentbusobid));
        localVarPathParams.Add("parentbusobrecid",
            Configuration.ApiClient.ParameterToString(parentbusobrecid));
        localVarPathParams.Add("relationshipid",
            Configuration.ApiClient.ParameterToString(relationshipid));
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

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectDeleteRelatedBusinessObjectByRecIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchesRelatedBusinessObjectResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchesRelatedBusinessObjectResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchesRelatedBusinessObjectResponse)));
    }

    #endregion BusinessObjectDeleteRelatedBusinessObjectByRecIdV1

    #region BusinessObjectFieldValuesLookupV1

    public FieldValuesLookupResponse BusinessObjectFieldValuesLookupV1(FieldValuesLookupRequest request,
        string lang = null, string locale = null)
    {
        return BusinessObjectFieldValuesLookupV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<FieldValuesLookupResponse> BusinessObjectFieldValuesLookupV1WithHttpInfo(
        FieldValuesLookupRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectFieldValuesLookupV1");

        const string varPath = "/api/V1/fieldvalueslookup";
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectFieldValuesLookupV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<FieldValuesLookupResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (FieldValuesLookupResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(FieldValuesLookupResponse)));
    }

    #endregion BusinessObjectFieldValuesLookupV1

    #region BusinessObjectGetActivitiesV1

    public List<BusObActivity> BusinessObjectGetActivitiesV1(string busobid, string busobrecid, int? pageSize,
        int? pageNumber = null, string activityType = null, string lang = null, string locale = null)
    {
        return BusinessObjectGetActivitiesV1WithHttpInfo(busobid, busobrecid, pageSize, pageNumber, activityType,
            lang, locale).Data;
    }

    private ApiResponse<List<BusObActivity>> BusinessObjectGetActivitiesV1WithHttpInfo(string busobid,
        string busobrecid, int? pageSize, int? pageNumber = null, string activityType = null, string lang = null,
        string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetActivitiesV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetActivitiesV1");
        if (pageSize == null)
            throw new ApiException(400,
                "Missing required parameter 'pageSize' when calling BusinessObjectApi->BusinessObjectGetActivitiesV1");

        var varPath = $"/api/V1/Getactivities/busobid/{busobid}/busobrecid/{busobrecid}/pagesize/{pageSize}";
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

        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
        localVarPathParams.Add("busobrecid",
            Configuration.ApiClient.ParameterToString(busobrecid));
        localVarPathParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize));
        if (pageNumber != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pageNumber", pageNumber));
        if (activityType != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "activityType",
                    activityType));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetActivitiesV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<BusObActivity>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<BusObActivity>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<BusObActivity>)));
    }

    #endregion BusinessObjectGetActivitiesV1

    #region BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1

    public byte[] BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1(string attachmentid, string busobid,
        string busobrecid, string lang = null, string locale = null)
    {
        return BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1WithHttpInfo(attachmentid, busobid,
            busobrecid, lang, locale).Data;
    }

    private ApiResponse<byte[]> BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1WithHttpInfo(
        string attachmentid, string busobid, string busobrecid, string lang = null, string locale = null)
    {
        if (attachmentid == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1");

        var varPath =
            $"/api/V1/Getbusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/busobrecid/{busobrecid}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();

        var localVarHttpContentTypes = Array.Empty<string>();
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccepts = new[]
        {
            "application/octet-stream"
        };
        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        localVarPathParams.Add("attachmentid",
            Configuration.ApiClient.ParameterToString(attachmentid));
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

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<byte[]>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (byte[])Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
    }

    #endregion BusinessObjectGetBusinessObjectAttachmentByAttachmentIdV1

    #region BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1

    public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1(string busobid,
        string publicid, string type, string attachmenttype, bool? includelinks = null, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1WithHttpInfo(busobid, publicid, type,
            attachmenttype, includelinks, lang, locale).Data;
    }

    private ApiResponse<AttachmentsResponse>
        BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1WithHttpInfo(string busobid, string publicid,
            string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1");
        if (type == null)
            throw new ApiException(400,
                "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1");
        if (attachmenttype == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmenttype' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1");

        var varPath =
            $"/api/V1/Getbusinessobjectattachments/busobid/{busobid}/publicid/{publicid}/type/{type}/attachmenttype/{attachmenttype}";
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

        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
        localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid));
        localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type));
        localVarPathParams.Add("attachmenttype",
            Configuration.ApiClient.ParameterToString(attachmenttype));
        if (includelinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks",
                    includelinks));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AttachmentsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AttachmentsResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectAttachmentsByIdAndPublicIdV1

    #region BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1

    public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1(string busobid,
        string busobrecid, string type, string attachmenttype, bool? includelinks = null, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1WithHttpInfo(busobid, busobrecid, type,
            attachmenttype, includelinks, lang, locale).Data;
    }

    private ApiResponse<AttachmentsResponse> BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1WithHttpInfo(
        string busobid, string busobrecid, string type, string attachmenttype, bool? includelinks = null,
        string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1");
        if (type == null)
            throw new ApiException(400,
                "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1");
        if (attachmenttype == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmenttype' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1");

        var localVarPath =
            $"/api/V1/Getbusinessobjectattachments/busobid/{busobid}/busobrecid/{busobrecid}/type/{type}/attachmenttype/{attachmenttype}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();

        var localVarHttpContentTypes = new string[]
        {
        };
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
        localVarPathParams.Add("busobrecid",
            Configuration.ApiClient.ParameterToString(busobrecid));
        localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type));
        localVarPathParams.Add("attachmenttype",
            Configuration.ApiClient.ParameterToString(attachmenttype));
        if (includelinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks",
                    includelinks));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AttachmentsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AttachmentsResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectAttachmentsByIdAndRecIdV1

    #region BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1

    public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1(string busobname,
        string publicid, string type, string attachmenttype, bool? includelinks = null, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1WithHttpInfo(busobname, publicid, type,
            attachmenttype, includelinks, lang, locale).Data;
    }

    private ApiResponse<AttachmentsResponse>
        BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1WithHttpInfo(string busobname, string publicid,
            string type, string attachmenttype, bool? includelinks = null, string lang = null, string locale = null)
    {
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1");
        if (type == null)
            throw new ApiException(400,
                "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1");
        if (attachmenttype == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmenttype' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1");

        var localVarPath =
            $"/api/V1/Getbusinessobjectattachments/busobname/{busobname}/publicid/{publicid}/type/{type}/attachmenttype/{attachmenttype}";
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

        localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname));
        localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid));
        localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type));
        localVarPathParams.Add("attachmenttype",
            Configuration.ApiClient.ParameterToString(attachmenttype));
        if (includelinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks",
                    includelinks));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AttachmentsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AttachmentsResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectAttachmentsByNameAndPublicIdV1

    #region BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1

    public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1(string busobname,
        string busobrecid, string type, string attachmenttype, bool? includelinks = null, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1WithHttpInfo(busobname, busobrecid, type,
            attachmenttype, includelinks, lang, locale).Data;
    }

    private ApiResponse<AttachmentsResponse> BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1WithHttpInfo(
        string busobname, string busobrecid, string type, string attachmenttype, bool? includelinks = null,
        string lang = null, string locale = null)
    {
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1");
        if (type == null)
            throw new ApiException(400,
                "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1");
        if (attachmenttype == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmenttype' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1");

        var localVarPath =
            $"/api/V1/Getbusinessobjectattachments/busobname/{busobname}/busobrecid/{busobrecid}/type/{type}/attachmenttype/{attachmenttype}";
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

        localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname));
        localVarPathParams.Add("busobrecid",
            Configuration.ApiClient.ParameterToString(busobrecid));
        localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type));
        localVarPathParams.Add("attachmenttype",
            Configuration.ApiClient.ParameterToString(attachmenttype));
        if (includelinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks",
                    includelinks));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AttachmentsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AttachmentsResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectAttachmentsByNameAndRecIdV1

    #region BusinessObjectGetBusinessObjectAttachmentsV1

    public AttachmentsResponse BusinessObjectGetBusinessObjectAttachmentsV1(AttachmentsRequest attachmentsRequest,
        string lang = null, string locale = null)
    {
        return BusinessObjectGetBusinessObjectAttachmentsV1WithHttpInfo(attachmentsRequest, lang, locale).Data;
    }

    private ApiResponse<AttachmentsResponse> BusinessObjectGetBusinessObjectAttachmentsV1WithHttpInfo(
        AttachmentsRequest attachmentsRequest, string lang = null, string locale = null)
    {
        if (attachmentsRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmentsRequest' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectAttachmentsV1");

        const string varPath = "/api/V1/Getbusinessobjectattachments";
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
        if (attachmentsRequest.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(attachmentsRequest);
        else
            localVarPostBody = attachmentsRequest;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectAttachmentsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AttachmentsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AttachmentsResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectAttachmentsV1

    #region BusinessObjectGetBusinessObjectBatchV1

    public BatchReadResponse BusinessObjectGetBusinessObjectBatchV1(BatchReadRequest request, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectBatchV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<BatchReadResponse> BusinessObjectGetBusinessObjectBatchV1WithHttpInfo(
        BatchReadRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectBatchV1");

        const string varPath = "/api/V1/Getbusinessobjectbatch";
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectBatchV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<BatchReadResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (BatchReadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchReadResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectBatchV1

    #region BusinessObjectGetBusinessObjectByPublicIdV1

    public ReadResponse BusinessObjectGetBusinessObjectByPublicIdV1(string busobid, string publicid,
        string lang = null, string locale = null)
    {
        return BusinessObjectGetBusinessObjectByPublicIdV1WithHttpInfo(busobid, publicid, lang, locale).Data;
    }

    private ApiResponse<ReadResponse> BusinessObjectGetBusinessObjectByPublicIdV1WithHttpInfo(string busobid,
        string publicid, string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByPublicIdV1");

        var localVarPath = $"/api/V1/Getbusinessobject/busobid/{busobid}/publicid/{publicid}";
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

        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByPublicIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ReadResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ReadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectByPublicIdV1

    #region BusinessObjectGetBusinessObjectByRecIdV1

    public ReadResponse BusinessObjectGetBusinessObjectByRecIdV1(string busobid,
        string busobrecid, string lang = null, string locale = null)
    {
        return BusinessObjectGetBusinessObjectByRecIdV1WithHttpInfo(busobid, busobrecid, lang, locale).Data;
    }

    private ApiResponse<ReadResponse> BusinessObjectGetBusinessObjectByRecIdV1WithHttpInfo(string busobid,
        string busobrecid, string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByRecIdV1");

        var localVarPath = $"/api/V1/Getbusinessobject/busobid/{busobid}/busobrecid/{busobrecid}";
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByRecIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ReadResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ReadResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ReadResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectByRecIdV1

    #region BusinessObjectGetBusinessObjectByScanCodeBusObIdV1

    public BarcodeLookupResponse BusinessObjectGetBusinessObjectByScanCodeBusObIdV1(string scanCode, string busobid,
        string lang = null, string locale = null)
    {
        return BusinessObjectGetBusinessObjectByScanCodeBusObIdV1WithHttpInfo(scanCode, busobid, lang, locale).Data;
    }

    private ApiResponse<BarcodeLookupResponse> BusinessObjectGetBusinessObjectByScanCodeBusObIdV1WithHttpInfo(
        string scanCode, string busobid, string lang = null, string locale = null)
    {
        if (scanCode == null)
            throw new ApiException(400,
                "Missing required parameter 'scanCode' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByScanCodeBusObIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByScanCodeBusObIdV1");

        var localVarPath = $"/api/V1/Getbusinessobject/scancode/{scanCode}/busobid/{busobid}";
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

        localVarPathParams.Add("scanCode", Configuration.ApiClient.ParameterToString(scanCode));
        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
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
            ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByScanCodeBusObIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<BarcodeLookupResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (BarcodeLookupResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(BarcodeLookupResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectByScanCodeBusObIdV1

    #region BusinessObjectGetBusinessObjectByScanCodeBusObNameV1

    public BarcodeLookupResponse BusinessObjectGetBusinessObjectByScanCodeBusObNameV1(string scanCode,
        string busobname, string lang = null, string locale = null)
    {
        return BusinessObjectGetBusinessObjectByScanCodeBusObNameV1WithHttpInfo(scanCode, busobname, lang, locale)
            .Data;
    }

    private ApiResponse<BarcodeLookupResponse> BusinessObjectGetBusinessObjectByScanCodeBusObNameV1WithHttpInfo(
        string scanCode, string busobname, string lang = null, string locale = null)
    {
        if (scanCode == null)
            throw new ApiException(400,
                "Missing required parameter 'scanCode' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByScanCodeBusObNameV1");
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectByScanCodeBusObNameV1");

        var localVarPath = $"/api/V1/Getbusinessobject/scancode/{scanCode}/busobname/{busobname}";
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

        localVarPathParams.Add("scanCode", Configuration.ApiClient.ParameterToString(scanCode));
        localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectByScanCodeBusObNameV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<BarcodeLookupResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (BarcodeLookupResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(BarcodeLookupResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectByScanCodeBusObNameV1

    #region BusinessObjectGetBusinessObjectSchemaV1

    public SchemaResponse BusinessObjectGetBusinessObjectSchemaV1(string busobId, bool? includerelationships = null,
        string lang = null, string locale = null)
    {
        return BusinessObjectGetBusinessObjectSchemaV1WithHttpInfo(busobId, includerelationships, lang, locale)
            .Data;
    }

    private ApiResponse<SchemaResponse> BusinessObjectGetBusinessObjectSchemaV1WithHttpInfo(string busobId,
        bool? includerelationships = null, string lang = null, string locale = null)
    {
        if (busobId == null)
            throw new ApiException(400,
                "Missing required parameter 'busobId' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSchemaV1");

        var localVarPath = $"/api/V1/Getbusinessobjectschema/busobid/{busobId}";
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

        localVarPathParams.Add("busobId", Configuration.ApiClient.ParameterToString(busobId));
        if (includerelationships != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includerelationships",
                    includerelationships));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSchemaV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SchemaResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SchemaResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SchemaResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectSchemaV1

    #region BusinessObjectGetBusinessObjectSummariesV1

    public List<Summary> BusinessObjectGetBusinessObjectSummariesV1(string type, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectSummariesV1WithHttpInfo(type, lang, locale).Data;
    }

    private ApiResponse<List<Summary>> BusinessObjectGetBusinessObjectSummariesV1WithHttpInfo(string type,
        string lang = null, string locale = null)
    {
        if (type == null)
            throw new ApiException(400,
                "Missing required parameter 'type' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSummariesV1");

        var localVarPath = $"/api/V1/Getbusinessobjectsummaries/type/{type}";
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

        localVarPathParams.Add("type", Configuration.ApiClient.ParameterToString(type));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSummariesV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<Summary>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<Summary>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Summary>)));
    }

    #endregion BusinessObjectGetBusinessObjectSummariesV1

    #region BusinessObjectGetBusinessObjectSummaryByIdV1

    public List<Summary> BusinessObjectGetBusinessObjectSummaryByIdV1(string busobid, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectSummaryByIdV1WithHttpInfo(busobid, lang, locale).Data;
    }

    private ApiResponse<List<Summary>> BusinessObjectGetBusinessObjectSummaryByIdV1WithHttpInfo(string busobid,
        string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSummaryByIdV1");

        var localVarPath = $"/api/V1/Getbusinessobjectsummary/busobid/{busobid}";
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

        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSummaryByIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<Summary>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<Summary>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Summary>)));
    }

    #endregion BusinessObjectGetBusinessObjectSummaryByIdV1

    #region BusinessObjectGetBusinessObjectSummaryByNameV1

    public List<Summary> BusinessObjectGetBusinessObjectSummaryByNameV1(string busobname, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectSummaryByNameV1WithHttpInfo(busobname, lang, locale).Data;
    }

    private ApiResponse<List<Summary>> BusinessObjectGetBusinessObjectSummaryByNameV1WithHttpInfo(string busobname,
        string lang = null, string locale = null)
    {
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectSummaryByNameV1");

        var localVarPath = $"/api/V1/Getbusinessobjectsummary/busobname/{busobname}";
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

        localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname));
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
            ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectSummaryByNameV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<Summary>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<Summary>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Summary>)));
    }

    #endregion BusinessObjectGetBusinessObjectSummaryByNameV1

    #region BusinessObjectGetBusinessObjectTemplateV1

    public TemplateResponse BusinessObjectGetBusinessObjectTemplateV1(TemplateRequest request, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetBusinessObjectTemplateV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<TemplateResponse> BusinessObjectGetBusinessObjectTemplateV1WithHttpInfo(
        TemplateRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectGetBusinessObjectTemplateV1");

        var localVarPath = "/api/V1/Getbusinessobjecttemplate";
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

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetBusinessObjectTemplateV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<TemplateResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (TemplateResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(TemplateResponse)));
    }

    #endregion BusinessObjectGetBusinessObjectTemplateV1

    #region BusinessObjectGetRelatedBusinessObjectByRequestV1

    public SearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectByRequestV1(
        RelatedBusinessObjectRequest relatedBusinessObjectRequest, bool? includelinks = null, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetRelatedBusinessObjectByRequestV1WithHttpInfo(relatedBusinessObjectRequest,
            includelinks, lang, locale).Data;
    }

    private ApiResponse<SearchesRelatedBusinessObjectResponse>
        BusinessObjectGetRelatedBusinessObjectByRequestV1WithHttpInfo(
            RelatedBusinessObjectRequest relatedBusinessObjectRequest, bool? includelinks = null,
            string lang = null, string locale = null)
    {
        if (relatedBusinessObjectRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'relatedBusinessObjectRequest' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectByRequestV1");

        const string varPath = "/api/V1/Getrelatedbusinessobject";
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

        if (includelinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks",
                    includelinks));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (relatedBusinessObjectRequest.GetType() != typeof(byte[]))
            localVarPostBody =
                ApiClient.Serialize(relatedBusinessObjectRequest);
        else
            localVarPostBody = relatedBusinessObjectRequest;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectGetRelatedBusinessObjectByRequestV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchesRelatedBusinessObjectResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchesRelatedBusinessObjectResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchesRelatedBusinessObjectResponse)));
    }

    #endregion BusinessObjectGetRelatedBusinessObjectByRequestV1

    #region BusinessObjectGetRelatedBusinessObjectV1

    public SearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectV1(string parentbusobid,
        string parentbusobrecid, string relationshipid, int? pageNumber = null, int? pageSize = null,
        bool? allfields = null, bool? usedefaultgrid = null, bool? includelinks = null, string lang = null,
        string locale = null)
    {
        return BusinessObjectGetRelatedBusinessObjectV1WithHttpInfo(parentbusobid, parentbusobrecid, relationshipid,
            pageNumber, pageSize, allfields, usedefaultgrid, includelinks, lang, locale).Data;
    }

    private ApiResponse<SearchesRelatedBusinessObjectResponse> BusinessObjectGetRelatedBusinessObjectV1WithHttpInfo(
        string parentbusobid, string parentbusobrecid, string relationshipid, int? pageNumber = null,
        int? pageSize = null, bool? allfields = null, bool? usedefaultgrid = null, bool? includelinks = null,
        string lang = null, string locale = null)
    {
        if (parentbusobid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectV1");
        if (parentbusobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectV1");
        if (relationshipid == null)
            throw new ApiException(400,
                "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectV1");

        var localVarPath =
            $"/api/V1/Getrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();

        var localVarHttpContentTypes = new string[]
        {
        };
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        localVarPathParams.Add("parentbusobid",
            Configuration.ApiClient.ParameterToString(parentbusobid));
        localVarPathParams.Add("parentbusobrecid",
            Configuration.ApiClient.ParameterToString(parentbusobrecid));
        localVarPathParams.Add("relationshipid",
            Configuration.ApiClient.ParameterToString(relationshipid));
        if (pageNumber != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pageNumber", pageNumber));
        if (pageSize != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize));
        if (allfields != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "allfields", allfields));
        if (usedefaultgrid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "usedefaultgrid",
                    usedefaultgrid));
        if (includelinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks",
                    includelinks));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetRelatedBusinessObjectV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchesRelatedBusinessObjectResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchesRelatedBusinessObjectResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchesRelatedBusinessObjectResponse)));
    }

    #endregion BusinessObjectGetRelatedBusinessObjectV1

    #region BusinessObjectGetRelatedBusinessObjectWithCustomGridV1

    public SearchesRelatedBusinessObjectResponse BusinessObjectGetRelatedBusinessObjectWithCustomGridV1(
        string parentbusobid, string parentbusobrecid, string relationshipid, string gridid, int? pageNumber = null,
        int? pageSize = null, bool? includelinks = null, string lang = null, string locale = null)
    {
        return BusinessObjectGetRelatedBusinessObjectWithCustomGridV1WithHttpInfo(parentbusobid, parentbusobrecid,
            relationshipid, gridid, pageNumber, pageSize, includelinks, lang, locale).Data;
    }

    private ApiResponse<SearchesRelatedBusinessObjectResponse>
        BusinessObjectGetRelatedBusinessObjectWithCustomGridV1WithHttpInfo(string parentbusobid,
            string parentbusobrecid, string relationshipid, string gridid, int? pageNumber = null,
            int? pageSize = null, bool? includelinks = null, string lang = null, string locale = null)
    {
        if (parentbusobid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectWithCustomGridV1");
        if (parentbusobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectWithCustomGridV1");
        if (relationshipid == null)
            throw new ApiException(400,
                "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectWithCustomGridV1");
        if (gridid == null)
            throw new ApiException(400,
                "Missing required parameter 'gridid' when calling BusinessObjectApi->BusinessObjectGetRelatedBusinessObjectWithCustomGridV1");

        var localVarPath =
            $"/api/V1/Getrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/gridid/{gridid}";
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

        localVarPathParams.Add("parentbusobid",
            Configuration.ApiClient.ParameterToString(parentbusobid));
        localVarPathParams.Add("parentbusobrecid",
            Configuration.ApiClient.ParameterToString(parentbusobrecid));
        localVarPathParams.Add("relationshipid",
            Configuration.ApiClient.ParameterToString(relationshipid));
        localVarPathParams.Add("gridid", Configuration.ApiClient.ParameterToString(gridid));
        if (pageNumber != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pageNumber", pageNumber));
        if (pageSize != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pageSize", pageSize));
        if (includelinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includelinks",
                    includelinks));
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectGetRelatedBusinessObjectWithCustomGridV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchesRelatedBusinessObjectResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchesRelatedBusinessObjectResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchesRelatedBusinessObjectResponse)));
    }

    #endregion BusinessObjectGetRelatedBusinessObjectWithCustomGridV1

    #region BusinessObjectLinkRelatedBusinessObjectByRecIdV1

    public SearchesRelatedBusinessObjectResponse BusinessObjectLinkRelatedBusinessObjectByRecIdV1(
        string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid,
        string lang = null, string locale = null)
    {
        return BusinessObjectLinkRelatedBusinessObjectByRecIdV1WithHttpInfo(parentbusobid, parentbusobrecid,
            relationshipid, busobid, busobrecid, lang, locale).Data;
    }

    private ApiResponse<SearchesRelatedBusinessObjectResponse>
        BusinessObjectLinkRelatedBusinessObjectByRecIdV1WithHttpInfo(string parentbusobid, string parentbusobrecid,
            string relationshipid, string busobid, string busobrecid, string lang = null, string locale = null)
    {
        if (parentbusobid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");
        if (parentbusobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");
        if (relationshipid == null)
            throw new ApiException(400,
                "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV1");

        var localVarPath =
            $"/api/V1/linkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}";
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

        localVarPathParams.Add("parentbusobid",
            Configuration.ApiClient.ParameterToString(parentbusobid));
        localVarPathParams.Add("parentbusobrecid",
            Configuration.ApiClient.ParameterToString(parentbusobrecid));
        localVarPathParams.Add("relationshipid",
            Configuration.ApiClient.ParameterToString(relationshipid));
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

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectLinkRelatedBusinessObjectByRecIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchesRelatedBusinessObjectResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchesRelatedBusinessObjectResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchesRelatedBusinessObjectResponse)));
    }

    #endregion BusinessObjectLinkRelatedBusinessObjectByRecIdV1

    #region BusinessObjectLinkRelatedBusinessObjectByRecIdV2

    public ResponseBase BusinessObjectLinkRelatedBusinessObjectByRecIdV2(string parentbusobid,
        string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null,
        string locale = null)
    {
        return BusinessObjectLinkRelatedBusinessObjectByRecIdV2WithHttpInfo(parentbusobid, parentbusobrecid,
            relationshipid, busobid, busobrecid, lang, locale).Data;
    }

    private ApiResponse<ResponseBase> BusinessObjectLinkRelatedBusinessObjectByRecIdV2WithHttpInfo(
        string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid,
        string lang = null, string locale = null)
    {
        if (parentbusobid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");
        if (parentbusobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");
        if (relationshipid == null)
            throw new ApiException(400,
                "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectLinkRelatedBusinessObjectByRecIdV2");

        var localVarPath =
            $"/api/V2/linkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}";
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

        localVarPathParams.Add("parentbusobid",
            Configuration.ApiClient.ParameterToString(parentbusobid));
        localVarPathParams.Add("parentbusobrecid",
            Configuration.ApiClient.ParameterToString(parentbusobrecid));
        localVarPathParams.Add("relationshipid",
            Configuration.ApiClient.ParameterToString(relationshipid));
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

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectLinkRelatedBusinessObjectByRecIdV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ResponseBase>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ResponseBase)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ResponseBase)));
    }

    #endregion BusinessObjectLinkRelatedBusinessObjectByRecIdV2

    #region BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1

    public object BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1(string attachmentid, string busobid,
        string publicid, string lang = null, string locale = null)
    {
        return BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1WithHttpInfo(attachmentid, busobid,
            publicid, lang, locale);
    }

    private ApiResponse<object> BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1WithHttpInfo(
        string attachmentid, string busobid, string publicid, string lang = null, string locale = null)
    {
        if (attachmentid == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1");

        var localVarPath =
            $"/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/publicid/{publicid}";
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

        localVarPathParams.Add("attachmentid",
            Configuration.ApiClient.ParameterToString(attachmentid));
        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
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
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion BusinessObjectRemoveBusinessObjectAttachmentByIdAndPublicIdV1

    #region BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1

    public object BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1(string attachmentid, string busobid,
        string busobrecid, string lang = null, string locale = null)
    {
        return BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1WithHttpInfo(attachmentid, busobid,
            busobrecid, lang, locale);
    }

    private ApiResponse<object> BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1WithHttpInfo(
        string attachmentid, string busobid, string busobrecid, string lang = null, string locale = null)
    {
        if (attachmentid == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1");

        var localVarPath =
            $"/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobid/{busobid}/busobrecid/{busobrecid}";
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

        localVarPathParams.Add("attachmentid",
            Configuration.ApiClient.ParameterToString(attachmentid));
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
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion BusinessObjectRemoveBusinessObjectAttachmentByIdAndRecIdV1

    #region BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1

    public object BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1(string attachmentid,
        string busobname, string publicid, string lang = null, string locale = null)
    {
        return BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1WithHttpInfo(attachmentid, busobname,
            publicid, lang, locale);
    }

    private ApiResponse<object> BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1WithHttpInfo(
        string attachmentid,
        string busobname, string publicid, string lang = null, string locale = null)
    {
        if (attachmentid == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1");
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1");

        var localVarPath =
            $"/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobname/{busobname}/publicid/{publicid}";
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

        if (true)
            localVarPathParams.Add("attachmentid",
                Configuration.ApiClient.ParameterToString(attachmentid));
        localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname));
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
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion BusinessObjectRemoveBusinessObjectAttachmentByNameAndPublicIdV1

    #region BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1

    public object BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1(string attachmentid,
        string busobname, string busobrecid, string lang = null, string locale = null)
    {
        return BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1WithHttpInfo(attachmentid, busobname,
            busobrecid, lang, locale);
    }

    private ApiResponse<object> BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1WithHttpInfo(
        string attachmentid, string busobname, string busobrecid, string lang = null, string locale = null)
    {
        if (attachmentid == null)
            throw new ApiException(400,
                "Missing required parameter 'attachmentid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1");
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1");

        var localVarPath =
            $"/api/V1/removebusinessobjectattachment/attachmentid/{attachmentid}/busobname/{busobname}/busobrecid/{busobrecid}";
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

        localVarPathParams.Add("attachmentid",
            Configuration.ApiClient.ParameterToString(attachmentid));
        localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname));
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
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion BusinessObjectRemoveBusinessObjectAttachmentByNameAndRecIdV1

    #region BusinessObjectSaveBusinessObjectAttachmentBusObV1

    public AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentBusObV1(SaveBusObAttachmentRequest request,
        string lang = null, string locale = null)
    {
        return BusinessObjectSaveBusinessObjectAttachmentBusObV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<AttachmentsResponse> BusinessObjectSaveBusinessObjectAttachmentBusObV1WithHttpInfo(
        SaveBusObAttachmentRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectAttachmentBusObV1");

        var localVarPath = "/api/V1/savebusinessobjectattachmentbusob";
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

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectAttachmentBusObV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AttachmentsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AttachmentsResponse)));
    }

    #endregion BusinessObjectSaveBusinessObjectAttachmentBusObV1

    #region BusinessObjectSaveBusinessObjectAttachmentLinkV1

    public AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentLinkV1(SaveLinkAttachmentRequest request,
        string lang = null, string locale = null)
    {
        return BusinessObjectSaveBusinessObjectAttachmentLinkV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<AttachmentsResponse> BusinessObjectSaveBusinessObjectAttachmentLinkV1WithHttpInfo(
        SaveLinkAttachmentRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectAttachmentLinkV1");

        const string varPath = "/api/V1/savebusinessobjectattachmentlink";
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectAttachmentLinkV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AttachmentsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AttachmentsResponse)));
    }

    #endregion BusinessObjectSaveBusinessObjectAttachmentLinkV1

    #region BusinessObjectSaveBusinessObjectAttachmentUrlV1

    public AttachmentsResponse BusinessObjectSaveBusinessObjectAttachmentUrlV1(SaveUrlAttachmentRequest request,
        string lang = null, string locale = null)
    {
        return BusinessObjectSaveBusinessObjectAttachmentUrlV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<AttachmentsResponse> BusinessObjectSaveBusinessObjectAttachmentUrlV1WithHttpInfo(
        SaveUrlAttachmentRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectAttachmentUrlV1");

        const string varPath = "/api/V1/savebusinessobjectattachmenturl";
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
            Method.Put, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectAttachmentUrlV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (AttachmentsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(AttachmentsResponse)));
    }

    #endregion BusinessObjectSaveBusinessObjectAttachmentUrlV1

    #region BusinessObjectSaveBusinessObjectV1

    public SaveResponse BusinessObjectSaveBusinessObjectV1(SaveRequest request, string lang = null,
        string locale = null)
    {
        var localVarResponse = BusinessObjectSaveBusinessObjectV1WithHttpInfo(request, lang, locale);
        return localVarResponse.Data;
    }

    private ApiResponse<SaveResponse> BusinessObjectSaveBusinessObjectV1WithHttpInfo(SaveRequest request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectV1");

        const string varPath = "/api/V1/savebusinessobject";
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SaveResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SaveResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SaveResponse)));
    }

    #endregion BusinessObjectSaveBusinessObjectV1

    #region BusinessObjectSaveRelatedBusinessObjectV1

    public RelatedSaveResponse BusinessObjectSaveRelatedBusinessObjectV1(RelatedSaveRequest request,
        string lang = null, string locale = null)
    {
        return BusinessObjectSaveRelatedBusinessObjectV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<RelatedSaveResponse> BusinessObjectSaveRelatedBusinessObjectV1WithHttpInfo(
        RelatedSaveRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveRelatedBusinessObjectV1");

        var localVarPath = "/api/V1/saverelatedbusinessobject";
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

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectSaveRelatedBusinessObjectV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<RelatedSaveResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (RelatedSaveResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(RelatedSaveResponse)));
    }

    #endregion BusinessObjectSaveRelatedBusinessObjectV1

    #region BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1

    public SearchesRelatedBusinessObjectResponse BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1(
        string parentbusobid, string parentbusobrecid, string relationshipid, string busobid, string busobrecid,
        string lang = null, string locale = null)
    {
        return BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1WithHttpInfo(parentbusobid, parentbusobrecid,
            relationshipid, busobid, busobrecid, lang, locale).Data;
    }

    private ApiResponse<SearchesRelatedBusinessObjectResponse>
        BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1WithHttpInfo(string parentbusobid,
            string parentbusobrecid, string relationshipid, string busobid, string busobrecid, string lang = null,
            string locale = null)
    {
        if (parentbusobid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");
        if (parentbusobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'parentbusobrecid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");
        if (relationshipid == null)
            throw new ApiException(400,
                "Missing required parameter 'relationshipid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1");

        var localVarPath =
            $"/api/V1/unlinkrelatedbusinessobject/parentbusobid/{parentbusobid}/parentbusobrecid/{parentbusobrecid}/relationshipid/{relationshipid}/busobid/{busobid}/busobrecid/{busobrecid}";
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

        localVarPathParams.Add("parentbusobid",
            Configuration.ApiClient.ParameterToString(parentbusobid));
        localVarPathParams.Add("parentbusobrecid",
            Configuration.ApiClient.ParameterToString(parentbusobrecid));
        localVarPathParams.Add("relationshipid",
            Configuration.ApiClient.ParameterToString(relationshipid));
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
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception =
            ExceptionFactory?.Invoke("BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchesRelatedBusinessObjectResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchesRelatedBusinessObjectResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchesRelatedBusinessObjectResponse)));
    }

    #endregion BusinessObjectUnLinkRelatedBusinessObjectByRecIdV1

    #region BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1

    public string BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1(byte[] body, string filename,
        string busobid, string publicid, int? offset, int? totalsize, string attachmentid = null,
        string displaytext = null, string lang = null, string locale = null)
    {
        var localVarResponse = BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1WithHttpInfo(body,
            filename, busobid, publicid, offset, totalsize, attachmentid, displaytext, lang, locale);
        return localVarResponse.Data;
    }

    private ApiResponse<string> BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1WithHttpInfo(
        byte[] body, string filename, string busobid, string publicid, int? offset, int? totalsize,
        string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
    {
        if (body == null)
            throw new ApiException(400,
                "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
        if (filename == null)
            throw new ApiException(400,
                "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
        if (offset == null)
            throw new ApiException(400,
                "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");
        if (totalsize == null)
            throw new ApiException(400,
                "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1");

        var localVarPath =
            $"/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/publicid/{publicid}/offset/{offset}/totalsize/{totalsize}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentTypes = new[]
        {
            "application/octet-stream"
        };
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename));
        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
        localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid));
        localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset));
        localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize));
        if (attachmentid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid",
                    attachmentid));
        if (displaytext != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext",
                    displaytext));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (body.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(body);
        else
            localVarPostBody = body;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<string>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
    }

    #endregion BusinessObjectUploadBusinessObjectAttachmentByIdAndPublicIdV1

    #region BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1

    public string BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1(byte[] body, string filename,
        string busobid, string busobrecid, int? offset, int? totalsize, string attachmentid = null,
        string displaytext = null, string lang = null, string locale = null)
    {
        return BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1WithHttpInfo(body, filename, busobid,
            busobrecid, offset, totalsize, attachmentid, displaytext, lang, locale).Data;
    }

    private ApiResponse<string> BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1WithHttpInfo(byte[] body,
        string filename, string busobid, string busobrecid, int? offset, int? totalsize, string attachmentid = null,
        string displaytext = null, string lang = null, string locale = null)
    {
        if (body == null)
            throw new ApiException(400,
                "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
        if (filename == null)
            throw new ApiException(400,
                "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
        if (offset == null)
            throw new ApiException(400,
                "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");
        if (totalsize == null)
            throw new ApiException(400,
                "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1");

        var localVarPath =
            $"/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobid/{busobid}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentTypes = new[]
        {
            "application/octet-stream"
        };
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename));
        localVarPathParams.Add("busobid", Configuration.ApiClient.ParameterToString(busobid));
        localVarPathParams.Add("busobrecid",
            Configuration.ApiClient.ParameterToString(busobrecid));
        localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset));
        localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize));
        if (attachmentid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid",
                    attachmentid));
        if (displaytext != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext",
                    displaytext));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (body.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(body);
        else
            localVarPostBody = body;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<string>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
    }

    #endregion BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1

    #region BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1

    public string BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1(byte[] body, string filename,
        string busobname, string publicid, int? offset, int? totalsize, string attachmentid = null,
        string displaytext = null, string lang = null, string locale = null)
    {
        return BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1WithHttpInfo(body, filename,
            busobname, publicid, offset, totalsize, attachmentid, displaytext, lang, locale).Data;
    }

    private ApiResponse<string> BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1WithHttpInfo(
        byte[] body, string filename, string busobname, string publicid, int? offset, int? totalsize,
        string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
    {
        if (body == null)
            throw new ApiException(400,
                "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
        if (filename == null)
            throw new ApiException(400,
                "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
        if (offset == null)
            throw new ApiException(400,
                "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");
        if (totalsize == null)
            throw new ApiException(400,
                "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1");

        var localVarPath =
            "/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobname/{busobname}/publicid/{publicid}/offset/{offset}/totalsize/{totalsize}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentTypes = new[]
        {
            "application/octet-stream"
        };
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename));
        localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname));
        localVarPathParams.Add("publicid", Configuration.ApiClient.ParameterToString(publicid));
        localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset));
        localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize));
        if (attachmentid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid",
                    attachmentid));
        if (displaytext != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext",
                    displaytext));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (body.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(body);
        else
            localVarPostBody = body;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<string>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
    }

    #endregion BusinessObjectUploadBusinessObjectAttachmentByNameAndPublicIdV1

    #region BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1

    public string BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1(byte[] body, string filename,
        string busobname, string busobrecid, int? offset, int? totalsize, string attachmentid = null,
        string displaytext = null, string lang = null, string locale = null)
    {
        return BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1WithHttpInfo(body, filename, busobname,
            busobrecid, offset, totalsize, attachmentid, displaytext, lang, locale).Data;
    }

    private ApiResponse<string> BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1WithHttpInfo(
        byte[] body, string filename, string busobname, string busobrecid, int? offset, int? totalsize,
        string attachmentid = null, string displaytext = null, string lang = null, string locale = null)
    {
        if (body == null)
            throw new ApiException(400,
                "Missing required parameter 'body' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
        if (filename == null)
            throw new ApiException(400,
                "Missing required parameter 'filename' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
        if (offset == null)
            throw new ApiException(400,
                "Missing required parameter 'offset' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");
        if (totalsize == null)
            throw new ApiException(400,
                "Missing required parameter 'totalsize' when calling BusinessObjectApi->BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1");

        var localVarPath =
            "/api/V1/uploadbusinessobjectattachment/filename/{filename}/busobname/{busobname}/busobrecid/{busobrecid}/offset/{offset}/totalsize/{totalsize}";
        var localVarPathParams = new Dictionary<string, string>();
        var localVarQueryParams = new List<KeyValuePair<string, string>>();
        var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
        var localVarFormParams = new Dictionary<string, string>();
        var localVarFileParams = new Dictionary<string, FileParameter>();
        object localVarPostBody;

        var localVarHttpContentTypes = new[]
        {
            "application/octet-stream"
        };
        var localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

        var localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(LocalVarHttpHeaderAccepts);
        if (localVarHttpHeaderAccept != null)
            localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

        localVarPathParams.Add("filename", Configuration.ApiClient.ParameterToString(filename));
        localVarPathParams.Add("busobname", Configuration.ApiClient.ParameterToString(busobname));
        localVarPathParams.Add("busobrecid",
            Configuration.ApiClient.ParameterToString(busobrecid));
        localVarPathParams.Add("offset", Configuration.ApiClient.ParameterToString(offset));
        localVarPathParams.Add("totalsize", Configuration.ApiClient.ParameterToString(totalsize));
        if (attachmentid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "attachmentid",
                    attachmentid));
        if (displaytext != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "displaytext",
                    displaytext));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));
        if (body.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(body);
        else
            localVarPostBody = body;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<string>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
    }

    #endregion BusinessObjectUploadBusinessObjectAttachmentByNameAndRecIdV1

    #region BusinessObjectSaveBusinessObjectBatchV1

    public BatchSaveResponse BusinessObjectSaveBusinessObjectBatchV1(
        BatchSaveRequest request, string lang = null, string locale = null)
    {
        return BusinessObjectSaveBusinessObjectBatchV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<BatchSaveResponse> BusinessObjectSaveBusinessObjectBatchV1WithHttpInfo(
        BatchSaveRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling BusinessObjectApi->BusinessObjectSaveBusinessObjectBatchV1");

        const string varPath = "/api/V1/savebusinessobjectbatch";
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

        var exception = ExceptionFactory?.Invoke("BusinessObjectSaveBusinessObjectBatchV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<BatchSaveResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (BatchSaveResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(BatchSaveResponse)));
    }

    #endregion BusinessObjectSaveBusinessObjectBatchV1
}