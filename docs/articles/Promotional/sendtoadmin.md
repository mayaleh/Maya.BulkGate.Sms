# Send to groups from address book

It is possible to send message to BulkGate administrators. Only `Admin ID` and the text is needed, you can find this identifier in the admin manager of the BulkGate portal.

Sending SMS to admins:


```c#
// specify the admin ids
var admins = new List<int>
{
    24, 94, 55
};

// sending SMS
var resultGroup = await bulkSmsClient.Promotional.SendSmsToAdmins(admins, text: "Hello <first_name>, we sent to your email <email> some content...")
    .ConfigureAwait(false);
```

For sending SMS text for admins, there is the list of available variables:

| VARIABLE         | MEANING       |
| ---------------- | ------------- |
| `<first_name>`   | First name    |
| `<last_name>`    | Last name     |
| `<phone_number>` | Phone number  |
| `<email>`        | Email address |
