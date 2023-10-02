using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class QuickSearchConfigSavedRequest
{
    [DataMember(Name = "standIn", EmitDefaultValue = false)]
    public string StandIn { get; set; }

    [DataMember(Name = "busObIds", EmitDefaultValue = false)]
    public List<string> BusObIds { get; set; }

    [DataMember(Name = "isGeneral", EmitDefaultValue = false)]
    public bool? IsGeneral { get; set; }
}