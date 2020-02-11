using Newtonsoft.Json;

namespace SaggerLookup.Models
{
    public class SingleMessage
    {
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }
    }
}