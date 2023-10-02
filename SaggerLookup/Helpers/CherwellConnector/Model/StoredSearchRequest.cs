using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class StoredSearchRequest
{
    [DataMember(Name = "associationId", EmitDefaultValue = false)]
    public string AssociationId { get; set; }

    [DataMember(Name = "associationName", EmitDefaultValue = false)]
    public string AssociationName { get; set; }

    [DataMember(Name = "gridId", EmitDefaultValue = false)]
    public string GridId { get; set; }

    [DataMember(Name = "includeSchema", EmitDefaultValue = false)]
    public bool? IncludeSchema { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public string Scope { get; set; }

    [DataMember(Name = "scopeOwnerId", EmitDefaultValue = false)]
    public string ScopeOwnerId { get; set; }

    [DataMember(Name = "searchId", EmitDefaultValue = false)]
    public string SearchId { get; set; }

    [DataMember(Name = "searchName", EmitDefaultValue = false)]
    public string SearchName { get; set; }
}