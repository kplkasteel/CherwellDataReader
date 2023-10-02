using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class BatchDeleteRequest
{
    [DataMember(Name = "DeleteRequests", EmitDefaultValue = false)]
    public List<DeleteRequest> DeleteRequests { get; set; }

    [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
    public bool? StopOnError { get; set; }
}