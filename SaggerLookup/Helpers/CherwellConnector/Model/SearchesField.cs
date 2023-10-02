using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchesField
{
    [DataMember(Name = "caption", EmitDefaultValue = false)]
    public string Caption { get; set; }

    [DataMember(Name = "currencyCulture", EmitDefaultValue = false)]
    public string CurrencyCulture { get; set; }

    [DataMember(Name = "currencySymbol", EmitDefaultValue = false)]
    public string CurrencySymbol { get; set; }

    [DataMember(Name = "decimalDigits", EmitDefaultValue = false)]
    public int? DecimalDigits { get; set; }

    [DataMember(Name = "defaultSortOrderAscending", EmitDefaultValue = false)]
    public bool? DefaultSortOrderAscending { get; set; }

    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }

    [DataMember(Name = "fieldName", EmitDefaultValue = false)]
    public string FieldName { get; set; }

    [DataMember(Name = "fullFieldId", EmitDefaultValue = false)]
    public string FullFieldId { get; set; }

    [DataMember(Name = "hasDefaultSortField", EmitDefaultValue = false)]
    public bool? HasDefaultSortField { get; set; }

    [DataMember(Name = "fieldId", EmitDefaultValue = false)]
    public string FieldId { get; set; }

    [DataMember(Name = "isBinary", EmitDefaultValue = false)]
    public bool? IsBinary { get; set; }

    [DataMember(Name = "isCurrency", EmitDefaultValue = false)]
    public bool? IsCurrency { get; set; }

    [DataMember(Name = "isDateTime", EmitDefaultValue = false)]
    public bool? IsDateTime { get; set; }

    [DataMember(Name = "isFilterAllowed", EmitDefaultValue = false)]
    public bool? IsFilterAllowed { get; set; }

    [DataMember(Name = "isLogical", EmitDefaultValue = false)]
    public bool? IsLogical { get; set; }

    [DataMember(Name = "isNumber", EmitDefaultValue = false)]
    public bool? IsNumber { get; set; }

    [DataMember(Name = "isShortDate", EmitDefaultValue = false)]
    public bool? IsShortDate { get; set; }

    [DataMember(Name = "isShortTime", EmitDefaultValue = false)]
    public bool? IsShortTime { get; set; }

    [DataMember(Name = "isVisible", EmitDefaultValue = false)]
    public bool? IsVisible { get; set; }

    [DataMember(Name = "sortable", EmitDefaultValue = false)]
    public bool? Sortable { get; set; }

    [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
    public string SortOrder { get; set; }

    [DataMember(Name = "storageName", EmitDefaultValue = false)]
    public string StorageName { get; set; }

    [DataMember(Name = "wholeDigits", EmitDefaultValue = false)]
    public int? WholeDigits { get; set; }
}