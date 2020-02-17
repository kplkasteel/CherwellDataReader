
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class SearchFolder
    {
        
        [DataMember(Name="association", EmitDefaultValue=false)]
        public string Association { get; set; }

        [DataMember(Name="childFolders", EmitDefaultValue=false)]
        public List<SearchFolder> ChildFolders { get; set; }

        [DataMember(Name="childItems", EmitDefaultValue=false)]
        public List<SearchItem> ChildItems { get; set; }

        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public string FolderId { get; set; }

        [DataMember(Name="folderName", EmitDefaultValue=false)]
        public string FolderName { get; set; }

        [DataMember(Name="localizedScopeName", EmitDefaultValue=false)]
        public string LocalizedScopeName { get; set; }

        [DataMember(Name="parentFolderId", EmitDefaultValue=false)]
        public string ParentFolderId { get; set; }

        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }

    }

}
