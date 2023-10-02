using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class RelatedSaveRequest : BaseFieldTemplateItem
{
    [DataMember(Name = "cacheScope", EmitDefaultValue = false)]
    public CacheScopeEnum? CacheScope { get; set; }

    [DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
    public string ParentBusObId { get; set; }

    [DataMember(Name = "parentBusObPublicId", EmitDefaultValue = false)]
    public string ParentBusObPublicId { get; set; }

    [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
    public string ParentBusObRecId { get; set; }

    [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
    public string RelationshipId { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
    public string BusObPublicId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "cacheKey", EmitDefaultValue = false)]
    public string CacheKey { get; set; }

    [DataMember(Name = "persist", EmitDefaultValue = false)]
    public bool? Persist { get; set; }
}