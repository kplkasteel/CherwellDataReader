using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using SQLite;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class TemplateResponse
    {
        private List<FieldTemplateItem> _fields;


        [PrimaryKey]
        [DataMember(Name = "busObId", EmitDefaultValue = false), Ignore]
        public string BusObId { get; set; }
        [DataMember(Name = "busObName", EmitDefaultValue = false), Ignore]
        public string BusObName { get; set; }

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

    }
}