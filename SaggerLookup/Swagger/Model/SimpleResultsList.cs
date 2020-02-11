using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class SimpleResultsList
    {
        
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<SimpleResultsListGroup> Groups { get; set; }

        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public string ErrorCode { get; set; }

        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        [DataMember(Name="hasError", EmitDefaultValue=false)]
        public bool? HasError { get; set; }

    }

}
