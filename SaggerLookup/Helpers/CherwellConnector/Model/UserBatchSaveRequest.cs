using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserBatchSaveRequest
{
    public UserBatchSaveRequest(List<UserSaveRequest> saveRequests = default, bool? stopOnError = default)
    {
        SaveRequests = saveRequests;
        StopOnError = stopOnError;
    }

    [DataMember(Name = "saveRequests", EmitDefaultValue = false)]
    public List<UserSaveRequest> SaveRequests { get; set; }

    [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
    public bool? StopOnError { get; set; }
}