using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class TransitionOptionsResponseTransition
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "isAvailable", EmitDefaultValue = false)]
    public bool? IsAvailable { get; set; }

    [DataMember(Name = "criteria", EmitDefaultValue = false)]
    public List<string> Criteria { get; set; }
}