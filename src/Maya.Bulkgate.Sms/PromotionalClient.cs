using Maya.BulkGate.Sms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms
{
    public class PromotionalClient : IPromotionalClient
    {
        private readonly BaseClient baseClient;

        public PromotionalClient(BaseClient baseClient)
        {
            if (baseClient is null)
            {
                throw new ArgumentNullException(nameof(baseClient));
            }

            this.baseClient = baseClient;
        }

        /// <summary>
        /// Send promotional sms
        /// </summary>
        /// <param name="smsPromotional"></param>
        /// <returns></returns>
        public async Task<Model.Promotional.SmsResult> SendSms(Model.Promotional.Sms<Model.Promotional.Number> smsPromotional)
        {
            try
            {
                var result = await this.baseClient.SendSmsRequest<Model.Promotional.Sms<Model.Promotional.Number>, Model.Promotional.SmsResult>(EndpointPaths.AdvancedPromotional,
                    smsPromotional)
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
        public async Task<Model.Promotional.SmsResult> SendSms(Model.Promotional.Sms<string> smsPromotional)
        {
            try
            {
                var result = await this.baseClient.SendSmsRequest<Model.Promotional.Sms<string>, Model.Promotional.SmsResult>(EndpointPaths.AdvancedPromotional, smsPromotional)
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
        /// Sending messages to groups from address book. https://help.bulkgate.com/docs/en/http-advanced-promotional-groups.html
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<Model.Promotional.SmsResult> SendSmsToGroups(IEnumerable<int> groups, string text)
        {
            try
            {
                if (groups == null || groups.Any() == false)
                {
                    throw new ArgumentNullException(nameof(groups));
                }

                var sms = new Model.Promotional.Sms<string>()
                {
                    Groups = groups,
                    Text = text
                };

                var result = await this.baseClient.SendSmsRequest<Model.Promotional.Sms<string>, Model.Promotional.SmsResult>(EndpointPaths.AdvancedPromotional, sms)
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
        /// Sending messages to notification admins. https://help.bulkgate.com/docs/en/http-advanced-promotional-admins.html
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public async Task<Model.Promotional.SmsResult> SendSmsToAdmins(IEnumerable<int> admins, string text)
        {
            try
            {
                if (admins == null || admins.Any() == false)
                {
                    throw new ArgumentNullException(nameof(admins));
                }

                var sms = new Model.Promotional.Sms<string>()
                {
                    Admins = admins,
                    Text = text
                };

                var result = await this.baseClient.SendSmsRequest<Model.Promotional.Sms<string>, Model.Promotional.SmsResult>(EndpointPaths.AdvancedPromotional, sms)
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
    }
}
