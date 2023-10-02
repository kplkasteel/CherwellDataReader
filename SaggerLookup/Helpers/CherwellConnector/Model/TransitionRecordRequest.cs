using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class TransitionRecordRequest
{
    [DataMember(Name = "transitionOptionId", EmitDefaultValue = false)]
    public string TransitionOptionId { get; set; }
}