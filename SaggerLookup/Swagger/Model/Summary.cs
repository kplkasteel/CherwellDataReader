using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class Summary
    {
        private List<Summary> _groupSummaries;

        [DataMember(Name = "firstRecIdField", EmitDefaultValue = false),]
        public string FirstRecIdField { get; set; }

        [DataMember(Name = "groupSummaries", EmitDefaultValue = false)] 
        public List<Summary> GroupSummaries
        {
            get =>
                _groupSummaries ?? (_groupSummaries = !string.IsNullOrEmpty(GroupSummariesString)
                    ? JsonConvert.DeserializeObject<List<Summary>>(GroupSummariesString)
                    : new List<Summary>());
            set => _groupSummaries = value;
        }
        public string GroupSummariesString
        {
            get => _groupSummaries != null ? JsonConvert.SerializeObject(_groupSummaries) : string.Empty;
            set => _groupSummaries = !string.IsNullOrEmpty(value)
                ? JsonConvert.DeserializeObject<List<Summary>>(value)
                : new List<Summary>();
        }
        
        [DataMember(Name = "recIdFields", EmitDefaultValue = false)]
        public string RecIdFields { get; set; }

        [DataMember(Name = "stateFieldId", EmitDefaultValue = false)]
        public string StateFieldId { get; set; }

        [DataMember(Name = "states", EmitDefaultValue = false)]
        public string States { get; set; }

        [DataMember(Name = "busObId", EmitDefaultValue = false)]
        public string BusObId { get; set; }

        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        [DataMember(Name = "group", EmitDefaultValue = false)]
        public bool? Group { get; set; }

        [DataMember(Name = "lookup", EmitDefaultValue = false)]
        public bool? Lookup { get; set; }

        [DataMember(Name = "major", EmitDefaultValue = false)]
        public bool? Major { get; set; }

        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "supporting", EmitDefaultValue = false)]
        public bool? Supporting { get; set; }
    }
}