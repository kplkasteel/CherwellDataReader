using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class StoredValueResponse
{
    [DataMember(Name = "storedValueType", EmitDefaultValue = false)]
    public StoredValueTypeEnum? StoredValueType { get; set; }

    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }

    [DataMember(Name = "folder", EmitDefaultValue = false)]
    public string Folder { get; set; }

    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "scope", EmitDefaultValue = false)]
    public string Scope { get; set; }

    [DataMember(Name = "scopeOwner", EmitDefaultValue = false)]
    public string ScopeOwner { get; set; }

    [DataMember(Name = "standInKey", EmitDefaultValue = false)]
    public string StandInKey { get; set; }

    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}