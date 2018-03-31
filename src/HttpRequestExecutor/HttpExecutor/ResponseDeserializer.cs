using HttpExecutor.Design;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpExecutor
{
    public class ResponseDeserializer : IResponseDeserializer
    {
        public async Task<T> Deserialize<T>(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
