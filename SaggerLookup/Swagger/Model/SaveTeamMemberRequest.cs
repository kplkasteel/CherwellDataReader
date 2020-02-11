using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
    /// <summary>
    /// SaveTeamMemberRequest
    /// </summary>
    [DataContract]
    public class SaveTeamMemberRequest 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTeamMemberRequest" /> class.
        /// </summary>
        /// <param name="isTeamManager">isTeamManager.</param>
        /// <param name="setAsDefaultTeam">setAsDefaultTeam.</param>
        /// <param name="teamId">teamId.</param>
        /// <param name="userRecId">userRecId.</param>
        public SaveTeamMemberRequest(bool? isTeamManager = default, bool? setAsDefaultTeam = default, string teamId = default, string userRecId = default)
        {
            IsTeamManager = isTeamManager;
            SetAsDefaultTeam = setAsDefaultTeam;
            TeamId = teamId;
            UserRecId = userRecId;
        }

        /// <summary>
        /// Gets or Sets IsTeamManager
        /// </summary>
        [DataMember(Name = "isTeamManager", EmitDefaultValue = false)]
        public bool? IsTeamManager { get; set; }

        /// <summary>
        /// Gets or Sets SetAsDefaultTeam
        /// </summary>
        [DataMember(Name = "setAsDefaultTeam", EmitDefaultValue = false)]
        public bool? SetAsDefaultTeam { get; set; }

        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name = "teamId", EmitDefaultValue = false)]
        public string TeamId { get; set; }

        /// <summary>
        /// Gets or Sets UserRecId
        /// </summary>
        [DataMember(Name = "userRecId", EmitDefaultValue = false)]
        public string UserRecId { get; set; }
    }
}