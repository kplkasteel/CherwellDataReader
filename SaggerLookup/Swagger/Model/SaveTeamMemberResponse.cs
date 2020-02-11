
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    
    public class SaveTeamMemberResponse 
    {
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }
    }
}