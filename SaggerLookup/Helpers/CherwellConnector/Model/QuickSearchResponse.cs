using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class QuickSearchResponse
{
    [DataMember(Name = "searchResultsTable", EmitDefaultValue = false)]
    public SearchResultsTableResponse SearchResultsTable { get; set; }

    [DataMember(Name = "simpleResultsList", EmitDefaultValue = false)]
    public SimpleResultsList SimpleResultsList { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}