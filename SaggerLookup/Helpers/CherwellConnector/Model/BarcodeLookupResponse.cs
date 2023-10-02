using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class BarcodeLookupResponse
{
    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}