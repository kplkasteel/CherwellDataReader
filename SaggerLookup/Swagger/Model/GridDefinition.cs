using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public  class GridDefinition 
    {

        [DataMember(Name = "gridId", EmitDefaultValue = false)]
        public string GridId { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

    }
}