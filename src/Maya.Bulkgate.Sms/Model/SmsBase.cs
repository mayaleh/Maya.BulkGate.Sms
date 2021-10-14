using Newtonsoft.Json;
using System;

namespace Maya.BulkGate.Sms.Model
{
    public class SmsBase
    {
        /// <summary>
        /// true for Unicode SMS, false for 7bit SMS
        /// </summary>
        [JsonProperty("unicode", NullValueHandling = NullValueHandling.Ignore)]
        public bool Unicode { get; set; }

        /// <summary>
        /// Sender id types:
        /// <list type="table">
        ///     <listheader>
        ///         <term>Value</term>
        ///         <description>Meaning</description>
        ///    </listheader>
        ///    <item>
        ///        <term>gSystem</term>
        ///        <description>System number</description>
        ///    </item>
        ///    <item>
        ///        <term>gShort</term>
        ///        <description>Short Code</description>
        ///    </item>
        ///    <item>
        ///        <term>gText</term>
        ///        <description>Text sender</description>
        ///    </item>
        ///    <item>
        ///        <term>gMobile</term>
        ///        <description>Mobile Connect - Sends SMS message throught Mobile Connect app</description>
        ///    </item>
        ///    <item>
        ///        <term>gPush</term>
        ///        <description>Mobile Connect push - Sends a notification to the Mobile Connect app</description>
        ///    </item>
        ///    <item>
        ///        <term>gOwn</term>
        ///        <description>Own number (requires number verification)</description>
        ///    </item>
        ///    <item>
        ///        <term>int number</term>
        ///        <description>BulkGate Profil ID</description>
        ///    </item>
        /// </list>
        /// </summary>
        [JsonProperty("sender_id", NullValueHandling = NullValueHandling.Ignore)]
        public object SenderId { get; set; }

        /// <summary>
        /// Sender value gOwn, gText, gMobile, or gPush (if gMobile, or gPush used, please supply mobile connect key as sender_id_value)
        /// </summary>
        [JsonProperty("sender_id_value", NullValueHandling = NullValueHandling.Ignore)]
        public string SenderIdValue { get; set; }


        /// <summary>
        /// Provide recipient numbers in international format (with prefix, for e.g 44), or add country code (7820125799 + GB = 447820125799).
        /// See the example of a country requirement.
        /// If the value is null, your set time zone will be used to fill in the information
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// Schedule the sending time and date in unix timestamp, or ISO 8601.
        /// </summary>
        [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Schedule { get; set; }

        /// <summary>
        /// Message label for subsequent retrieval of the user.
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// Select on to prevent sending duplicate messages to the same phone number.
        /// Messages with the same text sent to the same number will be removed if there is a time interval shorter than 5 mins. If off no duplicates will be removed.
        /// Supported values:
        /// <list type="bullet">
        ///    <item>
        ///        <term>on</term>
        ///        <description>prevent sending duplicate</description>
        ///    </item>
        ///    <item>
        ///        <term>off</term>
        ///        <description>Default value. No duplicates checking.</description>
        ///    </item>
        /// </list>
        /// </summary>
        [JsonProperty("duplicates_check", NullValueHandling = NullValueHandling.Ignore)]
        public string DuplicatesCheck { get; set; }
    }
}
