using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ReadResponse : BaseFieldTemplateItem
{
    private List<Link> _links;

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
    public string BusObPublicId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links
    {
        get =>
            _links ??= !string.IsNullOrEmpty(LinkString)
                ? JsonConvert.DeserializeObject<List<Link>>(LinkString)
                : new List<Link>();
        set => _links = value;
    }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }

    public string LinkString
    {
        get => _links != null ? JsonConvert.SerializeObject(_links) : string.Empty;
        set => _links = !string.IsNullOrEmpty(value)
            ? JsonConvert.DeserializeObject<List<Link>>(value)
            : new List<Link>();
    }
}