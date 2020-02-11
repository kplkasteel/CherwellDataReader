using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{

    [DataContract]
    public  class BatchReadRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchReadRequest" /> class.
        /// </summary>
        /// <param name="readRequests">readRequests.</param>
        /// <param name="stopOnError">stopOnError.</param>
        public BatchReadRequest(List<ReadRequest> readRequests = default, bool? stopOnError = default)
        {
            ReadRequests = readRequests;
            StopOnError = stopOnError;
        }

       
        [DataMember(Name = "readRequests", EmitDefaultValue = false)]
        public List<ReadRequest> ReadRequests { get; set; }

        [DataMember(Name = "stopOnError", EmitDefaultValue = false)]
        public bool? StopOnError { get; set; }

    }
}