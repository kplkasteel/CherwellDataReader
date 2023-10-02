using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class SecurityApi : BaseApi, ISecurityApi
{
    #region Variables & Properties

    private static SecurityApi _instance;

    private static readonly object Padlock = new();

    public static SecurityApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new SecurityApi();

                _instance = (SecurityApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Constructors

    private SecurityApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructors

    #region SecurityGetClientSecuritySettingsV1

    public ClientSecuritySettingsResponse SecurityGetClientSecuritySettingsV1(string applicationtype,
        string lang = null, string locale = null)
    {
        return SecurityGetClientSecuritySettingsV1WithHttpInfo(applicationtype, lang, locale).Data;
    }

    private ApiResponse<ClientSecuritySettingsResponse> SecurityGetClientSecuritySettingsV1WithHttpInfo(
        string applicationtype, string lang = null, string locale = null)
    {
        if (applicationtype == null)
            throw new ApiException(400,
                "Missing required parameter 'applicationtype' when calling SecurityApi->SecurityGetClientSecuritySettingsV1");

        var localVarPath = $"/api/V1/Getclientsecuritysettings/applicationtype/{applicationtype}";
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

        localVarPathParams.Add("applicationtype",
            Configuration.ApiClient.ParameterToString(applicationtype));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("SecurityGetClientSecuritySettingsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ClientSecuritySettingsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ClientSecuritySettingsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(ClientSecuritySettingsResponse)));
    }

    #endregion SecurityGetClientSecuritySettingsV1

    #region SecurityGetRolesV1

    public SecurityRoleReadResponse SecurityGetRolesV1(string lang = null, string locale = null)
    {
        return SecurityGetRolesV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<SecurityRoleReadResponse> SecurityGetRolesV1WithHttpInfo(string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/Getroles";
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

        var exception = ExceptionFactory?.Invoke("SecurityGetRolesV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityRoleReadResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityRoleReadResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityRoleReadResponse)));
    }

    #endregion SecurityGetRolesV1

    #region SecurityGetRolesV2

    public RoleReadV2Response SecurityGetRolesV2(string lang = null, string locale = null)
    {
        return SecurityGetRolesV2WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<RoleReadV2Response> SecurityGetRolesV2WithHttpInfo(string lang = null, string locale = null)
    {
        const string varPath = "/api/V2/Getroles";
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

        var exception = ExceptionFactory?.Invoke("SecurityGetRolesV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<RoleReadV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (RoleReadV2Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(RoleReadV2Response)));
    }

    #endregion SecurityGetRolesV2

    #region SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1

    public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1(
        string groupid, string busObId, string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1WithHttpInfo(groupid, busObId, lang,
            locale).Data;
    }

    private ApiResponse<List<BusinessObjectPermission>>
        SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1WithHttpInfo(string groupid, string busObId,
            string lang = null, string locale = null)
    {
        if (groupid == null)
            throw new ApiException(400,
                "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1");
        if (busObId == null)
            throw new ApiException(400,
                "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1");

        var localVarPath = $"/api/V1/Getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}";
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

        localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid));
        localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<BusinessObjectPermission>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<BusinessObjectPermission>)));
    }

    #endregion SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV1

    #region SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2

    public SecurityGroupBusinessObjectPermissionsResponse
        SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2(string groupid, string busObId,
            string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2WithHttpInfo(groupid, busObId, lang,
            locale).Data;
    }

    private ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>
        SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2WithHttpInfo(string groupid, string busObId,
            string lang = null, string locale = null)
    {
        if (groupid == null)
            throw new ApiException(400,
                "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2");
        if (busObId == null)
            throw new ApiException(400,
                "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2");

        var localVarPath = $"/api/V2/Getsecuritygroupbusinessobjectpermissions/groupid/{groupid}/busobid/{busObId}";
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

        localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid));
        localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityGroupBusinessObjectPermissionsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityGroupBusinessObjectPermissionsResponse)));
    }

    #endregion SecurityGetSecurityGroupBusinessObjectPermissionsByBusObIdV2

    #region SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1

    public List<BusinessObjectPermission> SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1(
        string groupname, string busobname, string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1WithHttpInfo(groupname, busobname,
            lang, locale).Data;
    }

    private ApiResponse<List<BusinessObjectPermission>>
        SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1WithHttpInfo(string groupname,
            string busobname, string lang = null, string locale = null)
    {
        if (groupname == null)
            throw new ApiException(400,
                "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1");
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1");

        var localVarPath =
            $"/api/V1/Getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}";
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

        localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<BusinessObjectPermission>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<BusinessObjectPermission>)));
    }

    #endregion SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV1

    #region SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2

    public SecurityGroupBusinessObjectPermissionsResponse
        SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2(string groupname, string busobname,
            string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2WithHttpInfo(groupname, busobname,
            lang, locale).Data;
    }

    private ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>
        SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2WithHttpInfo(string groupname,
            string busobname, string lang = null, string locale = null)
    {
        if (groupname == null)
            throw new ApiException(400,
                "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2");
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2");

        var localVarPath =
            $"/api/V2/Getsecuritygroupbusinessobjectpermissions/groupname/{groupname}/busobname/{busobname}";
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

        localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityGroupBusinessObjectPermissionsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityGroupBusinessObjectPermissionsResponse)));
    }

    #endregion SecurityGetSecurityGroupBusinessObjectPermissionsByBusObNameV2

    #region SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1

    public List<BusinessObjectPermission>
        SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1(string busObId,
            string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1WithHttpInfo(busObId, lang,
            locale).Data;
    }

    private ApiResponse<List<BusinessObjectPermission>>
        SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1WithHttpInfo(string busObId,
            string lang = null, string locale = null)
    {
        if (busObId == null)
            throw new ApiException(400,
                "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1");

        var localVarPath =
            $"/api/V1/Getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}";
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

        localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId));
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

        var exception = ExceptionFactory?.Invoke(
            "SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<BusinessObjectPermission>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<BusinessObjectPermission>)));
    }

    #endregion SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV1

    #region SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2

    public SecurityGroupBusinessObjectPermissionsResponse
        SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2(string busObId,
            string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2WithHttpInfo(busObId, lang,
            locale).Data;
    }

    private ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>
        SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2WithHttpInfo(string busObId,
            string lang = null, string locale = null)
    {
        if (busObId == null)
            throw new ApiException(400,
                "Missing required parameter 'busObId' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2");

        var localVarPath =
            $"/api/V2/Getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobid/busobid/{busObId}";
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

        localVarPathParams.Add("busObId", Configuration.ApiClient.ParameterToString(busObId));
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

        var exception = ExceptionFactory?.Invoke(
            "SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityGroupBusinessObjectPermissionsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityGroupBusinessObjectPermissionsResponse)));
    }

    public List<BusinessObjectPermission>
        SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1(string busobname,
            string lang = null, string locale = null)
    {
        var localVarResponse =
            SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1WithHttpInfo(busobname,
                lang, locale);
        return localVarResponse.Data;
    }

    public ApiResponse<List<BusinessObjectPermission>>
        SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1WithHttpInfo(string busobname,
            string lang = null, string locale = null)
    {
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1");

        var localVarPath =
            "/api/V1/Getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}";
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

        var exception = ExceptionFactory?.Invoke(
            "SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<BusinessObjectPermission>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<BusinessObjectPermission>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<BusinessObjectPermission>)));
    }

    #endregion SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObIdV2

    #region SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2

    public SecurityGroupBusinessObjectPermissionsResponse
        SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2(string busobname,
            string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2WithHttpInfo(busobname,
            lang, locale).Data;
    }

    private ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>
        SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2WithHttpInfo(string busobname,
            string lang = null, string locale = null)
    {
        if (busobname == null)
            throw new ApiException(400,
                "Missing required parameter 'busobname' when calling SecurityApi->SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2");

        var localVarPath =
            $"/api/V2/Getsecuritygroupbusinessobjectpermissionsforcurrentuserbybusobname/busobname/{busobname}";
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

        var exception = ExceptionFactory?.Invoke(
            "SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityGroupBusinessObjectPermissionsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityGroupBusinessObjectPermissionsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityGroupBusinessObjectPermissionsResponse)));
    }

    #endregion SecurityGetSecurityGroupBusinessObjectPermissionsForCurrentUserByBusObNameV2

    #region SecurityGetSecurityGroupCategoriesV1

    public List<RightCategory> SecurityGetSecurityGroupCategoriesV1(string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupCategoriesV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<List<RightCategory>> SecurityGetSecurityGroupCategoriesV1WithHttpInfo(string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/Getsecuritygroupcategories";
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupCategoriesV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<RightCategory>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<RightCategory>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<RightCategory>)));
    }

    #endregion SecurityGetSecurityGroupCategoriesV1

    #region SecurityGetSecurityGroupCategoriesV2

    public SecurityRightCategoriesResponse SecurityGetSecurityGroupCategoriesV2(string lang = null,
        string locale = null)
    {
        return SecurityGetSecurityGroupCategoriesV2WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<SecurityRightCategoriesResponse> SecurityGetSecurityGroupCategoriesV2WithHttpInfo(
        string lang = null, string locale = null)
    {
        var localVarPath = "/api/V2/Getsecuritygroupcategories";
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

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupCategoriesV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityRightCategoriesResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityRightCategoriesResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityRightCategoriesResponse)));
    }

    #endregion SecurityGetSecurityGroupCategoriesV2

    #region SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1

    public List<SecurityRight> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1(string groupid,
        string categoryid, string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1WithHttpInfo(groupid, categoryid, lang, locale)
            .Data;
    }

    private ApiResponse<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1WithHttpInfo(
        string groupid, string categoryid, string lang = null, string locale = null)
    {
        if (groupid == null)
            throw new ApiException(400,
                "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1");
        if (categoryid == null)
            throw new ApiException(400,
                "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1");

        var localVarPath = $"/api/V1/Getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}";
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

        localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid));
        localVarPathParams.Add("categoryid",
            Configuration.ApiClient.ParameterToString(categoryid));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<SecurityRight>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<SecurityRight>)));
    }

    #endregion SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV1

    #region SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2

    public SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2(string groupid,
        string categoryid, string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2WithHttpInfo(groupid, categoryid, lang, locale)
            .Data;
    }

    private ApiResponse<SecurityRightsResponse> SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2WithHttpInfo(
        string groupid, string categoryid, string lang = null, string locale = null)
    {
        if (groupid == null)
            throw new ApiException(400,
                "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2");
        if (categoryid == null)
            throw new ApiException(400,
                "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2");

        var localVarPath = $"/api/V2/Getsecuritygrouprights/groupid/{groupid}/categoryid/{categoryid}";
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

        localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid));
        localVarPathParams.Add("categoryid",
            Configuration.ApiClient.ParameterToString(categoryid));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityRightsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityRightsResponse)));
    }

    #endregion SecurityGetSecurityGroupRightsByGroupIdAndCategoryIdV2

    #region SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1

    public List<SecurityRight> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1(string groupname,
        string categoryname, string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1WithHttpInfo(groupname, categoryname, lang,
            locale).Data;
    }

    private ApiResponse<List<SecurityRight>> SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1WithHttpInfo(
        string groupname, string categoryname, string lang = null, string locale = null)
    {
        if (groupname == null)
            throw new ApiException(400,
                "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1");
        if (categoryname == null)
            throw new ApiException(400,
                "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1");

        var localVarPath = $"/api/V1/Getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}";
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

        localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname));
        localVarPathParams.Add("categoryname",
            Configuration.ApiClient.ParameterToString(categoryname));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<SecurityRight>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<SecurityRight>)));
    }

    #endregion SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV1

    #region SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2

    public SecurityRightsResponse SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2(string groupname,
        string categoryname, string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2WithHttpInfo(groupname, categoryname, lang,
            locale).Data;
    }

    private ApiResponse<SecurityRightsResponse>
        SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2WithHttpInfo(string groupname,
            string categoryname, string lang = null, string locale = null)
    {
        if (groupname == null)
            throw new ApiException(400,
                "Missing required parameter 'groupname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2");
        if (categoryname == null)
            throw new ApiException(400,
                "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2");

        var localVarPath = $"/api/V2/Getsecuritygrouprights/groupname/{groupname}/categoryname/{categoryname}";
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

        localVarPathParams.Add("groupname", Configuration.ApiClient.ParameterToString(groupname));
        localVarPathParams.Add("categoryname",
            Configuration.ApiClient.ParameterToString(categoryname));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityRightsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityRightsResponse)));
    }

    #endregion SecurityGetSecurityGroupRightsByGroupNameAndCategoryNameV2

    #region SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1

    public List<SecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1(string categoryid,
        string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1WithHttpInfo(categoryid, lang, locale)
            .Data;
    }

    private ApiResponse<List<SecurityRight>> SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1WithHttpInfo(
        string categoryid, string lang = null, string locale = null)
    {
        if (categoryid == null)
            throw new ApiException(400,
                "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1");

        var localVarPath = $"/api/V1/Getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}";
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

        localVarPathParams.Add("categoryid",
            Configuration.ApiClient.ParameterToString(categoryid));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<SecurityRight>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<SecurityRight>)));
    }

    #endregion SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV1

    #region SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2

    public SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2(string categoryid,
        string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2WithHttpInfo(categoryid, lang, locale)
            .Data;
    }

    private ApiResponse<SecurityRightsResponse>
        SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2WithHttpInfo(string categoryid,
            string lang = null, string locale = null)
    {
        if (categoryid == null)
            throw new ApiException(400,
                "Missing required parameter 'categoryid' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2");

        var localVarPath = $"/api/V2/Getsecuritygrouprightsforcurrentuserbycategoryid/categoryid/{categoryid}";
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

        localVarPathParams.Add("categoryid",
            Configuration.ApiClient.ParameterToString(categoryid));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityRightsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityRightsResponse)));
    }

    #endregion SecurityGetSecurityGroupRightsForCurrentUserByCategoryIdV2

    #region SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1

    public List<SecurityRight> SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1(string categoryname,
        string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1WithHttpInfo(categoryname, lang, locale)
            .Data;
    }

    private ApiResponse<List<SecurityRight>>
        SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1WithHttpInfo(string categoryname,
            string lang = null, string locale = null)
    {
        if (categoryname == null)
            throw new ApiException(400,
                "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1");

        var localVarPath =
            $"/api/V1/Getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}";
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

        localVarPathParams.Add("categoryname",
            Configuration.ApiClient.ParameterToString(categoryname));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<SecurityRight>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<SecurityRight>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<SecurityRight>)));
    }

    #endregion SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV1

    #region SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2

    public SecurityRightsResponse SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2(string categoryname,
        string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2WithHttpInfo(categoryname, lang, locale)
            .Data;
    }

    private ApiResponse<SecurityRightsResponse>
        SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2WithHttpInfo(string categoryname,
            string lang = null, string locale = null)
    {
        if (categoryname == null)
            throw new ApiException(400,
                "Missing required parameter 'categoryname' when calling SecurityApi->SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2");

        var localVarPath =
            $"/api/V2/Getsecuritygrouprightsforcurrentuserbycategoryname/categoryname/{categoryname}";
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

        localVarPathParams.Add("categoryname",
            Configuration.ApiClient.ParameterToString(categoryname));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityRightsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityRightsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityRightsResponse)));
    }

    #endregion SecurityGetSecurityGroupRightsForCurrentUserByCategoryNameV2

    #region SecurityGetSecurityGroupsV2

    public SecurityGroupV2Response SecurityGetSecurityGroupsV2(string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupsV2WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<SecurityGroupV2Response> SecurityGetSecurityGroupsV2WithHttpInfo(string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V2/Getsecuritygroups";
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupsV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityGroupV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityGroupV2Response)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityGroupV2Response)));
    }

    #endregion SecurityGetSecurityGroupsV2

    #region SecurityGetUsersInSecurityGroupV1

    public List<User> SecurityGetUsersInSecurityGroupV1(string groupid, string lang = null, string locale = null)
    {
        return SecurityGetUsersInSecurityGroupV1WithHttpInfo(groupid, lang, locale).Data;
    }

    private ApiResponse<List<User>> SecurityGetUsersInSecurityGroupV1WithHttpInfo(string groupid,
        string lang = null, string locale = null)
    {
        if (groupid == null)
            throw new ApiException(400,
                "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetUsersInSecurityGroupV1");

        var localVarPath = $"/api/V1/Getusersinsecuritygroup/groupid/{groupid}";
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

        localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetUsersInSecurityGroupV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<User>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<User>)Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<User>)));
    }

    #endregion SecurityGetUsersInSecurityGroupV1

    #region SecurityGetUsersInSecurityGroupV2

    public UserReadV2Response SecurityGetUsersInSecurityGroupV2(string groupid, string lang = null,
        string locale = null)
    {
        return SecurityGetUsersInSecurityGroupV2WithHttpInfo(groupid, lang, locale).Data;
    }

    private ApiResponse<UserReadV2Response> SecurityGetUsersInSecurityGroupV2WithHttpInfo(string groupid,
        string lang = null, string locale = null)
    {
        if (groupid == null)
            throw new ApiException(400,
                "Missing required parameter 'groupid' when calling SecurityApi->SecurityGetUsersInSecurityGroupV2");

        var localVarPath = $"/api/V2/Getusersinsecuritygroup/groupid/{groupid}";
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

        localVarPathParams.Add("groupid", Configuration.ApiClient.ParameterToString(groupid));
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

        var exception = ExceptionFactory?.Invoke("SecurityGetUsersInSecurityGroupV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<UserReadV2Response>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (UserReadV2Response)Configuration.ApiClient.Deserialize(localVarResponse, typeof(UserReadV2Response)));
    }

    #endregion SecurityGetUsersInSecurityGroupV2

    #region SecurityGetSecurityGroupsV1

    public SecurityGroupResponse SecurityGetSecurityGroupsV1(string lang = null, string locale = null)
    {
        return SecurityGetSecurityGroupsV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<SecurityGroupResponse> SecurityGetSecurityGroupsV1WithHttpInfo(string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/Getsecuritygroups";
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

        var exception = ExceptionFactory?.Invoke("SecurityGetSecurityGroupsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SecurityGroupResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SecurityGroupResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SecurityGroupResponse)));
    }

    #endregion SecurityGetSecurityGroupsV1
}