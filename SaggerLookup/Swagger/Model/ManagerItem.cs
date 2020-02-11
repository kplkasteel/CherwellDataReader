using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public  class ManagerItem
    {

        [DataMember(Name = "association", EmitDefaultValue = false)]
        public string Association { get; set; }

        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        [DataMember(Name="galleryImage", EmitDefaultValue=false)]
        public string GalleryImage { get; set; }

        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        [DataMember(Name="localizedScopeName", EmitDefaultValue=false)]
        public string LocalizedScopeName { get; set; }

        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        [DataMember(Name="parentFolder", EmitDefaultValue=false)]
        public string ParentFolder { get; set; }

        [DataMember(Name="parentIsScopeFolder", EmitDefaultValue=false)]
        public bool? ParentIsScopeFolder { get; set; }

        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }

        [DataMember(Name="standInKey", EmitDefaultValue=false)]
        public string StandInKey { get; set; }

    }

}
