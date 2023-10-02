using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SwaggerLookup.Helpers.CherwellConnector.Client;
using SwaggerLookup.Helpers.CherwellConnector.Interface;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Helpers.CherwellConnector.Api;

public class SearchesApi : BaseApi, ISearchesApi
{
    #region Variables & Properties

    private static SearchesApi _instance;

    private static readonly object Padlock = new();

    public static SearchesApi Instance
    {
        get
        {
            lock (Padlock)
            {
                _instance ??= new SearchesApi();

                _instance = (SearchesApi)ServiceApi.Instance.CheckApiHeader(_instance);
                return _instance;
            }
        }
        set => _instance = value;
    }

    #endregion Variables & Properties

    #region Constructors



    private SearchesApi()
    {
        Configuration = ServiceApi.Instance.Configuration;

        ExceptionFactory = Configuration.DefaultExceptionFactory;
    }

    #endregion Constructors

    #region SearchesGetQuickSearchConfigurationForBusObsV1

    public QuickSearchConfigurationResponse SearchesGetQuickSearchConfigurationForBusObsV1(
        QuickSearchConfigurationRequest dataRequest, string lang = null, string locale = null)
    {
        return SearchesGetQuickSearchConfigurationForBusObsV1WithHttpInfo(dataRequest, lang, locale).Data;
    }

    private ApiResponse<QuickSearchConfigurationResponse>
        SearchesGetQuickSearchConfigurationForBusObsV1WithHttpInfo(QuickSearchConfigurationRequest dataRequest,
            string lang = null, string locale = null)
    {
        if (dataRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchConfigurationForBusObsV1");

        const string varPath = "/api/V1/Getquicksearchconfigurationforbusobs";
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

        var exception =
            ExceptionFactory?.Invoke("SearchesGetQuickSearchConfigurationForBusObsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<QuickSearchConfigurationResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (QuickSearchConfigurationResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(QuickSearchConfigurationResponse)));
    }

    #endregion SearchesGetQuickSearchConfigurationForBusObsV1

    #region SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1

    public QuickSearchConfigurationResponse SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1(
        string lang = null, string locale = null)
    {
        return SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1WithHttpInfo(lang, locale).Data;
    }

    private ApiResponse<QuickSearchConfigurationResponse>
        SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1WithHttpInfo(string lang = null,
            string locale = null)
    {
        const string varPath = "/api/V1/Getquicksearchconfigurationforbusobswithviewrights";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<QuickSearchConfigurationResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (QuickSearchConfigurationResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(QuickSearchConfigurationResponse)));
    }

    #endregion SearchesGetQuickSearchConfigurationForBusObsWithViewRightsV1

    #region SearchesGetQuickSearchResultsV1

    public SimpleResultsList SearchesGetQuickSearchResultsV1(QuickSearchRequest dataRequest,
        bool? includeLinks = null, string lang = null, string locale = null)
    {
        return SearchesGetQuickSearchResultsV1WithHttpInfo(dataRequest, includeLinks, lang, locale).Data;
    }

    private ApiResponse<SimpleResultsList> SearchesGetQuickSearchResultsV1WithHttpInfo(
        QuickSearchRequest dataRequest, bool? includeLinks = null, string lang = null, string locale = null)
    {
        if (dataRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchResultsV1");

        const string varPath = "/api/V1/Getquicksearchresults";
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

        if (includeLinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks",
                    includeLinks));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetQuickSearchResultsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SimpleResultsList>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SimpleResultsList)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SimpleResultsList)));
    }

    #endregion SearchesGetQuickSearchResultsV1

    #region SearchesGetQuickSearchSpecificResultsV1

    public SearchResultsTableResponse SearchesGetQuickSearchSpecificResultsV1(
        QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null,
        bool? includeLinks = null, string lang = null, string locale = null)
    {
        return SearchesGetQuickSearchSpecificResultsV1WithHttpInfo(dataRequest, includeSchema,
            includeLocationFields, includeLinks, lang, locale).Data;
    }

    private ApiResponse<SearchResultsTableResponse> SearchesGetQuickSearchSpecificResultsV1WithHttpInfo(
        QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null,
        bool? includeLinks = null, string lang = null, string locale = null)
    {
        if (dataRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchSpecificResultsV1");

        const string varPath = "/api/V1/Getquicksearchspecificresults";
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

        if (includeSchema != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeSchema",
                    includeSchema));
        if (includeLocationFields != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLocationFields",
                    includeLocationFields));
        if (includeLinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks",
                    includeLinks));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetQuickSearchSpecificResultsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchResultsTableResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchResultsTableResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchResultsTableResponse)));
    }

    #endregion SearchesGetQuickSearchSpecificResultsV1

    #region SearchesGetQuickSearchSpecificResultsV2

    public QuickSearchResponse SearchesGetQuickSearchSpecificResultsV2(QuickSearchSpecificRequest dataRequest,
        bool? includeSchema = null, bool? includeLocationFields = null, bool? includeLinks = null,
        string lang = null, string locale = null)
    {
        return SearchesGetQuickSearchSpecificResultsV2WithHttpInfo(dataRequest, includeSchema,
            includeLocationFields, includeLinks, lang, locale).Data;
    }

    private ApiResponse<QuickSearchResponse> SearchesGetQuickSearchSpecificResultsV2WithHttpInfo(
        QuickSearchSpecificRequest dataRequest, bool? includeSchema = null, bool? includeLocationFields = null,
        bool? includeLinks = null, string lang = null, string locale = null)
    {
        if (dataRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetQuickSearchSpecificResultsV2");

        const string varPath = "/api/V2/Getquicksearchspecificresults";
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

        if (includeSchema != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeSchema",
                    includeSchema));
        if (includeLocationFields != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLocationFields",
                    includeLocationFields));
        if (includeLinks != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeLinks",
                    includeLinks));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetQuickSearchSpecificResultsV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<QuickSearchResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (QuickSearchResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(QuickSearchResponse)));
    }

    #endregion SearchesGetQuickSearchSpecificResultsV2

    #region SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1

    public SearchItemResponse SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1(string association,
        string scope, string scopeowner, string folder, bool? links = null, string lang = null,
        string locale = null)
    {
        return SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1WithHttpInfo(association, scope,
            scopeowner, folder, links, lang, locale).Data;
    }

    private ApiResponse<SearchItemResponse> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1WithHttpInfo(
        string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null,
        string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");
        if (folder == null)
            throw new ApiException(400,
                "Missing required parameter 'folder' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1");

        var localVarPath =
            $"/api/V1/Getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchItemResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchItemResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
    }

    #endregion SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV1

    #region SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2

    public ManagerData SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2(string association, string scope,
        string scopeowner, string folder, bool? links = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2WithHttpInfo(association, scope,
            scopeowner, folder, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2WithHttpInfo(
        string association, string scope, string scopeowner, string folder, bool? links = null, string lang = null,
        string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");
        if (folder == null)
            throw new ApiException(400,
                "Missing required parameter 'folder' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2");

        var localVarPath =
            $"/api/V2/Getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}/folder/{folder}";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion SearchesGetSearchItemsByAssociationScopeScopeOwnerFolderV2

    #region SearchesGetSearchItemsByAssociationScopeScopeOwnerV1

    public SearchItemResponse SearchesGetSearchItemsByAssociationScopeScopeOwnerV1(string association, string scope,
        string scopeowner, bool? links = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsByAssociationScopeScopeOwnerV1WithHttpInfo(association, scope, scopeowner,
            links, lang, locale).Data;
    }

    private ApiResponse<SearchItemResponse> SearchesGetSearchItemsByAssociationScopeScopeOwnerV1WithHttpInfo(
        string association, string scope, string scopeowner, bool? links = null, string lang = null,
        string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV1");

        var localVarPath =
            $"/api/V1/Getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationScopeScopeOwnerV1",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchItemResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchItemResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
    }

    #endregion SearchesGetSearchItemsByAssociationScopeScopeOwnerV1

    #region SearchesGetSearchItemsByAssociationScopeScopeOwnerV2

    public ManagerData SearchesGetSearchItemsByAssociationScopeScopeOwnerV2(string association, string scope,
        string scopeowner, bool? links = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsByAssociationScopeScopeOwnerV2WithHttpInfo(association, scope, scopeowner,
            links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> SearchesGetSearchItemsByAssociationScopeScopeOwnerV2WithHttpInfo(
        string association, string scope, string scopeowner, bool? links = null, string lang = null,
        string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeScopeOwnerV2");

        var localVarPath =
            $"/api/V2/Getsearchitems/association/{association}/scope/{scope}/scopeowner/{scopeowner}";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationScopeScopeOwnerV2",
            localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion SearchesGetSearchItemsByAssociationScopeScopeOwnerV2

    #region SearchesGetSearchItemsByAssociationScopeV1

    public SearchItemResponse SearchesGetSearchItemsByAssociationScopeV1(string association, string scope,
        bool? links = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsByAssociationScopeV1WithHttpInfo(association, scope, links, lang, locale).Data;
    }

    private ApiResponse<SearchItemResponse> SearchesGetSearchItemsByAssociationScopeV1WithHttpInfo(
        string association, string scope, bool? links = null, string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV1");

        var localVarPath = $"/api/V1/Getsearchitems/association/{association}/scope/{scope}";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationScopeV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchItemResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchItemResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
    }

    #endregion SearchesGetSearchItemsByAssociationScopeV1

    #region SearchesGetSearchItemsByAssociationScopeV2

    public ManagerData SearchesGetSearchItemsByAssociationScopeV2(string association, string scope,
        bool? links = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsByAssociationScopeV2WithHttpInfo(association, scope, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> SearchesGetSearchItemsByAssociationScopeV2WithHttpInfo(string association,
        string scope, bool? links = null, string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV2");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchItemsByAssociationScopeV2");

        var localVarPath = $"/api/V2/Getsearchitems/association/{association}/scope/{scope}";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationScopeV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion SearchesGetSearchItemsByAssociationScopeV2

    #region SearchesGetSearchItemsByAssociationV1

    public SearchItemResponse SearchesGetSearchItemsByAssociationV1(string association, bool? links = null,
        string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsByAssociationV1WithHttpInfo(association, links, lang, locale).Data;
    }

    private ApiResponse<SearchItemResponse> SearchesGetSearchItemsByAssociationV1WithHttpInfo(string association,
        bool? links = null, string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationV1");

        var localVarPath = $"/api/V1/Getsearchitems/association/{association}";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchItemResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchItemResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
    }

    #endregion SearchesGetSearchItemsByAssociationV1

    #region SearchesGetSearchItemsByAssociationV2

    public ManagerData SearchesGetSearchItemsByAssociationV2(string association, bool? links = null,
        string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsByAssociationV2WithHttpInfo(association, links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> SearchesGetSearchItemsByAssociationV2WithHttpInfo(string association,
        bool? links = null, string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationV2");

        var localVarPath = $"/api/V2/Getsearchitems/association/{association}";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion SearchesGetSearchItemsByAssociationV2

    #region SearchesGetSearchItemsV1

    public SearchItemResponse SearchesGetSearchItemsV1(bool? links = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsV1WithHttpInfo(links, lang, locale).Data;
    }

    private ApiResponse<SearchItemResponse> SearchesGetSearchItemsV1WithHttpInfo(bool? links = null,
        string lang = null, string locale = null)
    {
        const string varPath = "/api/V1/Getsearchitems";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchItemResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchItemResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchItemResponse)));
    }

    #endregion SearchesGetSearchItemsV1

    #region SearchesGetSearchItemsV2

    public ManagerData SearchesGetSearchItemsV2(bool? links = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchItemsV2WithHttpInfo(links, lang, locale).Data;
    }

    private ApiResponse<ManagerData> SearchesGetSearchItemsV2WithHttpInfo(bool? links = null, string lang = null,
        string locale = null)
    {
        const string varPath = "/api/V2/Getsearchitems";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<ManagerData>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (ManagerData)Configuration.ApiClient.Deserialize(localVarResponse, typeof(ManagerData)));
    }

    #endregion SearchesGetSearchItemsV2

    #region SearchesGetSearchResultsAdHocV1

    public SearchResultsResponse SearchesGetSearchResultsAdHocV1(SearchResultsRequest dataRequest,
        string lang = null, string locale = null)
    {
        return SearchesGetSearchResultsAdHocV1WithHttpInfo(dataRequest, lang, locale).Data;
    }

    private ApiResponse<SearchResultsResponse> SearchesGetSearchResultsAdHocV1WithHttpInfo(
        SearchResultsRequest dataRequest, string lang = null, string locale = null)
    {
        if (dataRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetSearchResultsAdHocV1");

        const string varPath = "/api/V1/Getsearchresults";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsAdHocV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchResultsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchResultsResponse)));
    }

    #endregion SearchesGetSearchResultsAdHocV1

    #region SearchesGetSearchResultsAsStringByIdV2

    public StoredSearchResults SearchesGetSearchResultsAsStringByIdV2(StoredSearchRequest searchRequest,
        string lang = null, string locale = null)
    {
        return SearchesGetSearchResultsAsStringByIdV2WithHttpInfo(searchRequest, lang, locale).Data;
    }

    private ApiResponse<StoredSearchResults> SearchesGetSearchResultsAsStringByIdV2WithHttpInfo(
        StoredSearchRequest searchRequest, string lang = null, string locale = null)
    {
        if (searchRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'searchRequest' when calling SearchesApi->SearchesGetSearchResultsAsStringByIdV2");

        const string varPath = "/api/V2/storedsearches";
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
        if (searchRequest.GetType() != typeof(byte[]))
            localVarPostBody = ApiClient.Serialize(searchRequest);
        else
            localVarPostBody = searchRequest;

        if (!string.IsNullOrEmpty(Configuration.AccessToken))
            localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;

        var localVarResponse = (RestResponse)Configuration.ApiClient.CallApi(varPath,
            Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
            localVarFileParams,
            localVarPathParams, localVarHttpContentType);

        var localVarStatusCode = (int)localVarResponse.StatusCode;

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsAsStringByIdV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<StoredSearchResults>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (StoredSearchResults)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(StoredSearchResults)));
    }

    #endregion SearchesGetSearchResultsAsStringByIdV2

    #region SearchesGetSearchResultsAsStringByNameV1

    public List<Dictionary<string, string>> SearchesGetSearchResultsAsStringByNameV1(string scope,
        string associationName, string searchName, string scopeOwner = null, string lang = null,
        string locale = null)
    {
        return SearchesGetSearchResultsAsStringByNameV1WithHttpInfo(scope, associationName, searchName, scopeOwner,
            lang, locale).Data;
    }

    private ApiResponse<List<Dictionary<string, string>>> SearchesGetSearchResultsAsStringByNameV1WithHttpInfo(
        string scope, string associationName, string searchName, string scopeOwner = null, string lang = null,
        string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");
        if (associationName == null)
            throw new ApiException(400,
                "Missing required parameter 'associationName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");
        if (searchName == null)
            throw new ApiException(400,
                "Missing required parameter 'searchName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV1");

        var localVarPath = $"/api/V1/storedsearches/{scope}/{associationName}/{searchName}";
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
        localVarPathParams.Add("associationName",
            Configuration.ApiClient.ParameterToString(associationName));
        localVarPathParams.Add("searchName",
            Configuration.ApiClient.ParameterToString(searchName));
        if (scopeOwner != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "scopeOwner", scopeOwner));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsAsStringByNameV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<Dictionary<string, string>>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<Dictionary<string, string>>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<Dictionary<string, string>>)));
    }

    #endregion SearchesGetSearchResultsAsStringByNameV1

    #region SearchesGetSearchResultsAsStringByNameV2

    public List<Dictionary<string, string>> SearchesGetSearchResultsAsStringByNameV2(string scope,
        string associationName, string searchName, string scopeOwner = null, string lang = null,
        string locale = null)
    {
        return SearchesGetSearchResultsAsStringByNameV2WithHttpInfo(scope, associationName, searchName, scopeOwner,
            lang, locale).Data;
    }

    private ApiResponse<List<Dictionary<string, string>>> SearchesGetSearchResultsAsStringByNameV2WithHttpInfo(
        string scope, string associationName, string searchName, string scopeOwner = null, string lang = null,
        string locale = null)
    {
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");
        if (associationName == null)
            throw new ApiException(400,
                "Missing required parameter 'associationName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");
        if (searchName == null)
            throw new ApiException(400,
                "Missing required parameter 'searchName' when calling SearchesApi->SearchesGetSearchResultsAsStringByNameV2");

        var localVarPath = $"/api/V2/storedsearches/{scope}/{associationName}/{searchName}";
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
        localVarPathParams.Add("associationName",
            Configuration.ApiClient.ParameterToString(associationName));
        localVarPathParams.Add("searchName",
            Configuration.ApiClient.ParameterToString(searchName));
        if (scopeOwner != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "scopeOwner", scopeOwner));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsAsStringByNameV2", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<List<Dictionary<string, string>>>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (List<Dictionary<string, string>>)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(List<Dictionary<string, string>>)));
    }

    #endregion SearchesGetSearchResultsAsStringByNameV2

    #region SearchesGetSearchResultsByIdV1

    public SearchResultsResponse SearchesGetSearchResultsByIdV1(string association, string scope, string scopeowner,
        string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null,
        bool? includeschema = null, bool? resultsAsSimpleResultsList = null, string lang = null,
        string locale = null)
    {
        return SearchesGetSearchResultsByIdV1WithHttpInfo(association, scope, scopeowner, searchid, searchTerm,
            pagenumber, pagesize, includeschema, resultsAsSimpleResultsList, lang, locale).Data;
    }

    private ApiResponse<SearchResultsResponse> SearchesGetSearchResultsByIdV1WithHttpInfo(string association,
        string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null,
        int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null,
        string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
        if (searchid == null)
            throw new ApiException(400,
                "Missing required parameter 'searchid' when calling SearchesApi->SearchesGetSearchResultsByIdV1");

        var localVarPath =
            $"/api/V1/Getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}";
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
        localVarPathParams.Add("searchid", Configuration.ApiClient.ParameterToString(searchid));
        if (searchTerm != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm));
        if (pagenumber != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber));
        if (pagesize != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize));
        if (includeschema != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeschema",
                    includeschema));
        if (resultsAsSimpleResultsList != null)
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
                "resultsAsSimpleResultsList", resultsAsSimpleResultsList));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsByIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchResultsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchResultsResponse)));
    }

    #endregion SearchesGetSearchResultsByIdV1

    #region SearchesGetSearchResultsByNameV1

    public SearchResultsResponse SearchesGetSearchResultsByNameV1(string association, string scope,
        string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null,
        int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null,
        string lang = null, string locale = null)
    {
        return SearchesGetSearchResultsByNameV1WithHttpInfo(association, scope, scopeowner, searchname, searchTerm,
            pagenumber, pagesize, includeschema, resultsAsSimpleResultsList, lang, locale).Data;
    }

    private ApiResponse<SearchResultsResponse> SearchesGetSearchResultsByNameV1WithHttpInfo(string association,
        string scope, string scopeowner, string searchname, string searchTerm = null, int? pagenumber = null,
        int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null,
        string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsByNameV1");
        if (searchname == null)
            throw new ApiException(400,
                "Missing required parameter 'searchname' when calling SearchesApi->SearchesGetSearchResultsByNameV1");

        var localVarPath =
            $"/api/V1/Getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}";
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
        localVarPathParams.Add("searchname",
            Configuration.ApiClient.ParameterToString(searchname));
        if (searchTerm != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm));
        if (pagenumber != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber));
        if (pagesize != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize));
        if (includeschema != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "includeschema",
                    includeschema));
        if (resultsAsSimpleResultsList != null)
            localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("",
                "resultsAsSimpleResultsList", resultsAsSimpleResultsList));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsByNameV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (SearchResultsResponse)Configuration.ApiClient.Deserialize(localVarResponse,
                typeof(SearchResultsResponse)));
    }

    #endregion SearchesGetSearchResultsByNameV1

    #region SearchesGetSearchResultsExportAdHocV1

    public string SearchesGetSearchResultsExportAdHocV1(ExportSearchResultsRequest dataRequest, string lang = null,
        string locale = null)
    {
        return SearchesGetSearchResultsExportAdHocV1WithHttpInfo(dataRequest, lang, locale).Data;
    }

    private ApiResponse<string> SearchesGetSearchResultsExportAdHocV1WithHttpInfo(
        ExportSearchResultsRequest dataRequest, string lang = null, string locale = null)
    {
        if (dataRequest == null)
            throw new ApiException(400,
                "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetSearchResultsExportAdHocV1");

        const string varPath = "/api/V1/Getsearchresultsexport";
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsExportAdHocV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<string>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
    }

    #endregion SearchesGetSearchResultsExportAdHocV1

    #region SearchesGetSearchResultsExportByIdV1

    public string SearchesGetSearchResultsExportByIdV1(string association, string scope, string scopeowner,
        string searchid, string exportformat, string searchTerm = null, int? pagenumber = null,
        int? pagesize = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchResultsExportByIdV1WithHttpInfo(association, scope, scopeowner, searchid,
            exportformat, searchTerm, pagenumber, pagesize, lang, locale).Data;
    }

    private ApiResponse<string> SearchesGetSearchResultsExportByIdV1WithHttpInfo(string association, string scope,
        string scopeowner, string searchid, string exportformat, string searchTerm = null, int? pagenumber = null,
        int? pagesize = null, string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
        if (searchid == null)
            throw new ApiException(400,
                "Missing required parameter 'searchid' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");
        if (exportformat == null)
            throw new ApiException(400,
                "Missing required parameter 'exportformat' when calling SearchesApi->SearchesGetSearchResultsExportByIdV1");

        var localVarPath =
            $"/api/V1/Getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}/exportformat/{exportformat}";
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
        localVarPathParams.Add("searchid", Configuration.ApiClient.ParameterToString(searchid));
        localVarPathParams.Add("exportformat",
            Configuration.ApiClient.ParameterToString(exportformat));
        if (searchTerm != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm));
        if (pagenumber != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber));
        if (pagesize != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsExportByIdV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<string>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
    }

    #endregion SearchesGetSearchResultsExportByIdV1

    #region SearchesGetSearchResultsExportByNameV1

    public string SearchesGetSearchResultsExportByNameV1(string association, string scope, string scopeowner,
        string searchname, string exportformat, string searchTerm = null, int? pagenumber = null,
        int? pagesize = null, string lang = null, string locale = null)
    {
        return SearchesGetSearchResultsExportByNameV1WithHttpInfo(association, scope, scopeowner, searchname,
            exportformat, searchTerm, pagenumber, pagesize, lang, locale).Data;
    }

    private ApiResponse<string> SearchesGetSearchResultsExportByNameV1WithHttpInfo(string association, string scope,
        string scopeowner, string searchname, string exportformat, string searchTerm = null, int? pagenumber = null,
        int? pagesize = null, string lang = null, string locale = null)
    {
        if (association == null)
            throw new ApiException(400,
                "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
        if (scope == null)
            throw new ApiException(400,
                "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
        if (scopeowner == null)
            throw new ApiException(400,
                "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
        if (searchname == null)
            throw new ApiException(400,
                "Missing required parameter 'searchname' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");
        if (exportformat == null)
            throw new ApiException(400,
                "Missing required parameter 'exportformat' when calling SearchesApi->SearchesGetSearchResultsExportByNameV1");

        var localVarPath =
            $"/api/V1/Getsearchresultsexport/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchname/{searchname}/exportformat/{exportformat}";
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
        localVarPathParams.Add("searchname",
            Configuration.ApiClient.ParameterToString(searchname));
        localVarPathParams.Add("exportformat",
            Configuration.ApiClient.ParameterToString(exportformat));
        if (searchTerm != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm));
        if (pagenumber != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber));
        if (pagesize != null)
            localVarQueryParams.AddRange(
                Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize));
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

        var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsExportByNameV1", localVarResponse);
        if (exception != null) throw exception;

        return new ApiResponse<string>(localVarStatusCode,
            localVarResponse.Headers?.ToDictionary(x => x.Name, x => x.Value?.ToString()),
            (string)Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
    }

    #endregion SearchesGetSearchResultsExportByNameV1
}