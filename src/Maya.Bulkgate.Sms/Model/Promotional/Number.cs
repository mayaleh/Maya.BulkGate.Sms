using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model.Promotional
{
    public class Number
    {
        [JsonProperty("number")]
        public string PhoneNumber { get; set; }


        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Associative array to add variables to text, for e.g.: {"first_name": "John", "last_name": "Doe"}
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Variables { get; set; }
    }
}
