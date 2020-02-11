using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class SaveGalleryImageRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveGalleryImageRequest" /> class.
        /// </summary>
        /// <param name="base64EncodedImageData">base64EncodedImageData.</param>
        /// <param name="description">description.</param>
        /// <param name="folder">folder.</param>
        /// <param name="imageType">imageType.</param>
        /// <param name="name">name.</param>
        /// <param name="scope">scope.</param>
        /// <param name="scopeOwner">scopeOwner.</param>
        /// <param name="standInKey">standInKey.</param>
        public SaveGalleryImageRequest(string base64EncodedImageData = default, string description = default, string folder = default, ImageTypeEnum? imageType = default, string name = default, string scope = default, string scopeOwner = default, string standInKey = default)
        {
            Base64EncodedImageData = base64EncodedImageData;
            Description = description;
            Folder = folder;
            ImageType = imageType;
            Name = name;
            Scope = scope;
            ScopeOwner = scopeOwner;
            StandInKey = standInKey;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum ImageTypeEnum
        {
            [EnumMember(Value = "Imported")]
            Imported = 1,

            [EnumMember(Value = "File")]
            File = 2,

            [EnumMember(Value = "Url")]
            Url = 3
        }

        [DataMember(Name = "base64EncodedImageData", EmitDefaultValue = false)]
        public string Base64EncodedImageData { get; set; }

        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(Name = "folder", EmitDefaultValue = false)]
        public string Folder { get; set; }

        [DataMember(Name = "imageType", EmitDefaultValue = false)]
        public ImageTypeEnum? ImageType { get; set; }
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public string Scope { get; set; }

        [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
        public string ScopeOwner { get; set; }

        [DataMember(Name = "standInKey", EmitDefaultValue = false)]
        public string StandInKey { get; set; }
    }
}