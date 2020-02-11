using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class TemplateRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRequest" /> class.
        /// </summary>
        /// <param name="busObId">busObId.</param>
        /// <param name="fieldNames">fieldNames.</param>
        /// <param name="fieldIds">fieldIds.</param>
        /// <param name="includeAll">includeAll.</param>
        /// <param name="includeRequired">includeRequired.</param>
        public TemplateRequest(string busObId = default, List<string> fieldNames = default,
            List<string> fieldIds = default, bool? includeAll = default, bool? includeRequired = default)
        {
            BusObId = busObId;
            FieldNames = fieldNames;
            FieldIds = fieldIds;
            IncludeAll = includeAll;
            IncludeRequired = includeRequired;
        }

        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        [DataMember(Name = "fieldIds", EmitDefaultValue = false)]
        public List<string> FieldIds { get; set; }

        [DataMember(Name = "fieldNames", EmitDefaultValue = false)]
        public List<string> FieldNames { get; set; }
        [DataMember(Name = "includeAll", EmitDefaultValue = false)]
        public bool? IncludeAll { get; set; }

        [DataMember(Name = "includeRequired", EmitDefaultValue = false)]
        public bool? IncludeRequired { get; set; }
    }
}