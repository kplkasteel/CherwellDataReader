using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public class BatchReadResponse
    {

        [DataMember(Name = "responses", EmitDefaultValue = false)]
        public List<ReadResponse> Responses { get; set; }
    }
}

        