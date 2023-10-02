using System;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class BusObActivity
{
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "parentBusObDefId", EmitDefaultValue = false)]
    public string ParentBusObDefId { get; set; }

    [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
    public string ParentBusObRecId { get; set; }

    [DataMember(Name = "historyBusObDefId", EmitDefaultValue = false)]
    public string HistoryBusObDefId { get; set; }

    [DataMember(Name = "historyBusObRecId", EmitDefaultValue = false)]
    public string HistoryBusObRecId { get; set; }

    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }

    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }

    [DataMember(Name = "body", EmitDefaultValue = false)]
    public string Body { get; set; }

    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public string CreatedBy { get; set; }

    [DataMember(Name = "created", EmitDefaultValue = false)]
    public DateTime? Created { get; set; }

    [DataMember(Name = "modified", EmitDefaultValue = false)]
    public DateTime? Modified { get; set; }

    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public string ModifiedBy { get; set; }
}