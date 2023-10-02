using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

/// <summary>
///     UserBatchDeleteResponse
/// </summary>
[DataContract]
public class UserBatchDeleteResponse
{
    /// <summary>
    ///     Gets or Sets Responses
    /// </summary>
    [DataMember(Name = "responses", EmitDefaultValue = false)]
    public List<UserDeleteResponse> Responses { get; set; }
}