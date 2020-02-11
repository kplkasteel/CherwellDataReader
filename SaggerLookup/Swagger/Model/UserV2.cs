using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using SQLite;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class UserV2
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

        [DataMember(Name = "recordId", EmitDefaultValue = false), PrimaryKey]
        public string RecordId { get; set; }

        [DataMember(Name = "securityGroupId", EmitDefaultValue = false)]
        public string SecurityGroupId { get; set; }

        [DataMember(Name = "shortDisplayName", EmitDefaultValue = false)]
        public string ShortDisplayName { get; set; }

        [DataMember(Name = "userCannotChangePassword", EmitDefaultValue = false)]
        public bool? UserCannotChangePassword { get; set; }

        [DataMember(Name = "userMustResetPasswordAtNextLogin", EmitDefaultValue = false)]
        public bool? UserMustResetPasswordAtNextLogin { get; set; }

        // ReSharper disable once UnusedMember.Global
        public byte[] Avatar { get; set; }

        public string CompanyCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        [Ignore]
        public List<Team> Teams
        {
            get =>
                _teams ?? (_teams = !string.IsNullOrEmpty(TeamsString)
                    ? JsonConvert.DeserializeObject<List<Team>>(TeamsString)
                    : new List<Team>());
            set => _teams = value;
        }

        public string TeamsString
        {
            get => _teams != null ? JsonConvert.SerializeObject(_teams) : string.Empty;
            set => _teams = !string.IsNullOrEmpty(value)
                ? JsonConvert.DeserializeObject<List<Team>>(value)
                : new List<Team>();
        }
        private List<FieldTemplateItem> _fields;
        private List<Team> _teams;

        public string FieldString
        {
            get => _fields != null ? JsonConvert.SerializeObject(_fields) : string.Empty;
            set => _fields = !string.IsNullOrEmpty(value)
                ? JsonConvert.DeserializeObject<List<FieldTemplateItem>>(value)
                : new List<FieldTemplateItem>();
        }

        [DataMember(Name = "fields", EmitDefaultValue = false), Ignore]
        public List<FieldTemplateItem> Fields
        {
            get =>
                _fields ?? (_fields = !string.IsNullOrEmpty(FieldString)
                    ? JsonConvert.DeserializeObject<List<FieldTemplateItem>>(FieldString)
                    : new List<FieldTemplateItem>());
            set => _fields = value;
        }

        public string ReadFieldInformation(string fieldName)
        {
            if (Fields == null) return string.Empty;
            return Fields.SingleOrDefault(x => x.Name == fieldName)?.Value ?? string.Empty;
        }

        public List<FieldTemplateItem> SetFieldInformation(string fieldName, string fieldValue, bool forceUpdate = false)
        {
            var result = Fields?.SingleOrDefault(x => x.Name == fieldName);
            if (result == null || (result.Value == fieldValue || forceUpdate)) return Fields;
            {
                Fields.Find(x => x.Name == fieldName).Value = fieldValue;
                Fields.Find(x => x.Name == fieldName).Dirty = true;
            }


            return Fields;
        }
    }
}