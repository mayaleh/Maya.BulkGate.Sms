using Maya.BulkGate.Sms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms
{
    public class BalanceClient : IBalanceClient
    {
        private readonly BaseClient baseClient;

        public BalanceClient(BaseClient baseClient)
        {
            if (baseClient is null)
            {
                throw new ArgumentNullException(nameof(baseClient));
            }

            this.baseClient = baseClient;
        }

        public async Task<Model.Credit.BalanceResponse> CheckCreditBalance()
        {
            try
            {
                var result = await this.baseClient.EmptyPostAsync<Model.Credit.BalanceResponse>(EndpointPaths.AdvancedInfo)
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
