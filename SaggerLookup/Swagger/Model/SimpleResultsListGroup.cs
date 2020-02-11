using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class SimpleResultsListGroup
    {
        
        [DataMember(Name="isBusObTarget", EmitDefaultValue=false)]
        public bool? IsBusObTarget { get; set; }

        [DataMember(Name="simpleResultsListItems", EmitDefaultValue=false)]
        public List<SimpleResultsListItem> SimpleResultsListItems { get; set; }

        [DataMember(Name="subTitle", EmitDefaultValue=false)]
        public string SubTitle { get; set; }

        [DataMember(Name="targetId", EmitDefaultValue=false)]
        public string TargetId { get; set; }

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
