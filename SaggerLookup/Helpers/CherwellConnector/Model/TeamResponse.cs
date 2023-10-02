using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class TeamResponse : BaseFieldTemplateItem
{
    [DataMember(Name = "teamType", EmitDefaultValue = false)]
    public TeamTypeEnum? TeamType { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "emailAlias", EmitDefaultValue = false)]
    public string EmailAlias { get; set; }

    [DataMember(Name = "image", EmitDefaultValue = false)]
    public string Image { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "teamId", EmitDefaultValue = false)]
    public string TeamId { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}