using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class FieldDefinition
    {

        [DataMember(Name = "autoFill", EmitDefaultValue = false)]
        public bool? AutoFill { get; set; }

        [DataMember(Name = "calculated", EmitDefaultValue = false)]
        public bool? Calculated { get; set; }

        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        [DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
        public int? DecimalDigits { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "details", EmitDefaultValue = false)]
        public string Details { get; set; }

        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        [DataMember(Name = "enabled", EmitDefaultValue = false)]
        public bool? Enabled { get; set; }

        [DataMember(Name = "fieldId", EmitDefaultValue = false)]
        public string FieldId { get; set; }

        [DataMember(Name = "hasDate", EmitDefaultValue = false)]
        public bool? HasDate { get; set; }

        [DataMember(Name = "hasTime", EmitDefaultValue = false)]
        public bool? HasTime { get; set; }

        [DataMember(Name = "isFullTextSearchable", EmitDefaultValue = false)]
        public bool? IsFullTextSearchable { get; set; }

        [DataMember(Name = "maximumSize", EmitDefaultValue = false)]
        public string MaximumSize { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "readOnly", EmitDefaultValue = false)]
        public bool? ReadOnly { get; set; }

        [DataMember(Name = "required", EmitDefaultValue = false)]
        public bool? Required { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        [DataMember(Name = "typeLocalized", EmitDefaultValue = false)]
        public string TypeLocalized { get; set; }

        [DataMember(Name = "validated", EmitDefaultValue = false)]
        public bool? Validated { get; set; }

        [DataMember(Name = "wholeDigits", EmitDefaultValue = false)]
        public int? WholeDigits { get; set; }
    }
}