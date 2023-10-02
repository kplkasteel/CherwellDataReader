using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SaveGalleryImageRequest
{
    [DataMember(Name = "imageType", EmitDefaultValue = false)]
    public ImaGetypeEnum? ImageType { get; set; }

    [DataMember(Name = "base64EncodedImageData", EmitDefaultValue = false)]
    public string Base64EncodedImageData { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "folder", EmitDefaultValue = false)]
    public string Folder { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public string Scope { get; set; }

    [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
    public string ScopeOwner { get; set; }

    [DataMember(Name = "standInKey", EmitDefaultValue = false)]
    public string StandInKey { get; set; }
}