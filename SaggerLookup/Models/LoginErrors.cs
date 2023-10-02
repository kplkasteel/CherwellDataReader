using Newtonsoft.Json;

namespace SwaggerLookup.Models
{
    public class LoginErrors
    {
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }
        [JsonProperty(PropertyName = "error_description")]
        public string Description { get; set; }
    }
}           