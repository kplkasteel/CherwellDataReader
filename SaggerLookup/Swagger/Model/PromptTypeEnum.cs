using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SaggerLookup.Swagger.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PromptTypeEnum
    {
            
        [EnumMember(Value = "None")]
        None = 1,
            
        [EnumMember(Value = "Text")]
        Text = 2,
            
        [EnumMember(Value = "Number")]
        Number = 3,
            
        [EnumMember(Value = "DateTime")]
        DateTime = 4,
            
        [EnumMember(Value = "Logical")]
        Logical = 5,
            
        [EnumMember(Value = "Binary")]
        Binary = 6,
            
        [EnumMember(Value = "DateOnly")]
        DateOnly = 7,
            
        [EnumMember(Value = "TimeOnly")]
        TimeOnly = 8,
            
        [EnumMember(Value = "Json")]
        Json = 9,
            
        [EnumMember(Value = "JsonArray")]
        JsonArray = 10,
            
        [EnumMember(Value = "Xml")]
        Xml = 11,
            
        [EnumMember(Value = "XmlCollection")]
        XmlCollection = 12,
            
        [EnumMember(Value = "TimeValue")]
        TimeValue = 13
    }
}