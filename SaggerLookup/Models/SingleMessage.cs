using Newtonsoft.Json;

namespace SwaggerLookup.Models
{
    public class SingleMessage
    {
        [JsonProperty(PropertyName = "Message")]
        public string Message { get; set; }
    }
}