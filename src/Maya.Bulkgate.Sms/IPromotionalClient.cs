using Maya.BulkGate.Sms.Model.Promotional;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms
{
    public interface IPromotionalClient
    {
        Task<SmsResult> SendSms(Sms<Number> smsPromotional);

        Task<SmsResult> SendSms(Sms<string> smsPromotional);

        /// <summary>
        /// Sending messages to groups from address book. https://help.bulkgate.com/docs/en/http-advanced-promotional-groups.html
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<Model.Promotional.SmsResult> SendSmsToGroups(IEnumerable<int> groups, string text);

        /// <summary>
        /// Sending messages to notification admins. https://help.bulkgate.com/docs/en/http-advanced-promotional-admins.html
        /// </summary>
        /// <param name="groups"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<Model.Promotional.SmsResult> SendSmsToAdmins(IEnumerable<int> admins, string text);
    }
}