using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class RemoveCustomerFromWorkgroupResponse
{
    [DataMember(Name = "workgroupId", EmitDefaultValue = false)]
    public string WorkgroupId { get; set; }

    [DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
    public string CustomerRecordId { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}