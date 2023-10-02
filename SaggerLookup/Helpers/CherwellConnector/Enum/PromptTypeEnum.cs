using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SwaggerLookup.Helpers.CherwellConnector.Enum;

/// <summary>
///     Defines PromptType
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PromptTypeEnum
{
    /// <summary>
    ///     Enum None for value: None
    /// </summary>
    [EnumMember(Value = "None")] None = 1,

    /// <summary>
    ///     Enum Text for value: Text
    /// </summary>
    [EnumMember(Value = "Text")] Text = 2,

    /// <summary>
    ///     Enum Number for value: Number
    /// </summary>
    [EnumMember(Value = "Number")] Number = 3,

    /// <summary>
    ///     Enum DateTime for value: DateTime
    /// </summary>
    [EnumMember(Value = "DateTime")] DateTime = 4,

    /// <summary>
    ///     Enum Logical for value: Logical
    /// </summary>
    [EnumMember(Value = "Logical")] Logical = 5,

    /// <summary>
    ///     Enum Binary for value: Binary
    /// </summary>
    [EnumMember(Value = "Binary")] Binary = 6,

    /// <summary>
    ///     Enum DateOnly for value: DateOnly
    /// </summary>
    [EnumMember(Value = "DateOnly")] DateOnly = 7,

    /// <summary>
    ///     Enum TimeOnly for value: TimeOnly
    /// </summary>
    [EnumMember(Value = "TimeOnly")] TimeOnly = 8,

    /// <summary>
    ///     Enum Json for value: Json
    /// </summary>
    [EnumMember(Value = "Json")] Json = 9,

    /// <summary>
    ///     Enum JsonArray for value: JsonArray
    /// </summary>
    [EnumMember(Value = "JsonArray")] JsonArray = 10,

    /// <summary>
    ///     Enum Xml for value: Xml
    /// </summary>
    [EnumMember(Value = "Xml")] Xml = 11,

    /// <summary>
    ///     Enum XmlCollection for value: XmlCollection
    /// </summary>
    [EnumMember(Value = "XmlCollection")] XmlCollection = 12,

    /// <summary>
    ///     Enum TimeValue for value: TimeValue
    /// </summary>
    [EnumMember(Value = "TimeValue")] TimeValue = 13
}