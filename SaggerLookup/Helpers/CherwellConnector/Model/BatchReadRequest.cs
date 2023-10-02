using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class BatchReadRequest
{
    [DataMember(Name = "readRequests", EmitDefaultValue = false)]
    public List<ReadRequest> ReadRequests { get; set; }

    [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
    public bool? StopOnError { get; set; }
}