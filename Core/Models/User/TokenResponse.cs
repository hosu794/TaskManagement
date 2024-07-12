using Newtonsoft.Json;

namespace Core.Models.Auth
{
    public class TokenResponse
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("isManager")]
        public bool IsManager { get; set; }
    }
}
