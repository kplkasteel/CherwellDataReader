using System.Collections.Generic;
using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class AttachmentsRequest
{
    [DataMember(Name = "attachmentTypes", EmitDefaultValue = false)]
    public List<AttachmentTypeEnum> AttachmentTypes { get; set; }

    [DataMember(Name = "types", EmitDefaultValue = false)]
    public List<TypeEnum> Types { get; set; }

    [DataMember(Name = "attachmentId", EmitDefaultValue = false)]
    public string AttachmentId { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObName", EmitDefaultValue = false)]
    public string BusObName { get; set; }

    [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
    public string BusObPublicId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "includeLinks", EmitDefaultValue = false)]
    public bool? IncludeLinks { get; set; }
}