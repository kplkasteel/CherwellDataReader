using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class LogBatchRequest
{
    [DataMember(Name = "logRequests", EmitDefaultValue = false)]
    public List<LogRequest> LogRequests { get; set; }
}