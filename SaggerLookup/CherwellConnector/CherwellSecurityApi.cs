using SaggerLookup.Helpers;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellSecurityApi
    {
        private static CherwellSecurityApi _instance;
        private static ISecurityApi _securityApi;

        public static CherwellSecurityApi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CherwellSecurityApi();
                    _securityApi = new SecurityApi(CherwellServiceApi.Instance.EndPoint);
                }
                _securityApi = (SecurityApi)CherwellApiHeaders.CheckApiHeader(_securityApi);
                return _instance;
            }
            set => _instance = value;
        }

        public SecurityGroupV2Response UsersGetListOfUsers(
            bool displayError = false)
        {
            try
            {
                return _securityApi.SecurityGetSecurityGroupsV2();
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