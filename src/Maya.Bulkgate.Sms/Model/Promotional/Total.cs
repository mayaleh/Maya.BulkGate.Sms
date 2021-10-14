using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model.Promotional
{
    public class Total
    {
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Price { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Status Status { get; set; }
    }
}
