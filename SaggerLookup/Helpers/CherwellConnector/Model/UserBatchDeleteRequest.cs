using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserBatchDeleteRequest
{
    [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
    public bool? StopOnError { get; set; }

    [DataMember(Name = "userRecordIds", EmitDefaultValue = false)]
    public List<string> UserRecordIds { get; set; }
}