using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class UserSaveV2Request
{
    [DataMember(Name = "accountLocked", EmitDefaultValue = false)]
    public bool? AccountLocked { get; set; }

    [DataMember(Name = "allCultures", EmitDefaultValue = false)]
    public bool? AllCultures { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
    public string BusObPublicId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(Name = "ldapRequired", EmitDefaultValue = false)]
    public bool? LdapRequired { get; set; }

    [DataMember(Name = "loginId", EmitDefaultValue = false)]
    public string LoginId { get; set; }

    [DataMember(Name = "nextPasswordResetDate", EmitDefaultValue = false)]
    public DateTime? NextPasswordResetDate { get; set; }

    [DataMember(Name = "password", EmitDefaultValue = false)]
    public string Password { get; set; }

    [DataMember(Name = "passwordNeverExpires", EmitDefaultValue = false)]
    public bool? PasswordNeverExpires { get; set; }

    [DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
    public string SecurityGroupId { get; set; }

    [DataMember(Name = "specificCulture", EmitDefaultValue = false)]
    public string SpecificCulture { get; set; }

    [DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
    public bool? UserCannotChangePassword { get; set; }

    [DataMember(Name = "userMustChangePasswordAtNextLogin", EmitDefaultValue = false)]
    public bool? UserMustChangePasswordAtNextLogin { get; set; }

    [DataMember(Name = "windowsUserId", EmitDefaultValue = false)]
    public string WindowsUserId { get; set; }

    private List<FieldTemplateItem> _fields;

    public string FieldString
    {
        get => _fields != null ? JsonConvert.SerializeObject(_fields) : string.Empty;
        set => _fields = !string.IsNullOrEmpty(value)
            ? JsonConvert.DeserializeObject<List<FieldTemplateItem>>(value)
            : new List<FieldTemplateItem>();
    }

    [DataMember(Name = "userInfoFields", EmitDefaultValue = false)]
    public List<FieldTemplateItem> UserInfoFields
    {
        get =>
            _fields ??= !string.IsNullOrEmpty(FieldString)
                ? JsonConvert.DeserializeObject<List<FieldTemplateItem>>(FieldString)
                : new List<FieldTemplateItem>();
        set => _fields = value;
    }

    public string ReadFieldInformation([CallerMemberName] string property = null)
    {
        if (UserInfoFields == null) return string.Empty;
        return UserInfoFields.SingleOrDefault(x => x.Name == property)?.Value ?? string.Empty;
    }

    public void SetFieldInformation(string fieldValue, [CallerMemberName] string property = null, bool forceUpdate = false)
    {
        var result = UserInfoFields?.SingleOrDefault(x => x.Name == property);
        if (result == null || (result.Value == fieldValue && !forceUpdate)) return;

        UserInfoFields.Find(x => x.Name == property).Value = fieldValue;
        UserInfoFields.Find(x => x.Name == property).Dirty = true;
    }
}