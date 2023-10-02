using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model
{
    [DataContract]
    public class AddItemToQueueRequest
    {
        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

        [DataMember(Name = "queueStandInKey", EmitDefaultValue = false)]
        public string QueueStandInKey { get; set; }
    }
}