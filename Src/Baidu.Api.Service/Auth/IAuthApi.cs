using System.Threading;
using System.Threading.Tasks;
using BaidDu.Api.Service.Auth.Input;
using BaidDu.Api.Service.Auth.OutPut;
using Refit;

namespace BaidDu.Api.Service.Auth
{
    public interface IAuthApi
    {
        /// <summary>
        /// 获取AccessToken
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Post("/oauth/2.0/token")]
        Task<TokenResponse> RequestClientCredentialsTokenAsync([Body(BodySerializationMethod.UrlEncoded)]
            ClientCredentialsTokenRequest request);
    }
}