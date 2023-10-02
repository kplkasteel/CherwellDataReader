using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SaveUrlAttachmentRequest
{
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

    [DataMember(Name = "displayText", EmitDefaultValue = false)]
    public string DisplayText { get; set; }

    [DataMember(Name = "includeLinks", EmitDefaultValue = false)]
    public bool? IncludeLinks { get; set; }

    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; set; }
}