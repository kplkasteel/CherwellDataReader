using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchesSearchFolder
{
    [DataMember(Name = "association", EmitDefaultValue = false)]
    public string Association { get; set; }

    [DataMember(Name = "childFolders", EmitDefaultValue = false)]
    public List<SearchesSearchFolder> ChildFolders { get; set; }

    [DataMember(Name = "childItems", EmitDefaultValue = false)]
    public List<SearchesSearchItem> ChildItems { get; set; }

    [DataMember(Name = "folderId", EmitDefaultValue = false)]
    public string FolderId { get; set; }

    [DataMember(Name = "folderName", EmitDefaultValue = false)]
    public string FolderName { get; set; }

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
}