using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class FieldValuesLookupRequest : BaseFieldTemplateItem
{
    [DataMember(Name = "busbPublicId", EmitDefaultValue = false)]
    public string BusbPublicId { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "fieldName", EmitDefaultValue = false)]
    public string FieldName { get; set; }
}