using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class Section
{
    [DataMember(Name = "sectionFields", EmitDefaultValue = false)]
    public List<SectionField> SectionFields { get; set; }

    [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
    public string GalleryImage { get; set; }

    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }

    [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
    public string RelationshipId { get; set; }

    [DataMember(Name = "tarGetBusObId", EmitDefaultValue = false)]
    public string TarGetBusObId { get; set; }

    [DataMember(Name = "tarGetBusObRecId", EmitDefaultValue = false)]
    public string TarGetBusObRecId { get; set; }
}