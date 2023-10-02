using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SectionField
{
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public List<object> Attributes { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "fieldType", EmitDefaultValue = false)]
    public string FieldType { get; set; }

    [DataMember(Name = "label", EmitDefaultValue = false)]
    public string Label { get; set; }

    [DataMember(Name = "multiline", EmitDefaultValue = false)]
    public bool? Multiline { get; set; }

    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }
}