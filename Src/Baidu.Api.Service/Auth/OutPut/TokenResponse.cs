using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Refit;

namespace BaidDu.Api.Service.Auth.OutPut
{
    public class TokenResponse
    {
        /// <summary>
        /// refresh_token
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// expires_in
        /// </summary>
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// session_key
        /// </summary>
        [JsonProperty("session_key")]
        public string SessionKey { get; set; }

        /// <summary>
        /// access_token
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// scope
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// ScopeList
        /// </summary>
        public List<string> ScopeList => string.IsNullOrWhiteSpace(Scope)
            ? new List<string>()
            : Scope.Split(new[]{" "},StringSplitOptions.RemoveEmptyEntries).ToList();

        /// <summary>
        /// session_secret
        /// </summary>
        [JsonProperty("session_secret")]
        public string SessionSecret { get; set; }
    }
}