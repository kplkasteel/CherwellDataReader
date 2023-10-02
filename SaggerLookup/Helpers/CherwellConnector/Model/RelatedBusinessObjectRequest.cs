using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class RelatedBusinessObjectRequest
{
    [DataMember(Name = "allFields", EmitDefaultValue = false)]
    public bool? AllFields { get; set; }

    [DataMember(Name = "customGridId", EmitDefaultValue = false)]
    public string CustomGridId { get; set; }

    [DataMember(Name = "fieldsList", EmitDefaultValue = false)]
    public List<string> FieldsList { get; set; }

    [DataMember(Name = "filters", EmitDefaultValue = false)]
    public List<FilterInfo> Filters { get; set; }

    [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
    public int? PageNumber { get; set; }

    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }

    [DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
    public string ParentBusObId { get; set; }

    [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
    public string ParentBusObRecId { get; set; }

    [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
    public string RelationshipId { get; set; }

    [DataMember(Name = "sorting", EmitDefaultValue = false)]
    public List<SortInfo> Sorting { get; set; }

    [DataMember(Name = "useDefaultGrid", EmitDefaultValue = false)]
    public bool? UseDefaultGrid { get; set; }
}