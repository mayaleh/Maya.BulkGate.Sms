using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model.Transactional
{
    public class SmsResult : SmsResultBase
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataReuslt Data { get; set; }
    }
}
