using System.Collections.Generic;
using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class Prompt
{
    [DataMember(Name = "listDisplayOption", EmitDefaultValue = false)]
    public ListDisplayOptionEnum? ListDisplayOption { get; set; }

    [DataMember(Name = "promptType", EmitDefaultValue = false)]
    public PromptTypeEnum? PromptType { get; set; }

    [DataMember(Name = "allowValuesOnly", EmitDefaultValue = false)]
    public bool? AllowValuesOnly { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "collectionStoreEntireRow", EmitDefaultValue = false)]
    public string CollectionStoreEntireRow { get; set; }

    [DataMember(Name = "collectionValueField", EmitDefaultValue = false)]
    public string CollectionValueField { get; set; }

    [DataMember(Name = "constraintXml", EmitDefaultValue = false)]
    public string ConstraintXml { get; set; }

    [DataMember(Name = "contents", EmitDefaultValue = false)]
    public string Contents { get; set; }

    [DataMember(Name = "default", EmitDefaultValue = false)]
    public string Default { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "isDateRange", EmitDefaultValue = false)]
    public bool? IsDateRange { get; set; }

    [DataMember(Name = "listReturnFieldId", EmitDefaultValue = false)]
    public string ListReturnFieldId { get; set; }

    [DataMember(Name = "multiLine", EmitDefaultValue = false)]
    public bool? MultiLine { get; set; }

    [DataMember(Name = "promptId", EmitDefaultValue = false)]
    public string PromptId { get; set; }

    [DataMember(Name = "promptTypeName", EmitDefaultValue = false)]
    public string PromptTypeName { get; set; }

    [DataMember(Name = "required", EmitDefaultValue = false)]
    public bool? Required { get; set; }

    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }

    [DataMember(Name = "value", EmitDefaultValue = false)]
    public object Value { get; set; }

    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<string> Values { get; set; }
}