using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class FieldTemplateItem
{
    [DataMember(Name = "dirty", EmitDefaultValue = false)]
    public bool? Dirty { get; set; }

    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
    public string FullFieldId { get; set; }

    [DataMember(Name = "html", EmitDefaultValue = false)]
    public string Html { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }
}