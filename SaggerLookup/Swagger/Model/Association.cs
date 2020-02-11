using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class Association
    {
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        [DataMember(Name = "busObName", EmitDefaultValue = false)]
        public string BusObName { get; set; }

    }
}