using SaggerLookup.Helpers;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellCoreApi
    {
        private static CherwellCoreApi _instance;
        private static ICoreApi _coreApi;

        public static CherwellCoreApi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CherwellCoreApi();
                    _coreApi = new CoreApi(CherwellServiceApi.Instance.EndPoint);
                }
                _coreApi = (CoreApi)CherwellApiHeaders.CheckApiHeader(_coreApi);
                return _instance;
            }
            set => _instance = value;
        }

        public byte[] CoreGetGalleryImageV1(string name, int? width, int? height, bool displayError = false)
        {
            try
            {
                return _coreApi.CoreGetGalleryImageV1(name, width, height);
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

        public SaveGalleryImageResponse CoreSaveGalleryImageV1(SaveGalleryImageRequest saveApiClientSettingRequest, bool displayError = false)
        {
            try
            {
                return _coreApi.CoreSaveGalleryImageV1(saveApiClientSettingRequest);
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
    }
}