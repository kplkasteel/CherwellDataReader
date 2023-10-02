using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class MobileFormResponse
{
    [DataMember(Name = "actions", EmitDefaultValue = false)]
    public List<Action> Actions { get; set; }

    [DataMember(Name = "attachments", EmitDefaultValue = false)]
    public List<Attachment> Attachments { get; set; }

    [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
    public string GalleryImage { get; set; }

    [DataMember(Name = "locationInformation", EmitDefaultValue = false)]
    public Location LocationInformation { get; set; }

    [DataMember(Name = "sections", EmitDefaultValue = false)]
    public List<Section> Sections { get; set; }

    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}