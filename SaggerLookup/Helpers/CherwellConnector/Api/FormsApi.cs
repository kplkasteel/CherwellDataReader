using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class FormsApi : BaseApi, IFormsApi
{
    #region Variables & Properties

    private static FormsApi _instance;

    private static readonly object Padlock = new();

    public static FormsApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new FormsApi();

                _instance = (FormsApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Constructors

    private FormsApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructors

    #region FormsGetMobileFormForBusObByIdAndPublicIdV1

    public MobileFormResponse FormsGetMobileFormForBusObByIdAndPublicIdV1(string busobid, string publicid,
        bool? foredit = null, string formid = null, string lang = null, string locale = null)
    {
        return FormsGetMobileFormForBusObByIdAndPublicIdV1WithHttpInfo(busobid, publicid, foredit, formid, lang,
            locale).Data;
    }

    private ApiResponse<MobileFormResponse> FormsGetMobileFormForBusObByIdAndPublicIdV1WithHttpInfo(string busobid,
        string publicid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndPublicIdV1");

        var localVarPath = $"/api/V1/Getmobileformforbusob/busobid/{busobid}/publicid/{publicid}";
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
        if (foredit != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit));
        if (formid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid));
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

        var exception = ExceptionFactory?.Invoke("FormsGetMobileFormForBusObByIdAndPublicIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<MobileFormResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (MobileFormResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
    }

    #endregion FormsGetMobileFormForBusObByIdAndPublicIdV1

    #region FormsGetMobileFormForBusObByIdAndRecIdV1

    public MobileFormResponse FormsGetMobileFormForBusObByIdAndRecIdV1(string busobid, string busobrecid,
        bool? foredit = null, string formid = null, string lang = null, string locale = null)
    {
        return FormsGetMobileFormForBusObByIdAndRecIdV1WithHttpInfo(busobid, busobrecid, foredit, formid, lang,
            locale).Data;
    }

    private ApiResponse<MobileFormResponse> FormsGetMobileFormForBusObByIdAndRecIdV1WithHttpInfo(string busobid,
        string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
    {
        if (busobid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling FormsApi->FormsGetMobileFormForBusObByIdAndRecIdV1");

        var localVarPath = $"/api/V1/Getmobileformforbusob/busobid/{busobid}/busobrecid/{busobrecid}";
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
        if (foredit != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit));
        if (formid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid));
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

        var exception = ExceptionFactory?.Invoke("FormsGetMobileFormForBusObByIdAndRecIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<MobileFormResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (MobileFormResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
    }

    #endregion FormsGetMobileFormForBusObByIdAndRecIdV1

    #region FormsGetMobileFormForBusObByNameAndPublicIdV1

    public MobileFormResponse FormsGetMobileFormForBusObByNameAndPublicIdV1(string busobname, string publicid,
        bool? foredit = null, string formid = null, string lang = null, string locale = null)
    {
        return FormsGetMobileFormForBusObByNameAndPublicIdV1WithHttpInfo(busobname, publicid, foredit, formid, lang,
            locale).Data;
    }

    private ApiResponse<MobileFormResponse> FormsGetMobileFormForBusObByNameAndPublicIdV1WithHttpInfo(
        string busobname, string publicid, bool? foredit = null, string formid = null, string lang = null,
        string locale = null)
    {
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling FormsApi->FormsGetMobileFormForBusObByNameAndPublicIdV1");
        if (publicid == null)
            throw new ApiException(400,
                "Missing required parameter 'publicid' when calling FormsApi->FormsGetMobileFormForBusObByNameAndPublicIdV1");

        var localVarPath = $"/api/V1/Getmobileformforbusob/busobname/{busobname}/publicid/{publicid}";
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
        if (foredit != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit));
        if (formid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid));
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

        var exception = ExceptionFactory?.Invoke("FormsGetMobileFormForBusObByNameAndPublicIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<MobileFormResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (MobileFormResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
    }

    #endregion FormsGetMobileFormForBusObByNameAndPublicIdV1

    #region FormsGetMobileFormForBusObByNameAndRecIdV1

    public MobileFormResponse FormsGetMobileFormForBusObByNameAndRecIdV1(string busobname, string busobrecid,
        bool? foredit = null, string formid = null, string lang = null, string locale = null)
    {
        return FormsGetMobileFormForBusObByNameAndRecIdV1WithHttpInfo(busobname, busobrecid, foredit, formid, lang,
            locale).Data;
    }

    private ApiResponse<MobileFormResponse> FormsGetMobileFormForBusObByNameAndRecIdV1WithHttpInfo(string busobname,
        string busobrecid, bool? foredit = null, string formid = null, string lang = null, string locale = null)
    {
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling FormsApi->FormsGetMobileFormForBusObByNameAndRecIdV1");
        if (busobrecid == null)
            throw new ApiException(400,
                "Missing required parameter 'busobrecid' when calling FormsApi->FormsGetMobileFormForBusObByNameAndRecIdV1");

        var localVarPath = $"/api/V1/Getmobileformforbusob/busobname/{busobname}/busobrecid/{busobrecid}";
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
        if (foredit != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "foredit", foredit));
        if (formid != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "formid", formid));
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

        var exception = ExceptionFactory?.Invoke("FormsGetMobileFormForBusObByNameAndRecIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<MobileFormResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (MobileFormResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(MobileFormResponse)));
    }

    #endregion FormsGetMobileFormForBusObByNameAndRecIdV1
}