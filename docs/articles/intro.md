# Get it

Install Maya.Bulkgate.Sms from the nuget.org using package manager console:

```
PM> Install-Package Maya.Bulkgate.Sms
```

To send an SMS, you wil need to get your own `APPLICATION_ID` and `APPLICATION_TOKEN` from [BulkGate portal](https://help.bulkgate.com/docs/en/api-administration.html#how-do-i-get-api-access-data).

After creating API access, you are finally able to send SMS (Transactional SMS):

```c#
var bulkSmsConfig = new Maya.BulkGate.Model.Config("your APPLICATION_ID", "your APPLICATION_TOKEN");

var bulkSmsClient = new Maya.BulkGate.Sms(bulkSmsConfig);

await bulkSmsClient.Transactional.SendSmsToNumber("447971700001", "test message")
    .ConfigureAwait(false);
```

This will send the transactional SMS to the phone number 447971700001 with the content `test message`.