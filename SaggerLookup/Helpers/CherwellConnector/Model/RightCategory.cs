using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class RightCategory
{
    [DataMember(Name = "categoryDescription", EmitDefaultValue = false)]
    public string CategoryDescription { get; set; }

    [DataMember(Name = "categoryId", EmitDefaultValue = false)]
    public string CategoryId { get; set; }

    [DataMember(Name = "categoryName", EmitDefaultValue = false)]
    public string CategoryName { get; set; }
}