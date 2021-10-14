using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.BulkGate.Sms.Model.Promotional
{
    public class DataResult
    {
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public Total Total { get; set; }

        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<SmsResultBase> Response { get; set; }
    }
}
