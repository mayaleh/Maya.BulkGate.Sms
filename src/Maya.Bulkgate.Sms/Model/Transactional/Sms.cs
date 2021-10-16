using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model.Transactional
{
    public class Sms : SmsBase
    {
        
        /// <summary>
        /// Recipient phone number
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// Number of BulkGate administrator receiving notification.
        /// </summary>
        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public int? Admin { get; set; }

        /// <summary>
        /// Text of the SMS message (max. 612 characters, or 268 characters, if Unicode is activated), UTF-8 encoding.
        /// It is possible to add variables to the template from the variables array (another parameter) Hello <first_name> <last_name> ....
        /// </summary>
        [JsonRequired]
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// Associative array to add variables to text, for e.g.: {"first_name": "John", "last_name": "Doe"}
        /// </summary>
        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, object> Variables { get; set; }
    }
}
