using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchesSearchItem
{
    [DataMember(Name = "association", EmitDefaultValue = false)]
    public string Association { get; set; }

    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links { get; set; }

    [DataMember(Name = "localizedScopeName", EmitDefaultValue = false)]
    public string LocalizedScopeName { get; set; }

    [DataMember(Name = "parentFolderId", EmitDefaultValue = false)]
    public string ParentFolderId { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public string Scope { get; set; }

    [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
    public string ScopeOwner { get; set; }

    [DataMember(Name = "searchId", EmitDefaultValue = false)]
    public string SearchId { get; set; }

    [DataMember(Name = "searchName", EmitDefaultValue = false)]
    public string SearchName { get; set; }
}