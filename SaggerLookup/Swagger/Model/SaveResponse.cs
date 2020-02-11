using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
    /// <summary>
    /// SaveResponse
    /// </summary>
    [DataContract]
    public class SaveResponse
    {

        [DataMember(Name = "busObPublicId", EmitDefaultValue = false)]
        public string BusObPublicId { get; set; }

        [DataMember(Name = "busObRecId", EmitDefaultValue = false)]
        public string BusObRecId { get; set; }

 
        [DataMember(Name = "cacheKey", EmitDefaultValue = false)]
        public string CacheKey { get; set; }

        [DataMember(Name = "fieldValidationErrors", EmitDefaultValue = false)]
        public List<FieldValidationError> FieldValidationErrors { get; set; }

        [DataMember(Name = "notificationTriggers", EmitDefaultValue = false)]
        public List<NotificationTrigger> NotificationTriggers { get; set; }

        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }

    }
}