using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SaggerLookup.Swagger.Model
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListDisplayOptionEnum
    {
            
        [EnumMember(Value = "Auto")]
        Auto = 1,
            
        [EnumMember(Value = "Text")]
        Text = 2,
            
        [EnumMember(Value = "Combo")]
        Combo = 3,
            
        [EnumMember(Value = "GridList")]
        GridList = 4,
            
        [EnumMember(Value = "SimpleList")]
        SimpleList = 5,
            
        [EnumMember(Value = "PromptSimpleGrid")]
        PromptSimpleGrid = 6
    }
}