using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SaveTeamMemberRequest
{
    [DataMember(Name = "isTeamManager", EmitDefaultValue = false)]
    public bool? IsTeamManager { get; set; }

    [DataMember(Name = "setAsDefaultTeam", EmitDefaultValue = false)]
    public bool? SetAsDefaultTeam { get; set; }

    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }

    [DataMember(Name = "userRecId", EmitDefaultValue = false)]
    public string UserRecId { get; set; }
}