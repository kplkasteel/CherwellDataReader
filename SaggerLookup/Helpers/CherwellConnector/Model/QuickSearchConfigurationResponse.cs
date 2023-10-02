using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class QuickSearchConfigurationResponse
{
    [DataMember(Name = "allowQuickSearch", EmitDefaultValue = false)]
    public bool? AllowQuickSearch { get; set; }

    [DataMember(Name = "allowSpecificSearch", EmitDefaultValue = false)]
    public bool? AllowSpecificSearch { get; set; }

    [DataMember(Name = "defaultToQuickSearch", EmitDefaultValue = false)]
    public bool? DefaultToQuickSearch { get; set; }

    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
    public string GalleryImage { get; set; }

    [DataMember(Name = "history", EmitDefaultValue = false)]
    public List<string> History { get; set; }

    [DataMember(Name = "includeAvailableInSpecific", EmitDefaultValue = false)]
    public bool? IncludeAvailableInSpecific { get; set; }

    [DataMember(Name = "includeQuickSearchInSpecific", EmitDefaultValue = false)]
    public bool? IncludeQuickSearchInSpecific { get; set; }

    [DataMember(Name = "quickSearchId", EmitDefaultValue = false)]
    public string QuickSearchId { get; set; }

    [DataMember(Name = "quickSearchItems", EmitDefaultValue = false)]
    public List<QuickSearchItem> QuickSearchItems { get; set; }

    [DataMember(Name = "quickSearchWatermark", EmitDefaultValue = false)]
    public string QuickSearchWatermark { get; set; }

    [DataMember(Name = "sortByRelevance", EmitDefaultValue = false)]
    public bool? SortByRelevance { get; set; }

    [DataMember(Name = "resolvedQuickSearchWatermark", EmitDefaultValue = false)]
    public string ResolvedQuickSearchWatermark { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public string Scope { get; set; }

    [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
    public string ScopeOwner { get; set; }

    [DataMember(Name = "specificSearchItems", EmitDefaultValue = false)]
    public List<QuickSearchItem> SpecificSearchItems { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}