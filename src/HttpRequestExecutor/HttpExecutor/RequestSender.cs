using HttpExecutor.Design;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpExecutor
{
    public class RequestSender : IRequestSender
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<HttpResponseMessage> Send(HttpRequestMessage request)
        {
            var response = await httpClient.SendAsync(request).ConfigureAwait(false);
            return response;
        }
    }
}
