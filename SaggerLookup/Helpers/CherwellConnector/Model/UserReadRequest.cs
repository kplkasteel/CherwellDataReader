using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserReadRequest
{
    [DataMember(Name = "loginId", EmitDefaultValue = false)]
    public string LoginId { get; set; }

    [DataMember(Name = "publicId", EmitDefaultValue = false)]
    public string PublicId { get; set; }
}