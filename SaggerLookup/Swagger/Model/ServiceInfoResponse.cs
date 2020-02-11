using System;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class ServiceInfoResponse
    {
        
        [DataMember(Name="apiVersion", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        [DataMember(Name="csmCulture", EmitDefaultValue=false)]
        public string CsmCulture { get; set; }

        [DataMember(Name="csmVersion", EmitDefaultValue=false)]
        public string CsmVersion { get; set; }

        [DataMember(Name="systemDateTime", EmitDefaultValue=false)]
        public DateTime? SystemDateTime { get; set; }

        [DataMember(Name="timeZone", EmitDefaultValue=false)]
        public object TimeZone { get; set; }
    }

}
