using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
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

        [DataMember(Name = "userInfoFields", EmitDefaultValue = false)]
        public List<FieldTemplateItem> UserInfoFields { get; set; }

        [DataMember(Name = "userMustChangePasswordAtNextLogin", EmitDefaultValue = false)]
        public bool? UserMustChangePasswordAtNextLogin { get; set; }

        [DataMember(Name = "windowsUserId", EmitDefaultValue = false)]
        public string WindowsUserId { get; set; }
    }
}