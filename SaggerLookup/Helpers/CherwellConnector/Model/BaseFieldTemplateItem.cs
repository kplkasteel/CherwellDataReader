using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

public class BaseFieldTemplateItem
{
    private List<FieldTemplateItem> _fields;

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
            _fields ??= !string.IsNullOrEmpty(FieldString)
                ? JsonConvert.DeserializeObject<List<FieldTemplateItem>>(FieldString)
                : new List<FieldTemplateItem>();
        set => _fields = value;
    }

    public string ReadFieldInformation([CallerMemberName] string property = null)
    {
        if (Fields == null) return string.Empty;
        return Fields.SingleOrDefault(x => x.Name == property)?.Value ?? string.Empty;
    }

    public void SetFieldInformation(string fieldValue, [CallerMemberName] string property = null,
        bool forceUpdate = false)
    {
        var result = Fields?.SingleOrDefault(x => x.Name == property);
        if (result == null || (result.Value == fieldValue && !forceUpdate)) return;

        Fields.Find(x => x.Name == property).Value = fieldValue;
        Fields.Find(x => x.Name == property).Dirty = true;
    }
}