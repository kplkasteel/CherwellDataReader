using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ApiClientSettingResponse
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "culture", EmitDefaultValue = false)]
    public string Culture { get; set; }

    [DataMember(Name = "clientKey", EmitDefaultValue = false)]
    public string ClientKey { get; set; }

    [DataMember(Name = "tokenLifespanMinutes", EmitDefaultValue = false)]
    public int? TokenLifespanMinutes { get; set; }

    [DataMember(Name = "refreshTokenLifespanMinutes", EmitDefaultValue = false)]
    public int? RefreshTokenLifespanMinutes { get; set; }

    [DataMember(Name = "apiAccessIsEnabled", EmitDefaultValue = false)]
    public bool? ApiAccessIsEnabled { get; set; }

    [DataMember(Name = "allowAnonymousAccess", EmitDefaultValue = false)]
    public bool? AllowAnonymousAccess { get; set; }

    [DataMember(Name = "standInKey", EmitDefaultValue = false)]
    public string StandInKey { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}