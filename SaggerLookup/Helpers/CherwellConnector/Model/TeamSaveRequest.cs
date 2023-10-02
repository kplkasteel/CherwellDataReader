using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class TeamSaveRequest
{
    [DataMember(Name = "teamType", EmitDefaultValue = false)]
    public TeamTypeEnum? TeamType { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "emailAlias", EmitDefaultValue = false)]
    public string EmailAlias { get; set; }

    [DataMember(Name = "image", EmitDefaultValue = false)]
    public string Image { get; set; }

    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }

    [DataMember(Name = "teamName", EmitDefaultValue = false)]
    public string TeamName { get; set; }
}