using Maya.BulkGate.Sms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms
{
    public class Client
    {
        private readonly BaseClient baseClient;

        private readonly IConfig config;

        public Client(IConfig config)
        {
            this.ValidateConfigHard(config);

            this.config = config;

            this.baseClient = InitHttpClient(this.config);
        }

        /// <summary>
        /// Send tarnsactional sms
        /// </summary>
        /// <param name="smsTansactional"></param>
        /// <returns></returns>
        public async Task<Model.SmsResult> SendTansactionalSms(Model.SmsTansactional smsTansactional)
        {
            try
            {
                var result = await this.baseClient.SendSmsRequest<Model.SmsTansactional>(EndpointPaths.AdvancedTransactional, smsTansactional)
                    .ConfigureAwait(false);

                if (result.IsFailure)
                {
                    throw result.Failure;
                }

                return result.Success;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Send promotional sms
        /// </summary>
        /// <param name="smsPromotional"></param>
        /// <returns></returns>
        public async Task<Model.SmsResult> SendPromotianalSms(Model.SmsPromotional smsPromotional)
        {
            try
            {
                var result = await this.baseClient.SendSmsRequest<Model.SmsPromotional>(EndpointPaths.AdvancedPromotional, smsPromotional)
                    .ConfigureAwait(false);

                if (result.IsFailure)
                {
                    throw result.Failure;
                }

                return result.Success;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidateConfigHard(IConfig config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            if (string.IsNullOrEmpty(config.ApplicationId))
            {
                throw new ArgumentNullException(nameof(config.ApplicationId));
            }

            if (string.IsNullOrEmpty(config.ApplicationToken))
            {
                throw new ArgumentNullException(nameof(config.ApplicationToken));
            }

            // it is ok.
        }

        private static BaseClient InitHttpClient(IConfig config)
        {
            try
            {
                var httpConfig = new Maya.AnyHttpClient.Model.HttpClientConnector
                {
                    BodyProperties = new List<Maya.AnyHttpClient.Model.KeyValue>
                {
                    new AnyHttpClient.Model.KeyValue { Name = "application_id", Value = config.ApplicationId },
                    new AnyHttpClient.Model.KeyValue { Name = "application_token", Value = config.ApplicationToken }
                },
                    Endpoint = EndpointPaths.EndpointApi,
                    TimeoutSeconds = 30,
                };

                return new BaseClient(httpConfig);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
