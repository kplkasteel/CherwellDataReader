using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class BatchDeleteResponse
{
    [DataMember(Name = "responses", EmitDefaultValue = false)]
    public List<DeleteResponse> Responses { get; set; }
}