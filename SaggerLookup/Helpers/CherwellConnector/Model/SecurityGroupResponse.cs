using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SecurityGroupResponse
{
    [DataMember(Name = "securityGroups", EmitDefaultValue = false)]
    public List<SecurityGroup> SecurityGroups { get; set; }
}