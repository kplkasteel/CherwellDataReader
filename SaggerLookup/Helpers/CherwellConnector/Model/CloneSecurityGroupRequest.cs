using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class CloneSecurityGroupRequest
{
    [DataMember(Name = "securityGroupName", EmitDefaultValue = false)]
    public string SecurityGroupName { get; set; }

    [DataMember(Name = "sourceSecurityGroupNameOrId", EmitDefaultValue = false)]
    public string SourceSecurityGroupNameOrId { get; set; }
}