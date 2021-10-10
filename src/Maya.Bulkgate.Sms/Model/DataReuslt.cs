using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model
{
    public class DataReuslt
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }


        [JsonProperty("sms_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SmsId { get; set; }


        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Price { get; set; }


        [JsonProperty("credit", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Credit { get; set; }


        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }
    }

}
