using System.Runtime.Serialization;

namespace SaggerLookup.Swagger.Model
{
    [DataContract]
    public class TokenResponse
    {
        
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        [DataMember(Name = "as:client_id", EmitDefaultValue = false)]
        public string AsclientId { get; set; }

        [DataMember(Name = ".expires", EmitDefaultValue = false)]
        public string Expires { get; set; }

        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int? ExpiresIn { get; set; }

        [DataMember(Name = ".issued", EmitDefaultValue = false)]
        public string Issued { get; set; }

        [DataMember(Name = "refresh_token", EmitDefaultValue = false)]
        public string RefreshToken { get; set; }

        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public string TokenType { get; set; }

        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }
    }
}