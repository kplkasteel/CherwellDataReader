using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class CoreApi : BaseApi, ICoreApi
{
    #region Variables & Properties

    private static CoreApi _instance;

    private static readonly object Padlock = new();

    public static CoreApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new CoreApi();

                _instance = (CoreApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Constructors

    private CoreApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructors

    #region CoreDeleteGalleryImageByStandInKeyV1

    public object CoreDeleteGalleryImageByStandInKeyV1(string standinkey, string lang = null, string locale = null)
    {
        return CoreDeleteGalleryImageByStandInKeyV1WithHttpInfo(standinkey, lang, locale).Data;
    }

    private ApiResponse<object> CoreDeleteGalleryImageByStandInKeyV1WithHttpInfo(string standinkey,
        string lang = null, string locale = null)
    {
        if (standinkey == null)
            throw new ApiException(400,
                "Missing required parameter 'standinkey' when calling CoreApi->CoreDeleteGalleryImageByStandInKeyV1");

        var localVarPath = $"/api/V1/Deletegalleryimage/standinkey/{standinkey}";
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
            Method.Delete, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("CoreDeleteGalleryImageByStandInKeyV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<object>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            null);
    }

    #endregion CoreDeleteGalleryImageByStandInKeyV1

    #region CoreGetGalleryImageV1

    public byte[] CoreGetGalleryImageV1(string name, int? width = null, int? height = null, string lang = null,
        string locale = null)
    {
        return CoreGetGalleryImageV1WithHttpInfo(name, width, height, lang, locale).Data;
    }

    private ApiResponse<byte[]> CoreGetGalleryImageV1WithHttpInfo(string name, int? width = null,
        int? height = null, string lang = null, string locale = null)
    {
        if (name == null)
            throw new ApiException(400,
                "Missing required parameter 'name' when calling CoreApi->CoreGetGalleryImageV1");

        var localVarPath = $"/api/V1/Getgalleryimage/name/{name}";
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

        localVarPathParams.Add("name", Configuration.ApiClient.ParameterToString(name));
        if (width != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "width", width));
        if (height != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "height", height));
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

        var exception = ExceptionFactory?.Invoke("CoreGetGalleryImageV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<byte[]>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (byte[])Configuration.ApiClient.Deserialize(localVarResponse, typeof(byte[])));
    }

    #endregion CoreGetGalleryImageV1

    #region CoreGetGalleryImagesFolderV1

    public ManagerData CoreGetGalleryImagesFolderV1(string scope, string scopeowner, string folder,
        bool? links = null, string lang = null, string locale = null)
    {
        return CoreGetGalleryImagesFolderV1WithHttpInfo(scope, scopeowner, folder, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> CoreGetGalleryImagesFolderV1WithHttpInfo(string scope, string scopeowner,
        string folder, bool? links = null, string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling CoreApi->CoreGetGalleryImagesFolderV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling CoreApi->CoreGetGalleryImagesFolderV1");
        if (folder == null)
            throw new ApiException(400,
                "Missing required parameter 'folder' when calling CoreApi->CoreGetGalleryImagesFolderV1");

        var localVarPath = $"/api/V1/Getgalleryimages/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

        var exception = ExceptionFactory?.Invoke("CoreGetGalleryImagesFolderV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion CoreGetGalleryImagesFolderV1

    #region CoreGetGalleryImagesScopeOwnerV1

    public ManagerData CoreGetGalleryImagesScopeOwnerV1(string scope, string scopeowner, bool? links = null,
        string lang = null, string locale = null)
    {
        return CoreGetGalleryImagesScopeOwnerV1WithHttpInfo(scope, scopeowner, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> CoreGetGalleryImagesScopeOwnerV1WithHttpInfo(string scope, string scopeowner,
        bool? links = null, string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling CoreApi->CoreGetGalleryImagesScopeOwnerV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling CoreApi->CoreGetGalleryImagesScopeOwnerV1");

        var localVarPath = $"/api/V1/Getgalleryimages/scope/{scope}/scopeowner/{scopeowner}";
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
            Method.Get, localVarQueryParams, null, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("CoreGetGalleryImagesScopeOwnerV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion CoreGetGalleryImagesScopeOwnerV1

    #region CoreGetGalleryImagesScopeV1

    public ManagerData CoreGetGalleryImagesScopeV1(string scope, bool? links = null, string lang = null,
        string locale = null)
    {
        return CoreGetGalleryImagesScopeV1WithHttpInfo(scope, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> CoreGetGalleryImagesScopeV1WithHttpInfo(string scope, bool? links = null,
        string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling CoreApi->CoreGetGalleryImagesScopeV1");

        var localVarPath = $"/api/V1/Getgalleryimages/scope/{scope}";
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

        var exception = ExceptionFactory?.Invoke("CoreGetGalleryImagesScopeV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion CoreGetGalleryImagesScopeV1

    #region CoreGetGalleryImagesV1

    public ManagerData CoreGetGalleryImagesV1(bool? links = null, string lang = null, string locale = null)
    {
        return CoreGetGalleryImagesV1WithHttpInfo(links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> CoreGetGalleryImagesV1WithHttpInfo(bool? links = null, string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/Getgalleryimages";
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

        var exception = ExceptionFactory?.Invoke("CoreGetGalleryImagesV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion CoreGetGalleryImagesV1

    #region CoreGetStoredValueV1

    public StoredValueResponse CoreGetStoredValueV1(string standInKey, string lang = null, string locale = null)
    {
        return CoreGetStoredValueV1WithHttpInfo(standInKey, lang, locale).Data;
    }

    private ApiResponse<StoredValueResponse> CoreGetStoredValueV1WithHttpInfo(string standInKey, string lang = null,
        string locale = null)
    {
        if (standInKey == null)
            throw new ApiException(400,
                "Missing required parameter 'standInKey' when calling CoreApi->CoreGetStoredValueV1");

        var localVarPath = $"/api/V1/Getstoredvalue/standinkey/{standInKey}";
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

        localVarPathParams.Add("standInKey",
            Configuration.ApiClient.ParameterToString(standInKey));
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

        var exception = ExceptionFactory?.Invoke("CoreGetStoredValueV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<StoredValueResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (StoredValueResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(StoredValueResponse)));
    }

    #endregion CoreGetStoredValueV1

    #region CoreGetStoredValuesFolderV1

    public ManagerData CoreGetStoredValuesFolderV1(string scope, string scopeowner, string folder,
        bool? links = null, string lang = null, string locale = null)
    {
        return CoreGetStoredValuesFolderV1WithHttpInfo(scope, scopeowner, folder, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> CoreGetStoredValuesFolderV1WithHttpInfo(string scope, string scopeowner,
        string folder, bool? links = null, string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling CoreApi->CoreGetStoredValuesFolderV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling CoreApi->CoreGetStoredValuesFolderV1");
        if (folder == null)
            throw new ApiException(400,
                "Missing required parameter 'folder' when calling CoreApi->CoreGetStoredValuesFolderV1");

        var localVarPath = $"/api/V1/storedvalues/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

        var exception = ExceptionFactory?.Invoke("CoreGetStoredValuesFolderV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion CoreGetStoredValuesFolderV1

    #region CoreGetStoredValuesScopeOwnerV1

    public ManagerData CoreGetStoredValuesScopeOwnerV1(string scope, string scopeowner, bool? links = null,
        string lang = null, string locale = null)
    {
        return CoreGetStoredValuesScopeOwnerV1WithHttpInfo(scope, scopeowner, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> CoreGetStoredValuesScopeOwnerV1WithHttpInfo(string scope, string scopeowner,
        bool? links = null, string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling CoreApi->CoreGetStoredValuesScopeOwnerV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling CoreApi->CoreGetStoredValuesScopeOwnerV1");

        var localVarPath = $"/api/V1/storedvalues/scope/{scope}/scopeowner/{scopeowner}";
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

        var exception = ExceptionFactory?.Invoke("CoreGetStoredValuesScopeOwnerV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion CoreGetStoredValuesScopeOwnerV1

    #region CoreGetStoredValuesScopeV1

    public ManagerData CoreGetStoredValuesScopeV1(string scope, bool? links = null, string lang = null,
        string locale = null)
    {
        return CoreGetStoredValuesScopeV1WithHttpInfo(scope, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> CoreGetStoredValuesScopeV1WithHttpInfo(string scope, bool? links = null,
        string lang = null, string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling CoreApi->CoreGetStoredValuesScopeV1");

        var localVarPath = $"/api/V1/storedvalues/scope/{scope}";
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

        var exception = ExceptionFactory?.Invoke("CoreGetStoredValuesScopeV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion CoreGetStoredValuesScopeV1

    #region CoreGetStoredValuesV1

    public ManagerData CoreGetStoredValuesV1(bool? links = null, string lang = null, string locale = null)
    {
        return CoreGetStoredValuesV1WithHttpInfo(links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> CoreGetStoredValuesV1WithHttpInfo(bool? links = null, string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V1/storedvalues";
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

        var exception = ExceptionFactory?.Invoke("CoreGetStoredValuesV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion CoreGetStoredValuesV1

    #region CoreGetViewsV1

    public ViewsResponse CoreGetViewsV1(string lang = null, string locale = null)
    {
        return CoreGetViewsV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<ViewsResponse> CoreGetViewsV1WithHttpInfo(string lang = null, string locale = null)
    {
        const string varPath = "/api/V1/Getviews";
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

        var exception = ExceptionFactory?.Invoke("CoreGetViewsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ViewsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ViewsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ViewsResponse)));
    }

    #endregion CoreGetViewsV1

    #region CoreSaveGalleryImageV1

    public SaveGalleryImageResponse CoreSaveGalleryImageV1(SaveGalleryImageRequest request, string lang = null,
        string locale = null)
    {
        return CoreSaveGalleryImageV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<SaveGalleryImageResponse> CoreSaveGalleryImageV1WithHttpInfo(
        SaveGalleryImageRequest request, string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling CoreApi->CoreSaveGalleryImageV1");

        const string varPath = "/api/V1/savegalleryimage";
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

        var exception = ExceptionFactory?.Invoke("CoreSaveGalleryImageV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SaveGalleryImageResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SaveGalleryImageResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SaveGalleryImageResponse)));
    }

    #endregion CoreSaveGalleryImageV1

    #region CoreSaveStoredValueV1

    public StoredValueResponse CoreSaveStoredValueV1(SaveStoredValueRequest request, string lang = null,
        string locale = null)
    {
        return CoreSaveStoredValueV1WithHttpInfo(request, lang, locale).Data;
    }

    private ApiResponse<StoredValueResponse> CoreSaveStoredValueV1WithHttpInfo(SaveStoredValueRequest request,
        string lang = null, string locale = null)
    {
        if (request == null)
            throw new ApiException(400,
                "Missing required parameter 'request' when calling CoreApi->CoreSaveStoredValueV1");

        const string varPath = "/api/V1/savestoredvalue";
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

        var exception = ExceptionFactory?.Invoke("CoreSaveStoredValueV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<StoredValueResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (StoredValueResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(StoredValueResponse)));
    }

    #endregion CoreSaveStoredValueV1

    #region CoreSetCultureV1

    public string CoreSetCultureV1(string culturecode, string lang = null, string locale = null)
    {
        return CoreSetCultureV1WithHttpInfo(culturecode, lang, locale).Data;
    }

    private ApiResponse<string> CoreSetCultureV1WithHttpInfo(string culturecode, string lang = null,
        string locale = null)
    {
        if (culturecode == null)
            throw new ApiException(400,
                "Missing required parameter 'culturecode' when calling CoreApi->CoreSetCultureV1");

        var localVarPath = $"/api/V1/setculture/culturecode/{culturecode}";
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

        localVarPathParams.Add("culturecode",
            Configuration.ApiClient.ParameterToString(culturecode));
        if (lang != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "lang", lang));
        if (locale != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "locale", locale));

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(localVarPath,
            Method.Put, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("CoreSetCultureV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<string>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
    }

    #endregion CoreSetCultureV1
}