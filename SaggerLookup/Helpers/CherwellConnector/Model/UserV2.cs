using System;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserV2 : BaseFieldTemplateItem
{
    [DataMember(Name = "accountLocked", EmitDefaultValue = false)]
    public bool? AccountLocked { get; set; }

    [DataMember(Name = "createDateTime", EmitDefaultValue = false)]
    public DateTime? CreateDateTime { get; set; }

    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(Name = "lastPasswordResetDate", EmitDefaultValue = false)]
    public DateTime? LastPasswordResetDate { get; set; }

    [DataMember(Name = "lastResetDateTime", EmitDefaultValue = false)]
    public DateTime? LastResetDateTime { get; set; }

    [DataMember(Name = "ldapRequired", EmitDefaultValue = false)]
    public bool? LdapRequired { get; set; }

    [DataMember(Name = "passwordNeverExpires", EmitDefaultValue = false)]
    public bool? PasswordNeverExpires { get; set; }

    [DataMember(Name = "publicId", EmitDefaultValue = false)]
    public string PublicId { get; set; }

    [DataMember(Name = "recordId", EmitDefaultValue = false)]
    public string RecordId { get; set; }

    [DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
    public string SecurityGroupId { get; set; }

    [DataMember(Name = "shortDisplayName", EmitDefaultValue = false)]
    public string ShortDisplayName { get; set; }

    [DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
    public bool? UserCannotChangePassword { get; set; }

    [DataMember(Name = "userMustResetPasswordAtNextLogin", EmitDefaultValue = false)]
    public bool? UserMustResetPasswordAtNextLogin { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}