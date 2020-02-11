
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    
    public class SecurityGroup 
    {
        
        
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }

    }

}
