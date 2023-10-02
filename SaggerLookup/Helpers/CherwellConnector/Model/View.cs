using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class View
{
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    [DataMember(Name = "viewId", EmitDefaultValue = false)]
    public string ViewId { get; set; }

    [DataMember(Name = "image", EmitDefaultValue = false)]
    public string Image { get; set; }
}