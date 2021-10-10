using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms.Model
{
    public class Config : IConfig
    {
        /// <summary>
        /// Application ID see https://help.bulkgate.com/docs/en/api-administration.html#what-is-application-id
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Application token see https://help.bulkgate.com/docs/en/api-tokens.html#what-is-an-api-token
        /// </summary>
        public string ApplicationToken { get; set; }
    }
}
