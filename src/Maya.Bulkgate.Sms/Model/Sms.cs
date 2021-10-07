using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms.Model
{
    public class Sms
    {
        [JsonRequired]
        [JsonProperty("application_id")]
        public string ApplicationId { get; set; }

        [JsonRequired]
        [JsonProperty("application_token")]
        public string ApplicationToken { get; set; }

        [JsonRequired]
        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonRequired]
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("unicode", NullValueHandling = NullValueHandling.Ignore)]
        public bool Unicode { get; set; }

        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Variables { get; set; }

        [JsonProperty("sender_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderId { get; set; }

        [JsonProperty("sender_id_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderIdValue { get; set; }

        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Schedule { get; set; }
    }
}
