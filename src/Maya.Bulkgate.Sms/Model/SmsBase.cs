using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace Maya.BulkGate.Sms.Model
{
    public class SmsBase
    {
        /// <summary>
        /// Application ID see https://help.bulkgate.com/docs/en/api-administration.html#what-is-application-id
        /// </summary>
        [JsonRequired]
        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Application token see https://help.bulkgate.com/docs/en/api-tokens.html#what-is-an-api-token
        /// </summary>
        [JsonRequired]
        [JsonProperty("application_token")]
        public string ApplicationToken { get; set; }
    }
}
