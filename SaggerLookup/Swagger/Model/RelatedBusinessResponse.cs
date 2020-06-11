using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace SaggerLookup.Swagger.Model
{
    public class RelatedBusinessResponse
    {
        private List<FieldTemplateItem> _fields;

        public string Id { get; set; }
        public string ParentBusObId { get; set; }
        public string ParentBusObPublicId { get; set; }
        public string ParentBusObRecId { get; set; }
        public string BusObId { get; set; }
        public string BusObPublicId { get; set; }
        public string BusObRecId { get; set; }
        public string FieldString
        {
            get => _fields != null ? JsonConvert.SerializeObject(_fields) : string.Empty;
            set => _fields = !string.IsNullOrEmpty(value)
                ? JsonConvert.DeserializeObject<List<FieldTemplateItem>>(value)
                : new List<FieldTemplateItem>();
        }
       
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