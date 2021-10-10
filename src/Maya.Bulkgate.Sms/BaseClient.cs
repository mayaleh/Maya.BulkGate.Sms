using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.AnyHttpClient;
using Maya.AnyHttpClient.Model;
using Maya.BulkGate.Sms.Model;
using Maya.Ext.Rop;

namespace Maya.BulkGate.Sms
{
    internal class BaseClient : BaseApiService
    {
        public BaseClient(IHttpClientConnector httpClientConnenctor) : base(httpClientConnenctor)
        {
        }

        public async Task<Result<Model.SmsResult, Exception>> SendSmsRequest<T>(string path, T data)
        {
            try
            {
                var uri = BaseApiService.ComposeUri(this.HttpClientConnenctor.Endpoint, new List<string> { path });

                return await this.HttpPost<Model.SmsResult>(uri, data)
                    .ConfigureAwait(false);
            }
            catch (Exception e)
            {
                return Result<Model.SmsResult, Exception>.Failed(e);
            }
        }
    }
}
