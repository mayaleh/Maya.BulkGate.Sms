using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maya.BulkGate.Sms.Model.Promotional
{
    public class Sms<TNumber> : SmsBase
    {
        /// <summary>
        /// Array of recipients - Value number. Is required or Admins or Groups
        /// </summary>
        [JsonProperty("number")]
        public IEnumerable<TNumber> Number { get; set; }

        /// <summary>
        /// Array of numbers of groups in BulkGate address book. Is required or Number or Admins More info
        /// </summary>
        [JsonProperty("Groups")]
        public IEnumerable<int> Groups { get; set; }

        /// <summary>
        /// Array of numbers of BulkGate administrators receiving notifications. Is required or Groups or Numebr More info
        /// </summary>
        [JsonProperty("admins")]
        public IEnumerable<int> Admins { get; set; }

        /// <summary>
        /// Text of the SMS message (max. 612 characters, or 268 characters, if Unicode is activated), UTF-8 encoding.
        /// Is required if Number is given by the array of numbers or the parameter groups or admin is used
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
