using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class RelatedSaveRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RelatedSaveRequest" /> class.
        /// </summary>
        /// <param name="parentBusObId">parentBusObId.</param>
        /// <param name="parentBusObPublicId">parentBusObPublicId.</param>
        /// <param name="parentBusObRecId">parentBusObRecId.</param>
        /// <param name="relationshipId">relationshipId.</param>
        /// <param name="busObId">busObId.</param>
        /// <param name="busObPublicId">busObPublicId.</param>
        /// <param name="busObRecId">busObRecId.</param>
        /// <param name="cacheKey">cacheKey.</param>
        /// <param name="cacheScope">cacheScope.</param>
        /// <param name="fields">fields.</param>
        /// <param name="persist">persist.</param>
        public RelatedSaveRequest(string parentBusObId = default, string parentBusObPublicId = default, string parentBusObRecId = default, string relationshipId = default, string busObId = default, string busObPublicId = default, string busObRecId = default, string cacheKey = default, CacheScopeEnum? cacheScope = default, List<FieldTemplateItem> fields = default, bool? persist = default)
        {
            ParentBusObId = parentBusObId;
            ParentBusObPublicId = parentBusObPublicId;
            ParentBusObRecId = parentBusObRecId;
            RelationshipId = relationshipId;
            BusObId = busObId;
            BusObPublicId = busObPublicId;
            BusObRecId = busObRecId;
            CacheKey = cacheKey;
            CacheScope = cacheScope;
            Fields = fields;
            Persist = persist;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public enum CacheScopeEnum
        {
            [EnumMember(Value = "Tenant")]
            Tenant = 1,

            [EnumMember(Value = "User")]
            User = 2,

            [EnumMember(Value = "Session")]
            Session = 3
        }

        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
        public string BusObPublicId { get; set; }

        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

        [DataMember(Name = "cacheKey", EmitDefaultValue = false)]
        public string CacheKey { get; set; }

        [DataMember(Name = "cacheScope", EmitDefaultValue = false)]
        public CacheScopeEnum? CacheScope { get; set; }
        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public List<FieldTemplateItem> Fields { get; set; }

        [DataMember(Name = "parentBusObId", EmitDefaultValue = false)]
        public string ParentBusObId { get; set; }

        [DataMember(Name = "parentBusObPublicId", EmitDefaultValue = false)]
        public string ParentBusObPublicId { get; set; }

        [DataMember(Name = "parentBusObRecId", EmitDefaultValue = false)]
        public string ParentBusObRecId { get; set; }

        [DataMember(Name = "persist", EmitDefaultValue = false)]
        public bool? Persist { get; set; }

        [DataMember(Name = "relationshipId", EmitDefaultValue = false)]
        public string RelationshipId { get; set; }
    }
}