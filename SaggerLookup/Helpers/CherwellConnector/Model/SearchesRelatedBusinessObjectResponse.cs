using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SearchesRelatedBusinessObjectResponse
{
    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }

    [DataMember(Name = "links", EmitDefaultValue = false)]
    public List<Link> Links { get; set; }

    [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
    public int? PageNumber { get; set; }

    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }

    [DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
    public string ParentBusObId { get; set; }

    [DataMember(Name = "parentBusObPublicId", EmitDefaultValue = false)]
    public string ParentBusObPublicId { get; set; }

    [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
    public string ParentBusObRecId { get; set; }

    [DataMember(Name = "relatedBusinessObjects", EmitDefaultValue = false)]
    public List<ReadResponse> RelatedBusinessObjects { get; set; }

    [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
    public string RelationshipId { get; set; }

    [DataMember(Name = "totalRecords", EmitDefaultValue = false)]
    public int? TotalRecords { get; set; }
}