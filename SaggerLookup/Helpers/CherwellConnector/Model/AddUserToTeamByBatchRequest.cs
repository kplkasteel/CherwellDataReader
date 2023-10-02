using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class AddUserToTeamByBatchRequest
{
    [DataMember(Name = "addUserToTeamRequests", EmitDefaultValue = false)]
    public List<AddUserToTeamRequest> AddUserToTeamRequests { get; set; }

    [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
    public bool? StopOnError { get; set; }
}