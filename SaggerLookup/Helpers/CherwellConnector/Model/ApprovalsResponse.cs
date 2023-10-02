using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ApprovalsResponse
{
    [DataMember(Name = "totalRecords", EmitDefaultValue = false)]
    public int? TotalRecords { get; set; }

    [DataMember(Name = "approvals", EmitDefaultValue = false)]
    public List<ApprovalReadResponse> Approvals { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}