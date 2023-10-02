using System.Runtime.Serialization;

namespace SwaggerLookup.Helpers.CherwellConnector.Model
{
    [DataContract]
    public class AddItemToQueueResponse
    {
        [DataMember(Name = "historyRecId", EmitDefaultValue = false)]
        public string HistoryRecId { get; set; }

        [DataMember(Name = "historyText", EmitDefaultValue = false)]
        public string HistoryText { get; set; }

        [DataMember(Name = "historyTypeId", EmitDefaultValue = false)]
        public string HistoryTypeId { get; set; }

        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        [DataMember(Name = "hasError", EmitDefaultValue = false)]
        public bool? HasError { get; set; }
    }
}