using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class NotificationTrigger
    {

        [DataMember(Name = "sourceType", EmitDefaultValue = false)]
        public string SourceType { get; set; }

        [DataMember(Name = "sourceId", EmitDefaultValue = false)]
        public string SourceId { get; set; }

        [DataMember(Name = "sourceChange", EmitDefaultValue = false)]
        public string SourceChange { get; set; }

        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

    }
}