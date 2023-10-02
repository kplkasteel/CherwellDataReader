using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ClientSecuritySettingsResponse
{
    [DataMember(Name = "internalLoginAllowed", EmitDefaultValue = false)]
    public bool? InternalLoginAllowed { get; set; }

    [DataMember(Name = "ldapLoginAllowed", EmitDefaultValue = false)]
    public bool? LdapLoginAllowed { get; set; }

    [DataMember(Name = "samlLoginAllowed", EmitDefaultValue = false)]
    public bool? SamlLoginAllowed { get; set; }

    [DataMember(Name = "windowsLoginAllowed", EmitDefaultValue = false)]
    public bool? WindowsLoginAllowed { get; set; }
}