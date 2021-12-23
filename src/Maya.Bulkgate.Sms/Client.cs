using Maya.BulkGate.Sms.Model;
using System;
using System.Collections.Generic;

namespace Maya.BulkGate.Sms
{
    public class Client : IClient
    {
        private readonly BaseClient baseClient;

        private readonly IConfig config;

        public IPromotionalClient Promotional { get; }

        public ITransactionalClient Transactional { get; }

        public IBalanceClient BalanceClient { get; }

        public Client(IConfig config)
        {
            ValidateConfigHard(config);

            this.config = config;

            this.baseClient = InitHttpClient(this.config);

            Promotional = new PromotionalClient(this.baseClient);

            Transactional = new TransactionalClient(this.baseClient);

            BalanceClient = new BalanceClient(this.baseClient);
        }

        private static void ValidateConfigHard(IConfig config)
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
                    Headers = new List<Maya.AnyHttpClient.Model.KeyValue>
                    {
                        new AnyHttpClient.Model.KeyValue { Name = "X-BulkGate-Application-Product", Value = "maya-sdk"}
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
