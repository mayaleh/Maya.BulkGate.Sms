using Maya.BulkGate.Sms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms
{
    public class TransactionalClient : ITransactionalClient
    {

        private readonly BaseClient baseClient;

        public TransactionalClient(BaseClient baseClient)
        {
            if (baseClient is null)
            {
                throw new ArgumentNullException(nameof(baseClient));
            }

            this.baseClient = baseClient;
        }


        /// <summary>
        /// Send tarnsactional sms
        /// </summary>
        /// <param name="smsTansactional"></param>
        /// <returns></returns>
        public async Task<Model.Transactional.SmsResult> SendSms(Model.Transactional.Sms smsTansactional)
        {
            try
            {
                var result = await this.baseClient.SendSmsRequest<Model.Transactional.Sms, Model.Transactional.SmsResult>(EndpointPaths.AdvancedTransactional, smsTansactional)
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
        /// Sending message to notification admin. https://help.bulkgate.com/docs/en/http-advanced-transactional-admin.html
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<Model.Transactional.SmsResult> SendSmsToAdmin(int admin, string text)
        {
            try
            {
                var smsTansactional = new Model.Transactional.Sms
                {
                    Admin = admin,
                    Text = text
                };

                return await this.SendSms(smsTansactional);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Sending message to phone number.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<Model.Transactional.SmsResult> SendSmsToNumber(string phoneNumber, string text)
        {
            try
            {
                var smsTansactional = new Model.Transactional.Sms
                {
                    Number = phoneNumber,
                    Text = text
                };

                return await this.SendSms(smsTansactional);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
