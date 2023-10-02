using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class PromptValue
{
    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
    public string CollectionStoreEntireRow { get; set; }

    [DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
    public string CollectionValueField { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
    public string ListReturnFieldId { get; set; }

    [DataMember(Name = "promptId", EmitDefaultValue = false)]
    public string PromptId { get; set; }

    [DataMember(Name = "value", EmitDefaultValue = false)]
    public object Value { get; set; }

    [DataMember(Name = "valueIsRecId", EmitDefaultValue = false)]
    public bool? ValueIsRecId { get; set; }
}