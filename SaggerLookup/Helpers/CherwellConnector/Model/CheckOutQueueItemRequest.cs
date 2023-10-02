using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class CheckOutQueueItemRequest
{
    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "historyNotes", EmitDefaultValue = false)]
    public string HistoryNotes { get; set; }

    [DataMember(Name = "queueStandInKey", EmitDefaultValue = false)]
    public string QueueStandInKey { get; set; }
}