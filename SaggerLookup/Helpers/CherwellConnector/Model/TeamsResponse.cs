using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class TeamsResponse
{
    [DataMember(Name = "error", EmitDefaultValue = false)]
    public string Error { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }

    [DataMember(Name = "teams", EmitDefaultValue = false)]
    public List<Team> Teams { get; set; }
}