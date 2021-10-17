# Promotional Sms

Before sending any SMS, it is needed to have instance of `Maya.BulkGate.Sms`. See the [Introduction](/articles/intro.md).

In an examples of this section (Promotional SMS), the instanced class is in the variable `bulkSmsClient`.

## Send to numbers

numbers declaration could be defined like an array of numbers:

```c#
var sms = new Maya.BulkGate.Sms.Model.Promotional.Sms<string>
{
    Number = new List<string>
    {
        "420775123456",
        "420606123456",
        "44771447678"
    },
    Text = "Hi <first_name>"
};

var result = await bulkSmsClient.Promotional.SendSms(sms)
    .ConfigureAwait(false);
```

or as array of objects, where every recipient number could have difference template and variables:

```c#
// define variables
var variablesA = new Dictionary<string, object>();
variablesA.Add("a", 12354);

var variablesB = new Dictionary<string, object>();
variablesB.Add("b", 12354);
variablesB.Add("c", DateTime.Now);
variablesB.Add("d", "abc");

// define sms 
var smsProm = new Maya.BulkGate.Sms.Model.Promotional.Sms<Maya.BulkGate.Sms.Model.Promotional.Number>
{
    Number = new List<Maya.BulkGate.Sms.Model.Promotional.Number>
    {
        new Maya.BulkGate.Sms.Model.Promotional.Number
        {
            PhoneNumber = "789456128",
            Text = "Your code is: <a>",
            Variables = variablesA
        },
        new Maya.BulkGate.Sms.Model.Promotional.Number
        {
            PhoneNumber = "789456123",
            Text = "Your code is: <b>. Generated at <c> for <d>",
            Variables = variablesB
        }
    }
};

// sending SMS
var result = await bulkSmsClient.Promotional.SendSms(smsProm)
    .ConfigureAwait(false);
```

The both methods in examples will return same type on success [Maya.BulkGate.Sms.Model.Promotional.SmsResult](/Maya.BulkGate.Sms/api/Maya.BulkGate.Sms.Model.Promotional.SmsResult.html) or will thrown an exception on failure.

It is possible to specify more options like variables, sender, scheduling...etc.
For all options and its specifications, see the API documentation of the class [Maya.BulkGate.Sms.Model.Promotional.Sms](/Maya.BulkGate.Sms/api/Maya.BulkGate.Sms.Model.Promotional.Sms.html) and [Maya.BulkGate.Sms.Model.SmsBase](/Maya.BulkGate.Sms/api/Maya.BulkGate.Sms.Model.SmsBase.html).
