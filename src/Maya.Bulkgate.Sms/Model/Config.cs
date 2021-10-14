namespace Maya.BulkGate.Sms.Model
{
    public class Config : IConfig
    {
        public Config()
        {

        }

        public Config(string appId, string appToken)
        {
            this.ApplicationId = appId;
            this.ApplicationToken = appToken;
        }

        /// <summary>
        /// Application ID see https://help.bulkgate.com/docs/en/api-administration.html#what-is-application-id
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Application token see https://help.bulkgate.com/docs/en/api-tokens.html#what-is-an-api-token
        /// </summary>
        public string ApplicationToken { get; set; }
    }
}
