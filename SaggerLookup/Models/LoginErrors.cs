using Newtonsoft.Json;

namespace SaggerLookup.Models
{
    public class LoginErrors
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        [JsonProperty(PropertyName = "error_description")]
        public string Description { get; set; }
    }
}           