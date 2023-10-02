using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class StatusesResponseStatuses
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "isInitial", EmitDefaultValue = false)]
    public bool? IsInitial { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "stageId", EmitDefaultValue = false)]
    public string StageId { get; set; }
}