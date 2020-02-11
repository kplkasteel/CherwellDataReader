using SaggerLookup.Helpers;
using SaggerLookup.Swagger.Api;
using SaggerLookup.Swagger.Client;
using SaggerLookup.Swagger.Model;

namespace SaggerLookup.CherwellConnector
{
    public class CherwellTeamsApi
    {
        private static CherwellTeamsApi _instance;
        private static ITeamsApi _teamsApi;

        public static CherwellTeamsApi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CherwellTeamsApi();
                    _teamsApi = new TeamsApi(CherwellServiceApi.Instance.EndPoint);
                }
               
                _teamsApi = (TeamsApi)CherwellApiHeaders.CheckApiHeader(_teamsApi);
                return _instance;
            }
            set => _instance = value;
        }

        public TeamsV2Response TeamsGetUsersTeamsV2(string userRecordId, bool displayError = false)
        {
            try
            {
                return _teamsApi.TeamsGetUsersTeamsV2(userRecordId);
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

        public TeamsV2Response TeamsGetTeamsV2Async(bool displayError = false)
        {
            try
            {
                return _teamsApi.TeamsGetTeamsV2();
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

        public TeamsV2Response TeamsGetWorkgroupsV2(bool displayError = false)
        {
            try
            {
                return _teamsApi.TeamsGetWorkgroupsV2();
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

        public SaveTeamMemberResponse TeamsSaveTeamMemberV1Async(SaveTeamMemberRequest saveTeamMemberRequest, bool displayError = false)
        {
            try
            {
                return _teamsApi.TeamsSaveTeamMemberV1(saveTeamMemberRequest);
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

        public static SaveTeamMemberRequest CreateAddUserToTeamRequest(string busObRecId, string teamId, bool isTeamManager, bool setAsDefaultTeam
            )
        {
            return new SaveTeamMemberRequest
            {
                IsTeamManager = isTeamManager,
                SetAsDefaultTeam = setAsDefaultTeam,
                UserRecId = busObRecId,
                TeamId = teamId
            };
        }
    }
}