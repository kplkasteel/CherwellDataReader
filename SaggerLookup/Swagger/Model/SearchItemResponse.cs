using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
  
    [DataContract]
    public  class SearchItemResponse
    {

        [DataMember(Name="root", EmitDefaultValue=false)]
        public SearchFolder Root { get; set; }

        [DataMember(Name="supportedAssociations", EmitDefaultValue=false)]
        public List<Association> SupportedAssociations { get; set; }

        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }
    }

}
