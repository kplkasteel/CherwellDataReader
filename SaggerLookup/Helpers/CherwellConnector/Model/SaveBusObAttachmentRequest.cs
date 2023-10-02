using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SaveBusObAttachmentRequest
{
    [DataMember(Name = "attachBusObId", EmitDefaultValue = false)]
    public string AttachBusObId { get; set; }

    [DataMember(Name = "attachBusObName", EmitDefaultValue = false)]
    public string AttachBusObName { get; set; }

    [DataMember(Name = "attachBusObPublicId", EmitDefaultValue = false)]
    public string AttachBusObPublicId { get; set; }

    [DataMember(Name = "attachBusObRecId", EmitDefaultValue = false)]
    public string AttachBusObRecId { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObName", EmitDefaultValue = false)]
    public string BusObName { get; set; }

    [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
    public string BusObPublicId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "comment", EmitDefaultValue = false)]
    public string Comment { get; set; }

    [DataMember(Name = "includeLinks", EmitDefaultValue = false)]
    public bool? IncludeLinks { get; set; }
}