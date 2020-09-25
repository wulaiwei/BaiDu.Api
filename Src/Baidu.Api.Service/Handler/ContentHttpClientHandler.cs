using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace BaidDu.Api.Service.Handler
{
    public class ContentHttpClientHandler:DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
            var content = await response.Content
                .ReadAsStringAsync().ConfigureAwait(false);
            if (content == null || response.StatusCode != HttpStatusCode.OK)
            {
                return response;
            }

            var res = JObject.Parse(content);

            //登录失败时，OAuth返回的失败消息
            var errorDescription = res.Value<string>("error");

            return response;
        }
    }
}