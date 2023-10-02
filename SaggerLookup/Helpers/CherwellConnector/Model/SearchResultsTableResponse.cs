using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchResultsTableResponse
{
    [DataMember(Name = "columns", EmitDefaultValue = false)]
    public List<SearchesField> Columns { get; set; }

    [DataMember(Name = "rows", EmitDefaultValue = false)]
    public List<SearchResultsRow> Rows { get; set; }

    [DataMember(Name = "sorting", EmitDefaultValue = false)]
    public List<SortInfo> Sorting { get; set; }

    [DataMember(Name = "totalRows", EmitDefaultValue = false)]
    public long? TotalRows { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}