using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ViewSummary
{
    [DataMember(Name = "groupSummaries", EmitDefaultValue = false)]
    public List<ViewSummary> GroupSummaries { get; set; }

    [DataMember(Name = "image", EmitDefaultValue = false)]
    public string Image { get; set; }

    [DataMember(Name = "isPartOfView", EmitDefaultValue = false)]
    public bool? IsPartOfView { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(Name = "group", EmitDefaultValue = false)]
    public bool? Group { get; set; }

    [DataMember(Name = "lookup", EmitDefaultValue = false)]
    public bool? Lookup { get; set; }

    [DataMember(Name = "major", EmitDefaultValue = false)]
    public bool? Major { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "supporting", EmitDefaultValue = false)]
    public bool? Supporting { get; set; }
}