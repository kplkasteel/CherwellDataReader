using System.Collections.Generic;
using System.Linq;
using Mobile1;
using SaggerLookup.Helpers;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellSearchesApi
    {
        private static CherwellSearchesApi _instance;
        private static ISearchesApi _searchesApi;

        public static CherwellSearchesApi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CherwellSearchesApi();
                    _searchesApi = new SearchesApi(CherwellServiceApi.Instance.EndPoint);
                }
                _searchesApi = (SearchesApi)CherwellApiHeaders.CheckApiHeader(_searchesApi);
                return _instance;
            }
            set => _instance = value;
        }

        public SearchResultsResponse SearchesGetSearchResultsAdHocV1(SearchResultsRequest searchResultsRequest, bool displayError = false)
        {
            try
            {
                
                return _searchesApi.SearchesGetSearchResultsAdHocV1(searchResultsRequest);
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.DisplayMessage(apiException);
                }
                return null;
            }
        }

        public SearchItemResponse SearchesGetSearchItemsByAssociationV1(string association, bool displayError = false)
        {
            try
            {
                return  _searchesApi.SearchesGetSearchItemsByAssociationV1(association);
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.DisplayMessage(apiException);
                }
                return null;
            }
        }

        public SearchResultsResponse SearchesGetSearchResultsByIdV1(string association, string scope, string scopeOwner, string searchId, bool displayError, bool writeError)
        {
            try
            {
                return _searchesApi
                    .SearchesGetSearchResultsByIdV1(association, scope, scopeOwner, searchId, null, null, 500000);
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.DisplayMessage(apiException);
                }
                return null;
            }
        }

        public static SearchResultsRequest CreateNewDataRequest(string busObId, [CanBeNull]List<FilterInfo> filterInfoList, bool includeAllFields = false, bool includeSchema = false)
        {
            if (filterInfoList == null) filterInfoList = new List<FilterInfo>();
            return new SearchResultsRequest
            {
                BusObId = busObId,
                Filters = filterInfoList,
                IncludeAllFields = includeAllFields,
                IncludeSchema = includeSchema
            };
        }

        public static List<FilterInfo> CreateFilterInfo(SchemaResponse schemaResponse, IEnumerable<ReadResponse> readResponseList, string[] exclusionList, string fieldNameSchema, string fieldNameValue)
        {
            return readResponseList
                .Where(readResponse => !exclusionList.Contains(readResponse.Fields.Find(x => x.Name == fieldNameValue).Value))
                .Select(readResponse => new FilterInfo
                {
                    FieldId = schemaResponse.FieldDefinitions.Find(x => x.Name == fieldNameSchema).FieldId,
                    Operator = "eq",
                    Value = readResponse.Fields.Find(x => x.Name == fieldNameValue).Value
                }).ToList();
        }
    }
}