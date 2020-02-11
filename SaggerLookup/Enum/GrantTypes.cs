using System.Diagnostics.CodeAnalysis;

namespace SaggerLookup.Enum
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum GrantTypes
    {
        password = 0,
        refresh_token = 1
    }
} 