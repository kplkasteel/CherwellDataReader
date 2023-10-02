using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model;

[DataContract]
public class Location
{
    [DataMember(Name = "altitude", EmitDefaultValue = false)]
    public double? Altitude { get; set; }

    [DataMember(Name = "busObId", EmitDefaultValue = false)]
    public string BusObId { get; set; }

    [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
    public string BusObRecId { get; set; }

    [DataMember(Name = "latitude", EmitDefaultValue = false)]
    public double? Latitude { get; set; }

    [DataMember(Name = "longitude", EmitDefaultValue = false)]
    public double? Longitude { get; set; }
}