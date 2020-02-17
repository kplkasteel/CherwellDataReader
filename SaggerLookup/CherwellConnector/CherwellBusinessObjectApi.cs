using System.Collections.Generic;
using System.Linq;
using Mobile1;
using SaggerLookup.Helpers;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellBusinessObjectApi
    {
        private static CherwellBusinessObjectApi _instance = null;
        private static IBusinessObjectApi _businessObjectApi;

        public static CherwellBusinessObjectApi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CherwellBusinessObjectApi();
                    _businessObjectApi = new BusinessObjectApi(CherwellServiceApi.Instance.EndPoint);
                }
                
                _businessObjectApi = (BusinessObjectApi)CherwellApiHeaders.CheckApiHeader(_businessObjectApi);
                return _instance;
            }
            set => _instance = value;
        }


        public List<Summary> BusinessObjectGetBusinessObjectSummariesV1(string type, bool displayError = false)
        {
            try
            {
                return _businessObjectApi.BusinessObjectGetBusinessObjectSummariesV1(type);
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

        public TemplateResponse BusinessObjectGetBusinessObjectTemplateV1(TemplateRequest templateRequest, bool displayError = false)
        {
            try
            {
                return _businessObjectApi.BusinessObjectGetBusinessObjectTemplateV1(templateRequest);
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

        public SchemaResponse BusinessObjectGetBusinessObjectSchemaV1(string busObId, bool includeRelationShips = true, bool displayError = false)
        {
            try
            {
                return _businessObjectApi.BusinessObjectGetBusinessObjectSchemaV1(busObId, includeRelationShips);
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

        public SaveResponse BusinessObjectSaveBusinessObjectV1(SaveRequest saveRequest, bool displayError = false)
        {
            try
            {
                saveRequest.Fields = saveRequest.Fields.Where(field => field.Dirty != false).ToList();
                return _businessObjectApi
                    .BusinessObjectSaveBusinessObjectV1
                        (saveRequest);
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

        public string BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1(byte[] body, string filename, string busObId, string busObRecId, int? offset = null, int? totalSize = null, string attachmentId = null, string displayText = null, bool displayError = false, bool writeError = false)
        {
            try
            {
                return _businessObjectApi
                    .BusinessObjectUploadBusinessObjectAttachmentByIdAndRecIdV1(body, filename, busObId, busObRecId,
                        offset, totalSize, attachmentId, displayText);
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

        public RelatedSaveResponse BusinessObjectSaveRelatedBusinessObjectV1(RelatedSaveRequest relatedSaveRequest, bool displayError = false)
        {
            try
            {
                relatedSaveRequest.Fields = relatedSaveRequest.Fields.Where(field => field.Dirty != false).ToList();
                return _businessObjectApi
                    .BusinessObjectSaveRelatedBusinessObjectV1
                        (relatedSaveRequest);
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

        public ReadResponse BusinessObjectGetBusinessObjectByRecIdV1(string busObId, string busObRecId, bool displayError = false)
        {
            try
            {
                return _businessObjectApi
                    .BusinessObjectGetBusinessObjectByRecIdV1(busObId,
                        busObRecId);
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.DisplayMessage(apiException);
                }
            }
            return null;
        }

        public Summary BusinessObjectGetBusinessObjectSummaryByNameV1(string busobname, bool displayError = false)
        {
            try
            {
                var result = _businessObjectApi
                    .BusinessObjectGetBusinessObjectSummaryByNameV1(busobname);
                return result.Any() ? result[0] : null;
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.DisplayMessage(apiException);
                }
            }
            return null;
        }
        

        public static TemplateRequest CreateTemplateRequest(string summaryId, bool includeAll = true, bool includeRequired = true)
        {
            return new TemplateRequest
            {
                BusObId = summaryId,
                IncludeAll = includeAll,
                IncludeRequired = includeRequired
            };
        }
        public static SaveRequest CreateSaveRequest(ReadResponse readResponse, [CanBeNull] string cacheKey, SaveRequest.CacheScopeEnum? cacheScope, bool persist = true)
        {
            return new SaveRequest
            {
                BusObRecId = readResponse.BusObRecId,
                BusObId = readResponse.BusObId,
                BusObPublicId = readResponse.BusObPublicId,
                CacheKey = cacheKey,
                CacheScope = cacheScope,
                Fields = readResponse.Fields,
                Persist = persist,
            };
        }


       
    }
}