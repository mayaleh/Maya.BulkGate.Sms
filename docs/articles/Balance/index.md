# Credit balance

Before getting balance, it is needed to have instance of `Maya.BulkGate.Sms`. See the [Introduction](/articles/intro.md).

In an examples of this section, the instanced class is in the variable `bulkSmsClient`.

```c#
var balance = await bulkSmsClient.BalanceClient.CheckCreditBalance();

Console.WriteLine($"The credit credit is {balance.Data.Credit}");
```

All available properties on API docs [Maya.BulkGate.Sms.Model.Credit.BalanceResult](/Maya.BulkGate.Sms/api/Maya.BulkGate.Sms.Model.Credit.BalanceResult.html)
