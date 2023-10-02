using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SimpleResultsListGroup
{
    [DataMember(Name = "isBusObTarGet", EmitDefaultValue = false)]
    public bool? IsBusObTarGet { get; set; }

    [DataMember(Name = "simpleResultsListItems", EmitDefaultValue = false)]
    public List<SimpleResultsListItem> SimpleResultsListItems { get; set; }

    [DataMember(Name = "subTitle", EmitDefaultValue = false)]
    public string SubTitle { get; set; }

    [DataMember(Name = "tarGetId", EmitDefaultValue = false)]
    public string TarGetId { get; set; }

    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}