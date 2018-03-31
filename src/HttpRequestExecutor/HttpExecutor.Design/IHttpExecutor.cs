using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpExecutor.Design
{
    public interface IHttpExecutor
    {
        Task<TResponse> Get<TResponse>(string uri);
        Task<TResponse> Post<TResponse, TBody>(string uri, TBody body);
        Task Delete(string uri);
    }
}
