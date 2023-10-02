using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ApprovalReadResponse
{
    [DataMember(Name = "properties", EmitDefaultValue = false)]
    public Dictionary<string, object> Properties { get; set; }

    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}