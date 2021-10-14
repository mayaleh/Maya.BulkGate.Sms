using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model.Credit
{
    public class BalanceResponse
    {
        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public BalanceResult Data { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public string Error { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public int Code { get; set; }
    }
}
