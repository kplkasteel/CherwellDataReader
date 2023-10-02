using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserBatchSaveV2Request
{
    [DataMember(Name = "saveRequests", EmitDefaultValue = false)]
    public List<UserSaveV2Request> SaveRequests { get; set; }

    [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
    public bool? StopOnError { get; set; }
}