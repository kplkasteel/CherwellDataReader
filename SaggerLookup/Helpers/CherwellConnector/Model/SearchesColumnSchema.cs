using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchesColumnSchema
{
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }
}