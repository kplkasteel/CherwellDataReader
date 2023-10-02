using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class OneStepActionRequest
{
    [DataMember(Name = "acquireLicense", EmitDefaultValue = false)]
    public bool? AcquireLicense { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "oneStepActionStandInKey", EmitDefaultValue = false)]
    public string OneStepActionStandInKey { get; set; }

    [DataMember(Name = "promptValues", EmitDefaultValue = false)]
    public List<SimplePromptValue> PromptValues { get; set; }
}