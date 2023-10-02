using System.Diagnostics.CodeAnalysis;

namespace SwaggerLookup.Helpers.CherwellConnector.Enum;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public enum GrantTypes
{
    password = 0,
    refresh_token = 1
}