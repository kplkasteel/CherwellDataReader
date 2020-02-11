using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class NameValuePair 
    {
        
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        [DataMember(Name="valueObject", EmitDefaultValue=false)]
        public SystemObject ValueObject { get; set; }

        [DataMember(Name="valueString", EmitDefaultValue=false)]
        public string ValueString { get; set; }

        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; set; }

        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        [DataMember(Name="displayShowsValue", EmitDefaultValue=false)]
        public bool? DisplayShowsValue { get; set; }

        [DataMember(Name="specialUseFlag", EmitDefaultValue=false)]
        public bool? SpecialUseFlag { get; set; }
        [DataMember(Name="displayString", EmitDefaultValue=false)]
        public string DisplayString { get; set; }
    }

}
