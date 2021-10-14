using Maya.BulkGate.Sms.Model.Transactional;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms
{
    public interface ITransactionalClient
    {
        /// <summary>
        /// Send tarnsactional sms
        /// </summary>
        /// <param name="smsTansactional"></param>
        /// <returns></returns>
        Task<SmsResult> SendSms(Model.Transactional.Sms smsTansactional);

        /// <summary>
        /// Sending message to notification admin. https://help.bulkgate.com/docs/en/http-advanced-transactional-admin.html
        /// </summary>
        /// <param name="admin"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<Model.Transactional.SmsResult> SendSmsToAdmin(int admin, string text);

        /// <summary>
        /// Sending message to phone number.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<Model.Transactional.SmsResult> SendSmsToNumber(string phoneNumber, string text);
    }
}