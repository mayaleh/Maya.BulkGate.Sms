namespace Maya.BulkGate.Sms.Model
{
    public interface IConfig
    {
        /// <summary>
        /// Application ID see https://help.bulkgate.com/docs/en/api-administration.html#what-is-application-id
        /// </summary>
        string ApplicationId { get; set; }

        /// <summary>
        /// Application token see https://help.bulkgate.com/docs/en/api-tokens.html#what-is-an-api-token
        /// </summary>
        string ApplicationToken { get; set; }
    }
}