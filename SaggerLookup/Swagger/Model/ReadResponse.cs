using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class ReadResponse
    {
        private List<FieldTemplateItem> _fields;
        [DataMember(Name = "httpStatusCode", EmitDefaultValue = false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }

        [DataMember(Name="busObId", EmitDefaultValue=false)]
        public string BusObId { get; set; }
        [DataMember(Name="busObPublicId", EmitDefaultValue=false)]
        public string BusObPublicId { get; set; }

        [DataMember(Name="busObRecId", EmitDefaultValue=false)]
        public string BusObRecId { get; set; }

        
        public string FieldString
        {
            get => _fields != null ? JsonConvert.SerializeObject(_fields) : string.Empty;
            set => _fields = !string.IsNullOrEmpty(value)
                ? JsonConvert.DeserializeObject<List<FieldTemplateItem>>(value)
                : new List<FieldTemplateItem>();
        }
        [DataMember(Name = "fields", EmitDefaultValue = false)]
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

        public void SetFieldInformation(string fieldName, string fieldValue, bool forceUpdate = false)
        {
            var result = Fields?.SingleOrDefault(x => x.Name == fieldName);
            if (result == null || (result.Value == fieldValue && !forceUpdate)) return;

            Fields.Find(x => x.Name == fieldName).Value = fieldValue;
            Fields.Find(x => x.Name == fieldName).Dirty = true;
        }

    }

}
