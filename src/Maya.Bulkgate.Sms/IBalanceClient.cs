using System.Threading.Tasks;
using Maya.BulkGate.Sms.Model.Credit;

namespace Maya.BulkGate.Sms
{
    public interface IBalanceClient
    {
        Task<BalanceResponse> CheckCreditBalance();
    }
}