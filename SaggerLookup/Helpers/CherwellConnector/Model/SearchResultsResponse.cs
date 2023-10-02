using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchResultsResponse
{
    [DataMember(Name = "businessObjects", EmitDefaultValue = false)]
    public List<ReadResponse> BusinessObjects { get; set; }

    [DataMember(Name = "hasPrompts", EmitDefaultValue = false)]
    public bool? HasPrompts { get; set; }

    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links { get; set; }

    [DataMember(Name = "prompts", EmitDefaultValue = false)]
    public List<Prompt> Prompts { get; set; }

    [DataMember(Name = "searchResultsFields", EmitDefaultValue = false)]
    public List<SearchesField> SearchResultsFields { get; set; }

    [DataMember(Name = "simpleResults", EmitDefaultValue = false)]
    public SimpleResultsList SimpleResults { get; set; }

    [DataMember(Name = "totalRows", EmitDefaultValue = false)]
    public long? TotalRows { get; set; }

    [DataMember(Name = "hasMoreRecords", EmitDefaultValue = false)]
    public bool? HasMoreRecords { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}