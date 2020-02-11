using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using SQLite;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]

    public class SearchFolder
    {
        private List<SearchFolder> _childFolders;

        private List<SearchItem> _childItems;

        [DataMember(Name="association", EmitDefaultValue=false), PrimaryKey]
        public string Association { get; set; }

        [DataMember(Name="childFolders", EmitDefaultValue=false), Ignore]
        public List<SearchFolder> ChildFolders {
            get =>
                _childFolders ?? (_childFolders = !string.IsNullOrEmpty(ChildFolderString)
                    ? JsonConvert.DeserializeObject<List<SearchFolder>>(ChildFolderString)
                    : new List<SearchFolder>());
            set => _childFolders = value;
        }
            
        public string ChildFolderString
        {
            get => _childFolders != null ? JsonConvert.SerializeObject(_childFolders) : string.Empty;
            set => _childFolders = !string.IsNullOrEmpty(value)
                ? JsonConvert.DeserializeObject<List<SearchFolder>>(value)
                : new List<SearchFolder>();
        }
       [DataMember(Name="childItems", EmitDefaultValue=false), Ignore]
        public List<SearchItem> ChildItems
        {
            get =>
                _childItems ?? (_childItems = !string.IsNullOrEmpty(ChildItemString)
                    ? JsonConvert.DeserializeObject<List<SearchItem>>(ChildItemString)
                    : new List<SearchItem>());
            set => _childItems = value;
        }
    
        public string ChildItemString
        {
            get => _childItems != null ? JsonConvert.SerializeObject(_childFolders) : string.Empty;
            set => _childItems = !string.IsNullOrEmpty(value)
                ? JsonConvert.DeserializeObject<List<SearchItem>>(value)
                : new List<SearchItem>();
        }

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
