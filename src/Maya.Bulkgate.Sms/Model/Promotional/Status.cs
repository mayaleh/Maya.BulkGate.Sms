using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model.Promotional
{
    public class Status
    {
        [JsonProperty("sent", NullValueHandling = NullValueHandling.Ignore)]
        public int Sent { get; set; }

        [JsonProperty("accepted", NullValueHandling = NullValueHandling.Ignore)]
        public int Accepted { get; set; }

        [JsonProperty("scheduled", NullValueHandling = NullValueHandling.Ignore)]
        public int Sheduled { get; set; }

        [JsonProperty("error", NullValueHandling = NullValueHandling.Ignore)]
        public int Error { get; set; }
    }
}
