
using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model
{
    public class SmsResultBase
    {
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; }

        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public object Detail { get; set; }
    }
}
