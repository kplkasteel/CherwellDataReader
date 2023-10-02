using System.Collections.Generic;
using Newtonsoft.Json;
using SwaggerLookup.Helpers.CherwellConnector.Model;

namespace SwaggerLookup.Models
{
    public class UserInfo
    {
        private List<Team> _teams;

        public string BusObRecId { get; set; }
        public string BusObId { get; set; }
        public string BusObPublicId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string DefaultTeamName { get; set; }
        public string DefaultTeamID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string LastModifiedDateTime { get; set; }
        public byte[] AvatarBytes { get; set; }
       
        public List<Team> Teams
        {
            get =>
                _teams ?? (_teams = !string.IsNullOrEmpty(TeamString)
                    ? JsonConvert.DeserializeObject<List<Team>>(TeamString)
                    : new List<Team>());
            set => _teams = value;
        }

        [JsonIgnore]
        public string TeamString
        {
            get => _teams != null ? JsonConvert.SerializeObject(_teams) : string.Empty;
            set => _teams = !string.IsNullOrEmpty(value)
                ? JsonConvert.DeserializeObject<List<Team>>(value)
                : new List<Team>();
        }

    }
}