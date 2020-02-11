using SaggerLookup.Helpers;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellOneStepActionsApi
    {
        private static CherwellOneStepActionsApi _instance;
        private static OneStepActionsApi _oneStepActionsApi;

        public static CherwellOneStepActionsApi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CherwellOneStepActionsApi();
                    _oneStepActionsApi = new OneStepActionsApi(CherwellServiceApi.Instance.EndPoint);
                }
                _oneStepActionsApi = (OneStepActionsApi)CherwellApiHeaders.CheckApiHeader(_oneStepActionsApi);
                return _instance;
            }
            set => _instance = value;
        }

        public ManagerData OneStepActionsGetOneStepActionsByAssociationV1(string association, bool displayError = false)
        {
            try
            {
                return _oneStepActionsApi.OneStepActionsGetOneStepActionsByAssociationV1(association);
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

        public OneStepActionResponse OneStepActionsRunOneStepActionByStandInKeyV1(string standinkey, bool displayError = false)
        {
            try
            {
                return _oneStepActionsApi.OneStepActionsRunOneStepActionByStandInKeyV1(standinkey);
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

        public OneStepActionResponse OneStepActionsRunOneStepActionV1(OneStepActionRequest request, bool displayError = false)
        {
            try
            {
                return _oneStepActionsApi.OneStepActionsRunOneStepActionV1(request);
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