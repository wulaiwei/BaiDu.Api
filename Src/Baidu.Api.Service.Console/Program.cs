using System;
using System.Threading;
using System.Threading.Tasks;
using BaidDu.Api.Service.Auth;
using BaidDu.Api.Service.Auth.Input;
using Refit;

namespace BaidDu.Api.Service.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var gitHubApi = RestService.For<IAuthApi>("https://aip.baidubce.com");
            var data= await gitHubApi.RequestClientCredentialsTokenAsync(new ClientCredentialsTokenRequest
            {
                ClientId = "An4jZfZqdBuDfxa2Hm4YvTW2",
                ClientSecret = "E7VQqlANG6uKLbDrktzknqBK1k7BC7qj",
                GrantType = "client_credentials"
            });
        }
    }
}