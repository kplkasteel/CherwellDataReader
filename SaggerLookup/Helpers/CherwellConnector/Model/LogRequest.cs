using System.Collections.Generic;
using System.Runtime.Serialization;
using SwaggerLookup.Helpers.CherwellConnector.Enum;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class LogRequest
{
    [DataMember(Name = "level", EmitDefaultValue = false)]
    public LevelEnum? Level { get; set; }

    [DataMember(Name = "keyValueProperties", EmitDefaultValue = false)]
    public List<object> KeyValueProperties { get; set; }

    [DataMember(Name = "message", EmitDefaultValue = false)]
    public string Message { get; set; }
}