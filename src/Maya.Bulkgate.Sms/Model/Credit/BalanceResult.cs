using Newtonsoft.Json;
using System;

namespace Maya.BulkGate.Sms.Model.Credit
{
    public class BalanceResult
    {
        [JsonProperty("wallet", NullValueHandling = NullValueHandling.Ignore)]
        public string Wallet { get; set; }

        [JsonProperty("credit", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Credit { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        [JsonProperty("free_messages", NullValueHandling = NullValueHandling.Ignore)]
        public int FreeMessages { get; set; }

        [JsonProperty("datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime Datetime { get; set; }
    }
}
