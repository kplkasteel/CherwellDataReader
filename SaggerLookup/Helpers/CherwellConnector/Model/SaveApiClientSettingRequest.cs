using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SaveApiClientSettingRequest
{
    [DataMember(Name = "allowAnonymousAccess", EmitDefaultValue = false)]
    public bool? AllowAnonymousAccess { get; set; }

    [DataMember(Name = "apiAccessIsEnabled", EmitDefaultValue = false)]
    public bool? ApiAccessIsEnabled { get; set; }

    [DataMember(Name = "createNewClientKey", EmitDefaultValue = false)]
    public bool? CreateNewClientKey { get; set; }

    [DataMember(Name = "culture", EmitDefaultValue = false)]
    public string Culture { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "refreshTokenLifespanMinutes", EmitDefaultValue = false)]
    public int? RefreshTokenLifespanMinutes { get; set; }

    [DataMember(Name = "standInKey", EmitDefaultValue = false)]
    public string StandInKey { get; set; }

    [DataMember(Name = "tokenLifespanMinutes", EmitDefaultValue = false)]
    public int? TokenLifespanMinutes { get; set; }
}