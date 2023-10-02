using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class ViewsResponse
{
    public ViewsResponse(List<View> views = default)
    {
        Views = views;
    }

    [DataMember(Name = "views", EmitDefaultValue = false)]
    public List<View> Views { get; set; }
}