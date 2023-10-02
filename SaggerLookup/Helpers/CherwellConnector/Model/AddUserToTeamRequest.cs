using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class AddUserToTeamRequest
{
    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }

    [DataMember(Name = "userIsTeamManager", EmitDefaultValue = false)]
    public bool? UserIsTeamManager { get; set; }

    [DataMember(Name = "userRecordId", EmitDefaultValue = false)]
    public string UserRecordId { get; set; }
}