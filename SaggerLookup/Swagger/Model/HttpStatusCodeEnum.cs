using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SaggerLookup.Swagger.Model
{

    [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpStatusCodeEnum
        {
            [EnumMember(Value = "Continue")]
            Continue = 1,
            [EnumMember(Value = "SwitchingProtocols")]
            SwitchingProtocols = 2,
            [EnumMember(Value = "OK")]
            OK = 3,
            [EnumMember(Value = "Created")]
            Created = 4,
            [EnumMember(Value = "Accepted")]
            Accepted = 5,
            [EnumMember(Value = "NonAuthoritativeInformation")]
            NonAuthoritativeInformation = 6,
            [EnumMember(Value = "NoContent")]
            NoContent = 7,
            [EnumMember(Value = "ResetContent")]
            ResetContent = 8,
            [EnumMember(Value = "PartialContent")]
            PartialContent = 9,
            [EnumMember(Value = "MultipleChoices")]
            MultipleChoices = 10,
            [EnumMember(Value = "Ambiguous")]
            Ambiguous = 11,
            [EnumMember(Value = "MovedPermanently")]
            MovedPermanently = 12,
            [EnumMember(Value = "Moved")]
            Moved = 13,
            [EnumMember(Value = "Found")]
            Found = 14,
            [EnumMember(Value = "Redirect")]
            Redirect = 15,
            [EnumMember(Value = "SeeOther")]
            SeeOther = 16,
            [EnumMember(Value = "RedirectMethod")]
            RedirectMethod = 17,
            [EnumMember(Value = "NotModified")]
            NotModified = 18,
            [EnumMember(Value = "UseProxy")]
            UseProxy = 19,
            [EnumMember(Value = "Unused")]
            Unused = 20,
            [EnumMember(Value = "TemporaryRedirect")]
            TemporaryRedirect = 21,
            [EnumMember(Value = "RedirectKeepVerb")]
            RedirectKeepVerb = 22,
            [EnumMember(Value = "BadRequest")]
            BadRequest = 23,
            [EnumMember(Value = "Unauthorized")]
            Unauthorized = 24,
            [EnumMember(Value = "PaymentRequired")]
            PaymentRequired = 25,
            [EnumMember(Value = "Forbidden")]
            Forbidden = 26,
            [EnumMember(Value = "NotFound")]
            NotFound = 27,
            [EnumMember(Value = "MethodNotAllowed")]
            MethodNotAllowed = 28,
            [EnumMember(Value = "NotAcceptable")]
            NotAcceptable = 29,
            [EnumMember(Value = "ProxyAuthenticationRequired")]
            ProxyAuthenticationRequired = 30,
            [EnumMember(Value = "RequestTimeout")]
            RequestTimeout = 31,
            [EnumMember(Value = "Conflict")]
            Conflict = 32,
            [EnumMember(Value = "Gone")]
            Gone = 33,
            [EnumMember(Value = "LengthRequired")]
            LengthRequired = 34,
            [EnumMember(Value = "PreconditionFailed")]
            PreconditionFailed = 35,
            [EnumMember(Value = "RequestEntityTooLarge")]
            RequestEntityTooLarge = 36,
            [EnumMember(Value = "RequestUriTooLong")]
            RequestUriTooLong = 37,
            [EnumMember(Value = "UnsupportedMediaType")]
            UnsupportedMediaType = 38,
            [EnumMember(Value = "RequestedRangeNotSatisfiable")]
            RequestedRangeNotSatisfiable = 39,
            [EnumMember(Value = "ExpectationFailed")]
            ExpectationFailed = 40,
            [EnumMember(Value = "UpgradeRequired")]
            UpgradeRequired = 41,
            [EnumMember(Value = "InternalServerError")]
            InternalServerError = 42,
            [EnumMember(Value = "NotImplemented")]
            NotImplemented = 43,
            [EnumMember(Value = "BadGateway")]
            BadGateway = 44,
            [EnumMember(Value = "ServiceUnavailable")]
            ServiceUnavailable = 45,
            [EnumMember(Value = "GatewayTimeout")]
            GatewayTimeout = 46,
            [EnumMember(Value = "HttpVersionNotSupported")]
            HttpVersionNotSupported = 47
        }
    
}