using Newtonsoft.Json;

namespace SwaggerLookup.Models
{
    public class GeneralError
    {
        [JsonProperty(PropertyName = "busObPublicId")]
        public string BusObPublicId { get; set; }
        [JsonProperty(PropertyName = "busObRecId")]
        public string BusObRecId { get; set; }
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }
        [JsonProperty(PropertyName = "hasError")]
        public bool HasError { get; set; }
    }
}