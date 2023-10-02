using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class QuickSearchConfigurationRequest
{
    [DataMember(Name = "busObIds", EmitDefaultValue = false)]
    public List<string> BusObIds { get; set; }
}