using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SortInfo
{
    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
    public int? SortDirection { get; set; }
}