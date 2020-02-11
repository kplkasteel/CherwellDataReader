using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class Relationship
    {

        [DataMember(Name = "cardinality", EmitDefaultValue = false)]
        public string Cardinality { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        [DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
        public List<FieldDefinition> FieldDefinitions { get; set; }

        [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
        public string RelationshipId { get; set; }

        [DataMember(Name = "target", EmitDefaultValue = false)]
        public string Target { get; set; }
    }
}