using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.AnyHttpClient;
using Maya.AnyHttpClient.Model;
using Maya.BulkGate.Sms.Model;
using Maya.Ext.Rop;

namespace Maya.BulkGate.Sms
{
    public class BaseClient : ApiService
    {
        public BaseClient(IHttpClientConnector httpClientConnenctor) : base(httpClientConnenctor)
        {
        }

        public async Task<Result<TResult, Exception>> SendSmsRequest<TData, TResult>(string path, TData data)
        {
            try
            {
                var uriRequest = new UriRequest(new List<string> { path });

                return await this.HttpPost<TResult>(uriRequest, data)
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                return Result<TResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<TResult, Exception>> EmptyPostAsync<TResult>(string path)
        {
            try
            {
                var uriRequest = new UriRequest(new List<string> { path });

                return await this.HttpPost<TResult>(uriRequest, new() { })
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                return Result<TResult, Exception>.Failed(e);
            }
        }
    }
}
