using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SaveWorkgroupMemberRequest
{
    [DataMember(Name = "customerRecordId", EmitDefaultValue = false)]
    public string CustomerRecordId { get; set; }

    [DataMember(Name = "workgroupId", EmitDefaultValue = false)]
    public string WorkgroupId { get; set; }

    [DataMember(Name = "customerIsWorkgroupManager", EmitDefaultValue = false)]
    public bool? CustomerIsWorkgroupManager { get; set; }
}