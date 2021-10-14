# Transactional SMS

Before sending any SMS, it is needed to have instance of `Maya.BulkGate.Sms`. See the [Introduction](/articles/intro.md).

In examples of this section (Transactional SMS), the instanced class is in the variable `bulkSmsClient`.

There are two ways to sending transactional SMS.

The first way for sending simplified transactional SMS:

```c#
var result = await bulkSmsClient.Transactional.SendSmsToNumber("447971700001", "test message")
    .ConfigureAwait(false);
```

The second way for more specified input data:

```c#
// specifying the transactional sms model
var sms = new Maya.BulkGate.Sms.Model.Transactional.Sms
{
    Number = "447971700001",
    Text = "Hi <first_name>! Keep coding :-).",
    Variables = new Dictionary<string, object>()
    {
        {"first_name", "Nick"}
    },
    Unicode = true,
    SenderId = "gText",
    Country = "cz"
};

var result = await bulkSmsClient.Transactional.SendSms(sms)
    .ConfigureAwait(false);
```

The both methods in examples will return same type on success [Maya.BulkGate.Sms.Model.Transactional.SmsResult](/api/Maya.BulkGate.Sms.Model.Transactional.SmsResult.html) or will thrown an exception on failure.

In the second way, it is possible to specify more options like variables, sender, scheduling...etc.
For all options and its specifications, see the API documentation of the class [Maya.BulkGate.Sms.Model.Transactional.Sms](/api/Maya.BulkGate.Sms.Model.Transactional.Sms.html) and [Maya.BulkGate.Sms.Model.SmsBase](/api/Maya.BulkGate.Sms.Model.SmsBase.html).
