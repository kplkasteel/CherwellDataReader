using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class BusObsForViewResponse
{
    [DataMember(Name = "summaries", EmitDefaultValue = false)]
    public List<ViewSummary> Summaries { get; set; }
}