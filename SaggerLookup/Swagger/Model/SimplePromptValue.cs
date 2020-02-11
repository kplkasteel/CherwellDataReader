using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class SimplePromptValue 
    {

        [DataMember(Name="promptDefId", EmitDefaultValue=false)]
        public string PromptDefId { get; set; }

        [DataMember(Name="promptName", EmitDefaultValue=false)]
        public string PromptName { get; set; }

        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

    }

}
