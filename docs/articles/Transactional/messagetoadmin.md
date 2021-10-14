# Sending message to notification admin

For sending SMS for an Admin manager, it just need to have and `admin` identifier that is available in BulkGate admin manager. Then, sending message this way:

```c#
var result = await bulkSmsClient.Transactional.SendSmsToAdmin(125, "Hello <first_name>, your email is: <email>")
    .ConfigureAwait(false);
```

Where `125` is the admin ID from the BulkGate admin manager and the variales in the text is replaced by the admin values in the admin manager.

Available variables:

| VARIABLE         | MEANING       |
| ---------------- | ------------- |
| `<first_name>`   | First name    |
| `<last_name>`    | Last name     |
| `<phone_number>` | Phone number  |
| `<email>`        | Email address |
