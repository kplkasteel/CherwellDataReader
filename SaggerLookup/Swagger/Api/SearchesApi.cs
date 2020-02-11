using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISearchesApi : IApiAccessor
    {
        /// <summary>
        /// Run an ad-hoc search
        /// </summary>
        /// <remarks>
        /// Operation that runs an ad-hoc Business Object search. To execute a search with Prompts, the PromptId and Value are required in the Prompt request object.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataRequest">Request object to specify search parameters.</param>
        /// <returns>SearchResultsResponse</returns>
        SearchResultsResponse SearchesGetSearchResultsAdHocV1(SearchResultsRequest dataRequest);

        /// <summary>
        /// Get all saved searches by Business Object association
        /// </summary>
        /// <remarks>
        /// Operation that returns a tree of saved queries, including scope, search name, IDs, and location within the tree.
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Use to filter results by Business Object association ID.</param>
        /// <param name="links">Flag to include hyperlinks in results. Default is false.  (optional)</param>
        /// <returns>SearchItemResponse</returns>
        SearchItemResponse SearchesGetSearchItemsByAssociationV1(string association, bool? links = null);

        /// <summary>
        /// Run a saved search by internal ID
        /// </summary>
        /// <remarks>
        /// Operation that returns the paged results of a saved search. When the search contains Prompts, the response contains the Prompt. Send the Prompt and the original operation parameters to  SearchResultsRequest to the getsearchresults ad-hoc http post operation.&lt;/br&gt;&lt;/br&gt;PromptType is a FieldSubType enum as described below:&lt;/br&gt;FieldSubType&lt;/br&gt;None &#x3D; 0&lt;/br&gt;Text &#x3D; 1&lt;/br&gt;Number &#x3D; 2&lt;/br&gt;DateTime &#x3D; 3&lt;/br&gt;Logical &#x3D; 4&lt;/br&gt;Binary &#x3D; 5&lt;/br&gt;DateOnly &#x3D; 6&lt;/br&gt;TimeOnly &#x3D; 7&lt;/br&gt;Json &#x3D; 8&lt;/br&gt;JsonArray &#x3D; 9&lt;/br&gt;Xml &#x3D; 10&lt;/br&gt;XmlCollection &#x3D; 11&lt;/br&gt;TimeValue &#x3D; 12&lt;/br&gt;
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="association">Specify the Business Object association ID for the saved search.</param>
        /// <param name="scope">Specify the scope name or ID for the saved search.</param>
        /// <param name="scopeowner">Specify the scope owner ID for the saved search. Use (None) when no scope owner exists.</param>
        /// <param name="searchid">Specify the internal ID for the saved search. Use \&quot;Run a saved search by name\&quot; if you do not have the internal ID.</param>
        /// <param name="searchTerm">Specify search text filter the results. Example: Use \&quot;Service Request\&quot; to filter Incident results to include only service requests. (optional)</param>
        /// <param name="pagenumber">Specify the page number of the result set to return. (optional)</param>
        /// <param name="pagesize">Specify the number of rows to return per page. (optional)</param>
        /// <param name="includeschema">Use to include the table schema of the saved search. If false, results contain the fieldid and field value without field information. Default is false. (optional)</param>
        /// <param name="resultsAsSimpleResultsList">Indicates if the results should be returned in a simple results list format or a table format. Default is a table format. (optional)</param>
        /// <returns>SearchResultsResponse</returns>
        SearchResultsResponse SearchesGetSearchResultsByIdV1(string association, string scope, string scopeowner, string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null, bool? resultsAsSimpleResultsList = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchesApi : ISearchesApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchesApi(string basePath)
        {
            Configuration = new Configuration {BasePath = basePath};

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SearchesApi(Configuration configuration = null)
        {
            Configuration = configuration ?? Configuration.Default;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }

                return _exceptionFactory;
            }
            set => _exceptionFactory = value;
        }

        public SearchResultsResponse SearchesGetSearchResultsAdHocV1(SearchResultsRequest dataRequest)
        {
            if (dataRequest == null)
                throw new ApiException(400,
                    "Missing required parameter 'dataRequest' when calling SearchesApi->SearchesGetSearchResultsAdHocV1");

            const string localVarPath = "/api/V1/getsearchresults";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            object localVarPostBody;

            var localVarHttpContentTypes = new[]
            {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml",
                "application/x-www-form-urlencoded"
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccepts = new[]
            {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(dataRequest);
            }
            else
            {
                localVarPostBody = dataRequest;
            }


            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsAdHocV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                    typeof(SearchResultsResponse))).Data;
        }

        public SearchItemResponse SearchesGetSearchItemsByAssociationV1(string association, bool? links = null)
        {

            if (association == null)
                throw new ApiException(400,
                    "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchItemsByAssociationV1");

            const string localVarPath = "/api/V1/getsearchitems/association/{association}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            var localVarHttpContentTypes = new string[]
            {
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccepts = new[]
            {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association));
            if (links != null)
                localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "links", links));

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int) localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SearchesGetSearchItemsByAssociationV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SearchItemResponse>(localVarStatusCode,
                    localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                    (SearchItemResponse) Configuration.ApiClient.Deserialize(localVarResponse,
                        typeof(SearchItemResponse)))
                .Data;
        }

        public SearchResultsResponse SearchesGetSearchResultsByIdV1(string association, string scope, string scopeowner,
            string searchid, string searchTerm = null, int? pagenumber = null, int? pagesize = null, bool? includeschema = null,
            bool? resultsAsSimpleResultsList = null)
        {
            if (association == null)
                throw new ApiException(400, "Missing required parameter 'association' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
          
            if (scope == null)
                throw new ApiException(400, "Missing required parameter 'scope' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
           
            if (scopeowner == null)
                throw new ApiException(400, "Missing required parameter 'scopeowner' when calling SearchesApi->SearchesGetSearchResultsByIdV1");
          
            if (searchid == null)
                throw new ApiException(400, "Missing required parameter 'searchid' when calling SearchesApi->SearchesGetSearchResultsByIdV1");

            const string localVarPath = "/api/V1/getsearchresults/association/{association}/scope/{scope}/scopeowner/{scopeowner}/searchid/{searchid}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();

            var localVarHttpContentTypes = new string[] {
            };
            var localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            var localVarHttpHeaderAccepts = new[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            var localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            localVarPathParams.Add("association", Configuration.ApiClient.ParameterToString(association)); 
            localVarPathParams.Add("scope", Configuration.ApiClient.ParameterToString(scope)); 
            localVarPathParams.Add("scopeowner", Configuration.ApiClient.ParameterToString(scopeowner));
            localVarPathParams.Add("searchid", Configuration.ApiClient.ParameterToString(searchid)); 
            if (searchTerm != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchTerm", searchTerm)); 
            if (pagenumber != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagenumber", pagenumber)); 
            if (pagesize != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "pagesize", pagesize));
            if (includeschema != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "includeschema", includeschema));
            if (resultsAsSimpleResultsList != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "resultsAsSimpleResultsList", resultsAsSimpleResultsList)); 

            if (!string.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var localVarResponse = (IRestResponse)Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, null, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            var localVarStatusCode = (int)localVarResponse.StatusCode;

            var exception = ExceptionFactory?.Invoke("SearchesGetSearchResultsByIdV1", localVarResponse);
            if (exception != null) throw exception;

            return new ApiResponse<SearchResultsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SearchResultsResponse)Configuration.ApiClient.Deserialize(localVarResponse, typeof(SearchResultsResponse))).Data;
        }
    }
}