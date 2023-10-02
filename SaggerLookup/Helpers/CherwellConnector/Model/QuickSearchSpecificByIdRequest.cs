using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class QuickSearchSpecificByIdRequest
{
    [DataMember(Name = "busObIds", EmitDefaultValue = false)]
    public List<string> BusObIds { get; set; }

    [DataMember(Name = "standIn", EmitDefaultValue = false)]
    public string StandIn { get; set; }

    [DataMember(Name = "ascending", EmitDefaultValue = false)]
    public bool? Ascending { get; set; }

    [DataMember(Name = "isBusObTarGet", EmitDefaultValue = false)]
    public bool? IsBusObTarGet { get; set; }

    [DataMember(Name = "nonFinalState", EmitDefaultValue = false)]
    public bool? NonFinalState { get; set; }

    [DataMember(Name = "searchAnyWords", EmitDefaultValue = false)]
    public bool? SearchAnyWords { get; set; }

    [DataMember(Name = "searchAttachments", EmitDefaultValue = false)]
    public bool? SearchAttachments { get; set; }

    [DataMember(Name = "searchRelated", EmitDefaultValue = false)]
    public bool? SearchRelated { get; set; }

    [DataMember(Name = "searchText", EmitDefaultValue = false)]
    public string SearchText { get; set; }

    [DataMember(Name = "selectedChangedLimit", EmitDefaultValue = false)]
    public SearchesChangedLimit SelectedChangedLimit { get; set; }

    [DataMember(Name = "selectedSortByFieldId", EmitDefaultValue = false)]
    public string SelectedSortByFieldId { get; set; }

    [DataMember(Name = "sortByRelevance", EmitDefaultValue = false)]
    public bool? SortByRelevance { get; set; }

    [DataMember(Name = "specificSearchTarGetId", EmitDefaultValue = false)]
    public string SpecificSearchTarGetId { get; set; }

    [DataMember(Name = "useSortBy", EmitDefaultValue = false)]
    public bool? UseSortBy { get; set; }
}