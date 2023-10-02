using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserBatchSaveResponse
{
    [DataMember(Name = "responses", EmitDefaultValue = false)]
    public List<UserSaveResponse> Responses { get; set; }
}