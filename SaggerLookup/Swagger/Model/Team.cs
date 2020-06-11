using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class Team
    {
        
        [DataMember(Name="teamId", EmitDefaultValue=false)]
        public string TeamId { get; set; }

        [DataMember(Name="teamName", EmitDefaultValue=false)]
        public string TeamName { get; set; }

        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

    }

}
