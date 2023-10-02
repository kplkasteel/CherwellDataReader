using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class BatchSaveRequest
{
    [DataMember(Name = "saveRequests", EmitDefaultValue = false)]
    public List<SaveRequest> SaveRequests { get; set; }

    [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
    public bool? StopOnError { get; set; }
}