using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model.Promotional
{
    public class SmsResult : SmsResultBase
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataResult Data { get; set; }
    }
}
