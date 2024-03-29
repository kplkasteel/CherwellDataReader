using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class SchemaResponse
{
    private List<FieldDefinition> _fieldDefinitions;
    private List<GridDefinition> _gridDefinitions;
    private List<Relationship> _relationships;

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "fieldDefinitions", EmitDefaultValue = false)]
    public List<FieldDefinition> FieldDefinitions
    {
        get =>
            _fieldDefinitions ??= !string.IsNullOrEmpty(FieldDefinitionString)
                ? JsonConvert.DeserializeObject<List<FieldDefinition>>(FieldDefinitionString)
                : new List<FieldDefinition>();
        set => _fieldDefinitions = value;
    }

    [JsonIgnore]
    public string FieldDefinitionString
    {
        get => _fieldDefinitions != null ? JsonConvert.SerializeObject(_fieldDefinitions) : string.Empty;
        set => _fieldDefinitions = !string.IsNullOrEmpty(value)
            ? JsonConvert.DeserializeObject<List<FieldDefinition>>(value)
            : new List<FieldDefinition>();
    }

    [DataMember(Name = "firstRecIdField", EmitDefaultValue = false)]
    public string FirstRecIdField { get; set; }

    [DataMember(Name = "gridDefinitions", EmitDefaultValue = false)]
    public List<GridDefinition> GridDefinitions
    {
        get =>
            _gridDefinitions ??= !string.IsNullOrEmpty(GridDefinitionsString)
                ? JsonConvert.DeserializeObject<List<GridDefinition>>(GridDefinitionsString)
                : new List<GridDefinition>();
        set => _gridDefinitions = value;
    }

    [JsonIgnore]
    public string GridDefinitionsString
    {
        get => _gridDefinitions != null ? JsonConvert.SerializeObject(_gridDefinitions) : string.Empty;
        set => _gridDefinitions = !string.IsNullOrEmpty(value)
            ? JsonConvert.DeserializeObject<List<GridDefinition>>(value)
            : new List<GridDefinition>();
    }

    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "recIdFields", EmitDefaultValue = false)]
    public string RecIdFields { get; set; }

    [DataMember(Name = "relationships", EmitDefaultValue = false)]
    public List<Relationship> Relationships
    {
        get =>
            _relationships ??= !string.IsNullOrEmpty(RelationshipString)
                ? JsonConvert.DeserializeObject<List<Relationship>>(RelationshipString)
                : new List<Relationship>();
        set => _relationships = value;
    }

    public string RelationshipString
    {
        get => _relationships != null ? JsonConvert.SerializeObject(_relationships) : string.Empty;
        set => _relationships = !string.IsNullOrEmpty(value)
            ? JsonConvert.DeserializeObject<List<Relationship>>(value)
            : new List<Relationship>();
    }

    [DataMember(Name = "stateFieldId", EmitDefaultValue = false)]
    public string StateFieldId { get; set; }

    [DataMember(Name = "states", EmitDefaultValue = false)]
    public string States { get; set; }

    [DataMember(Name = "errorCode", EmitDefaultValue = false)]
    public string ErrorCode { get; set; }

    [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
    public string ErrorMessage { get; set; }

    [DataMember(Name = "hasError", EmitDefaultValue = false)]
    public bool? HasError { get; set; }
}