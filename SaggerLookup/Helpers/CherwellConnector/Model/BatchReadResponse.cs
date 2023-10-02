using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class BatchReadResponse
{
    [DataMember(Name = "responses", EmitDefaultValue = false)]
    public List<ReadResponse> Responses { get; set; }
}