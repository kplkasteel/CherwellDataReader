using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchesChangedLimit
{
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(Name = "units", EmitDefaultValue = false)]
    public string Units { get; set; }

    [DataMember(Name = "value", EmitDefaultValue = false)]
    public int? Value { get; set; }
}