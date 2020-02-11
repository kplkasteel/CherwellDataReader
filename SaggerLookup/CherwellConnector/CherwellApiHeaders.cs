using System.Linq;
using SaggerLookup.Enum;
using SaggerLookup.Models;
using SaggerLookup.Swagger.Client;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellApiHeaders
    {
        private static ServiceTokenStatus CheckTokenResponse()
        {
            return CherwellServiceApi.Instance.CheckTokenResponse(false);
        }

        public static IApiAccessor CheckApiHeader(IApiAccessor businessObjectApi)
        {
            var tokenStatus = CheckTokenResponse();
            if (tokenStatus == ServiceTokenStatus.Failed) return null;
            if (!businessObjectApi.Configuration.DefaultHeader.Any() || tokenStatus == ServiceTokenStatus.Renewed) // Add header if needed
            {
                businessObjectApi.Configuration.AddDefaultHeader("Authorization",
                    "Bearer " + StaticData.ActiveToken.AccessToken);
            }
            return businessObjectApi;
        }
    }
}