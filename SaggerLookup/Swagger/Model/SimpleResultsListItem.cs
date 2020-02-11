using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class SimpleResultsListItem
    {

        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }

        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        [DataMember(Name="docRepositoryItemId", EmitDefaultValue=false)]
        public string DocRepositoryItemId { get; set; }

        [DataMember(Name="galleryImage", EmitDefaultValue=false)]
        public string GalleryImage { get; set; }

        [DataMember(Name="publicId", EmitDefaultValue=false)]
        public string PublicId { get; set; }

        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }

        [DataMember(Name="scopeOwner", EmitDefaultValue=false)]
        public string ScopeOwner { get; set; }

        [DataMember(Name="subTitle", EmitDefaultValue=false)]
        public string SubTitle { get; set; }

        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

    }

}
