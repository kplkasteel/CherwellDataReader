using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SwaggerLookup.Helpers.CherwellConnector.Enum;

/// <summary>
///     Defines ExportFormat
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ExportFormatEnum
{
    /// <summary>
    ///     Enum CSV for value: CSV
    /// </summary>
    [EnumMember(Value = "CSV")] CSV = 1,

    /// <summary>
    ///     Enum Excel for value: Excel
    /// </summary>
    [EnumMember(Value = "Excel")] Excel = 2,

    /// <summary>
    ///     Enum Tab for value: Tab
    /// </summary>
    [EnumMember(Value = "Tab")] Tab = 3,

    /// <summary>
    ///     Enum Word for value: Word
    /// </summary>
    [EnumMember(Value = "Word")] Word = 4,

    /// <summary>
    ///     Enum CustomSeparator for value: CustomSeparator
    /// </summary>
    [EnumMember(Value = "CustomSeparator")]
    CustomSeparator = 5,

    /// <summary>
    ///     Enum Json for value: Json
    /// </summary>
    [EnumMember(Value = "Json")] Json = 6
}