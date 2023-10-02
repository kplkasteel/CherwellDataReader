using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class QuickSearchRequest
{
    [DataMember(Name = "busObIds", EmitDefaultValue = false)]
    public List<string> BusObIds { get; set; }

    [DataMember(Name = "searchText", EmitDefaultValue = false)]
    public string SearchText { get; set; }
}