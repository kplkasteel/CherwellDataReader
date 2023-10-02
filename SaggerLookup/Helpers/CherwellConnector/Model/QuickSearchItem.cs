using System.Collections.Generic;
using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class QuickSearchItem
{
    [DataMember(Name = "changedOption", EmitDefaultValue = false)]
    public ChangedOptionEnum? ChangedOption { get; set; }

    [DataMember(Name = "nonFinalStateOption", EmitDefaultValue = false)]
    public NonFinalStateOptionEnum? NonFinalStateOption { get; set; }

    [DataMember(Name = "searchAnyWordsOption", EmitDefaultValue = false)]
    public SearchAnyWordsOptionEnum? SearchAnyWordsOption { get; set; }

    [DataMember(Name = "searchAttachmentsOption", EmitDefaultValue = false)]
    public SearchAttachmentsOptionEnum? SearchAttachmentsOption { get; set; }

    [DataMember(Name = "searchRelatedOption", EmitDefaultValue = false)]
    public SearchRelatedOptionEnum? SearchRelatedOption { get; set; }

    [DataMember(Name = "searchTarGetType", EmitDefaultValue = false)]
    public SearchTarGetTypeEnum? SearchTarGetType { get; set; }

    [DataMember(Name = "sortByOption", EmitDefaultValue = false)]
    public SortByOptionEnum? SortByOption { get; set; }

    [DataMember(Name = "ascending", EmitDefaultValue = false)]
    public bool? Ascending { get; set; }

    [DataMember(Name = "changedLimits", EmitDefaultValue = false)]
    public List<SearchesChangedLimit> ChangedLimits { get; set; }

    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(Name = "galleryImage", EmitDefaultValue = false)]
    public string GalleryImage { get; set; }

    [DataMember(Name = "hasAnyOptions", EmitDefaultValue = false)]
    public bool? HasAnyOptions { get; set; }

    [DataMember(Name = "searchTarGetId", EmitDefaultValue = false)]
    public string SearchTarGetId { get; set; }

    [DataMember(Name = "selectedChangedLimit", EmitDefaultValue = false)]
    public SearchesChangedLimit SelectedChangedLimit { get; set; }

    [DataMember(Name = "selectedSortByFieldId", EmitDefaultValue = false)]
    public string SelectedSortByFieldId { get; set; }

    [DataMember(Name = "sortByFields", EmitDefaultValue = false)]
    public Dictionary<string, string> SortByFields { get; set; }

    [DataMember(Name = "watermarkText", EmitDefaultValue = false)]
    public string WatermarkText { get; set; }
}