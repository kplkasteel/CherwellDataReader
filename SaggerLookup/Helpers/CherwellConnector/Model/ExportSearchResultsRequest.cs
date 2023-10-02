using System.Collections.Generic;
using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ExportSearchResultsRequest
{
    [DataMember(Name = "exportFormat", EmitDefaultValue = false)]
    public ExportFormatEnum? ExportFormat { get; set; }

    [DataMember(Name = "customSeparator", EmitDefaultValue = false)]
    public string CustomSeparator { get; set; }

    [DataMember(Name = "exportTitle", EmitDefaultValue = false)]
    public string ExportTitle { get; set; }

    [DataMember(Name = "association", EmitDefaultValue = false)]
    public string Association { get; set; }

    [DataMember(Name = "associationName", EmitDefaultValue = false)]
    public string AssociationName { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "customGridDefId", EmitDefaultValue = false)]
    public string CustomGridDefId { get; set; }

    [DataMember(Name = "dateTimeFormatting", EmitDefaultValue = false)]
    public string DateTimeFormatting { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "fields", EmitDefaultValue = false)]
    public List<string> Fields { get; set; }

    [DataMember(Name = "filters", EmitDefaultValue = false)]
    public List<FilterInfo> Filters { get; set; }

    [DataMember(Name = "includeAllFields", EmitDefaultValue = false)]
    public bool? IncludeAllFields { get; set; }

    [DataMember(Name = "includeSchema", EmitDefaultValue = false)]
    public bool? IncludeSchema { get; set; }

    [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
    public int? PageNumber { get; set; }

    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public string Scope { get; set; }

    [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
    public string ScopeOwner { get; set; }

    [DataMember(Name = "searchId", EmitDefaultValue = false)]
    public string SearchId { get; set; }

    [DataMember(Name = "searchName", EmitDefaultValue = false)]
    public string SearchName { get; set; }

    [DataMember(Name = "searchText", EmitDefaultValue = false)]
    public string SearchText { get; set; }

    [DataMember(Name = "sorting", EmitDefaultValue = false)]
    public List<SortInfo> Sorting { get; set; }

    [DataMember(Name = "promptValues", EmitDefaultValue = false)]
    public List<PromptValue> PromptValues { get; set; }
}