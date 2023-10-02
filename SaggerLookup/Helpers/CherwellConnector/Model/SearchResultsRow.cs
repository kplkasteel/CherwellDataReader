using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchResultsRow
{
    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links { get; set; }

    [DataMember(Name = "publicId", EmitDefaultValue = false)]
    public string PublicId { get; set; }

    [DataMember(Name = "rowColor", EmitDefaultValue = false)]
    public string RowColor { get; set; }

    [DataMember(Name = "searchResultsFieldValues", EmitDefaultValue = false)]
    public List<FieldTemplateItem> SearchResultsFieldValues { get; set; }
}