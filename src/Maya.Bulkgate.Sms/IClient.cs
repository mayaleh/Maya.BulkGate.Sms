namespace Maya.BulkGate.Sms
{
    public interface IClient
    {
        IPromotionalClient Promotional { get; }

        ITransactionalClient Transactional { get; }

        IBalanceClient BalanceClient { get; }
    }
}