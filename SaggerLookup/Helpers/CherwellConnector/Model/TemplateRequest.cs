using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class TemplateRequest
{
    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "fieldNames", EmitDefaultValue = false)]
    public List<string> FieldNames { get; set; }

    [DataMember(Name = "fieldIds", EmitDefaultValue = false)]
    public List<string> FieldIds { get; set; }

    [DataMember(Name = "includeAll", EmitDefaultValue = false)]
    public bool? IncludeAll { get; set; }

    [DataMember(Name = "includeRequired", EmitDefaultValue = false)]
    public bool? IncludeRequired { get; set; }
}