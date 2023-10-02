using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class TransitionsResponseTransition
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "fromStatusId", EmitDefaultValue = false)]
    public string FromStatusId { get; set; }

    [DataMember(Name = "toStatusId", EmitDefaultValue = false)]
    public string ToStatusId { get; set; }
}