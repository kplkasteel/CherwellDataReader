using System;
using System.Linq;
using SaggerLookup.Enum;
using SaggerLookup.Helpers;
using SaggerLookup.Models;
using SaggerLookup.Properties;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellServiceApi
    {
        private static IServiceApi _serviceApi;
        private static CherwellServiceApi _cherwellServiceApi;
        private static string _password;
        private static string _userName;
        private static string _clientId;
        private static string _endPoint;
        private AuthModes _authMode;

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }

        public string ClientId
        {
            get => _clientId;
            set => _clientId = value;
        }

        public string EndPoint
        {
            get => _endPoint;
            set => _endPoint = value;
        }


        public AuthModes AuthMode
        {
            get => _authMode;
            set => _authMode = value;
        }

        public IServiceApi ServiceApi
        {
            get => _serviceApi;
            set { _serviceApi = value; }
        }


        public static CherwellServiceApi Instance
        {
            get
            {
                if (_cherwellServiceApi != null) return _cherwellServiceApi;
                _cherwellServiceApi = new CherwellServiceApi();


                return _cherwellServiceApi;
            }
            set => _cherwellServiceApi = value;
        }

        /// <summary>
        /// Gets a new Cherwell ServiceToken
        /// </summary>
        /// <remarks>
        /// set displayError to  TRUE display an error message on the screen
        /// </remarks>
        /// <returns>Task of TokenResponse</returns>
        public TokenResponse GetServiceToken(bool displayError)
        {
            try
            {
                if (string.IsNullOrEmpty(ClientId) || string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(Password)) return null;
                var tokenResponse = _serviceApi
                    .ServiceToken(GrantTypes.password.ToString(), ClientId, null, UserName, Password, null, AuthMode.ToString());
                return tokenResponse;
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.LoginErrorMessage(apiException);
                }
                return null;
            }
        }

        /// <summary>
        /// Gets a new Cherwell ServiceToken
        /// </summary>
        /// <remarks>
        /// set displayError to  TRUE display an error message on the screen
        /// </remarks>
        /// <param name="displayError"></param>
        /// <returns>Task of TokenResponse</returns>
        public TokenResponse RefreshServiceToken(bool displayError)
        {
            try
            {
                return _serviceApi.ServiceToken(GrantTypes.refresh_token.ToString(),
                    ClientId, null, UserName, Password, StaticData.ActiveToken.RefreshToken, AuthMode.ToString());
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.ErrorMessage(apiException);
                }
                return null;
            }
        }

        /// <summary>
        /// Logs out the user and clear Settings.TokenResponse
        /// </summary>
        /// <param name="displayError"></param>
        public void ServiceLogoutUserV1(bool displayError)
        {
            try
            {
                if (!_serviceApi.Configuration.DefaultHeader.Any() && StaticData.ActiveToken != null)
                    _serviceApi.Configuration?.AddDefaultHeader("Authorization",
                        "Bearer " + StaticData.ActiveToken.AccessToken);
                _serviceApi?.ServiceLogoutUserV1();
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.ErrorMessage(apiException);
                }
            }   
            StaticData.ActiveToken = null;
            CherwellBusinessObjectApi.Instance = null;
            CherwellCoreApi.Instance = null;
            CherwellSearchesApi.Instance = null;
            CherwellSecurityApi.Instance = null;
            CherwellTeamsApi.Instance = null;
            CherwellUsersApi.Instance = null;
        }

        public ServiceInfoResponse ServiceGetServiceInfoV1(bool displayError)
        {
            try
            {
                return _serviceApi.ServiceGetServiceInfoV1();
            }
            catch (ApiException apiException)
            {
                if (displayError)
                {
                    Display.ErrorMessage(apiException);
                }
            }
            return new ServiceInfoResponse();
           
        }

        public ServiceTokenStatus CheckTokenResponse(bool displayMessage)
        {
            TokenResponse tokenResponse;
            if (StaticData.ActiveToken == null || string.IsNullOrEmpty(StaticData.ActiveToken.AccessToken))
            {
                tokenResponse = Instance.GetServiceToken(
                    displayMessage);
                if (tokenResponse == null) return ServiceTokenStatus.Failed;
                StaticData.ActiveToken = tokenResponse;
                return ServiceTokenStatus.Renewed;
            }

            var expires = DateTime.Parse(StaticData.ActiveToken.Expires).AddMinutes(-5);
            var currentTime = DateTime.Now;

            if (expires >= currentTime) return ServiceTokenStatus.Success;

            tokenResponse = RefreshServiceToken(displayMessage) ?? GetServiceToken(true);
            StaticData.ActiveToken = tokenResponse;
            return tokenResponse == null ? ServiceTokenStatus.Failed : ServiceTokenStatus.Renewed;
        }
    }
}