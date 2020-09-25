using Refit;

namespace BaiDu.Api.Service.Auth.Input
{
    /// <summary>
    /// TokenRequest
    /// </summary>
    public class ClientCredentialsTokenRequest
    {
        /// <summary>
        /// grant_type
        /// </summary>
        [AliasAs("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// client_id
        /// </summary>
        [AliasAs("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// ClientSecret
        /// </summary>
        [AliasAs("client_secret")]
        public string ClientSecret { get; set; }
    }
}