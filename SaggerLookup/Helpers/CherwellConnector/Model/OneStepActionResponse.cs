using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class OneStepActionResponse
{
    [DataMember(Name = "completed", EmitDefaultValue = false)]
    public bool? Completed { get; set; }

    [DataMember(Name = "currentPrimaryBusObId", EmitDefaultValue = false)]
    public string CurrentPrimaryBusObId { get; set; }

    [DataMember(Name = "currentPrimaryBusObRecId", EmitDefaultValue = false)]
    public string CurrentPrimaryBusObRecId { get; set; }

    [DataMember(Name = "hasNewAccessToken", EmitDefaultValue = false)]
    public bool? HasNewAccessToken { get; set; }

    [DataMember(Name = "newAccessToken", EmitDefaultValue = false)]
    public string NewAccessToken { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}