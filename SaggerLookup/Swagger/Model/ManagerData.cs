using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public partial class ManagerData
    {
        [DataMember(Name="httpStatusCode", EmitDefaultValue=false)]
        public HttpStatusCodeEnum? HttpStatusCode { get; set; }

        [DataMember(Name="root", EmitDefaultValue=false)]
        public ManagerFolder Root { get; set; }

        [DataMember(Name="supportedAssociations", EmitDefaultValue=false)]
        public List<NameValuePair> SupportedAssociations { get; set; }

        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }

    }

}
