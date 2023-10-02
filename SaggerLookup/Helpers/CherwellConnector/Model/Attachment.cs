using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class Attachment
{
    [DataMember(Name = "attachmentType", EmitDefaultValue = false)]
    public AttachmentTypeEnum? AttachmentType { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public ScopeEnum? Scope { get; set; }

    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    [DataMember(Name = "attachedBusObId", EmitDefaultValue = false)]
    public string AttachedBusObId { get; set; }

    [DataMember(Name = "attachedBusObRecId", EmitDefaultValue = false)]
    public string AttachedBusObRecId { get; set; }

    [DataMember(Name = "attachmentFileId", EmitDefaultValue = false)]
    public string AttachmentFileId { get; set; }

    [DataMember(Name = "attachmentFileName", EmitDefaultValue = false)]
    public string AttachmentFileName { get; set; }

    [DataMember(Name = "attachmentFileType", EmitDefaultValue = false)]
    public string AttachmentFileType { get; set; }

    [DataMember(Name = "attachmentId", EmitDefaultValue = false)]
    public string AttachmentId { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "comment", EmitDefaultValue = false)]
    public string Comment { get; set; }

    [DataMember(Name = "created", EmitDefaultValue = false)]
    public DateTime? Created { get; set; }

    [DataMember(Name = "displayText", EmitDefaultValue = false)]
    public string DisplayText { get; set; }

    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links { get; set; }

    [DataMember(Name = "owner", EmitDefaultValue = false)]
    public string Owner { get; set; }

    [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
    public string ScopeOwner { get; set; }
}