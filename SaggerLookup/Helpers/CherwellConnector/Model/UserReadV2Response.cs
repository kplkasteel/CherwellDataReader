using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserReadV2Response
{
    [DataMember(Name = "users", EmitDefaultValue = false)]
    public List<UserV2> Users { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}