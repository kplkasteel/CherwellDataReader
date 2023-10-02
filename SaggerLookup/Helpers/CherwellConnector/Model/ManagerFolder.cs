using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ManagerFolder
{
    [DataMember(Name = "association", EmitDefaultValue = false)]
    public string Association { get; set; }

    [DataMember(Name = "childFolders", EmitDefaultValue = false)]
    public List<ManagerFolder> ChildFolders { get; set; }

    [DataMember(Name = "childItems", EmitDefaultValue = false)]
    public List<ManagerItem> ChildItems { get; set; }

    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links { get; set; }

    [DataMember(Name = "localizedScopeName", EmitDefaultValue = false)]
    public string LocalizedScopeName { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "parentId", EmitDefaultValue = false)]
    public string ParentId { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public string Scope { get; set; }

    [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
    public string ScopeOwner { get; set; }
}