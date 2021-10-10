using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.BulkGate.Sms.Model
{
    public class SmsResult
    {

        [JsonProperty("data", NullValueHandling = NullValueHandling.Ignore)]
        public DataReuslt Data { get; set; }

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
