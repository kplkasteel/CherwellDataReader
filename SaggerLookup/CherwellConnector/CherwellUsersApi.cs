using System.Linq;
using SaggerLookup.Enum;
using SaggerLookup.Helpers;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellUsersApi
    {
        private static CherwellUsersApi _instance;
        private static IUsersApi _usersApi;

        public static CherwellUsersApi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CherwellUsersApi();
                    _usersApi = new UsersApi(CherwellServiceApi.Instance.EndPoint);
                }
                _usersApi = (UsersApi)CherwellApiHeaders.CheckApiHeader(_usersApi);

                return _instance;
            }
            set => _instance = value;
        }

        public UserV2 UsersGetUserByLoginIdV3(string loginId, AuthModes loginType,
            bool displayError = false)
        {
            try
            {
                return _usersApi.UsersGetUserByLoginIdV3(loginId, loginType.ToString());
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

        public UserSaveV2Response UsersSaveUserV2(UserSaveV2Request userSaveV2Request, bool displayError = false, bool writeError = false)
        {
            try
            {
                userSaveV2Request.UserInfoFields = userSaveV2Request.UserInfoFields.Where(field => field.Dirty != false).ToList();
                return _usersApi.UsersSaveUserV2(userSaveV2Request);
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

        public static UserSaveV2Request CreateUserSaveV2Request(UserV2 activeUser, string busObId, string password)
        {
            var result = new UserSaveV2Request
            {
                BusObId = busObId,
                DisplayName = activeUser.DisplayName,
                LoginId = activeUser.UserName,
                Password = password,
                SecurityGroupId = activeUser.SecurityGroupId,
                UserInfoFields = activeUser.Fields,
                AccountLocked = false,
                AllCultures = false,
                BusObRecId = activeUser.RecordId,
                BusObPublicId = activeUser.PublicId,
                PasswordNeverExpires = false,
                UserMustChangePasswordAtNextLogin = false,
                NextPasswordResetDate = null,
                UserCannotChangePassword = false,
                LdapRequired = null,
            };
            return result;
        }
    }
}