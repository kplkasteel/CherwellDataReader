using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserBatchReadRequest
{
    [DataMember(Name = "readRequests", EmitDefaultValue = false)]
    public List<UserReadRequest> ReadRequests { get; set; }

    [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
    public bool? StopOnError { get; set; }
}