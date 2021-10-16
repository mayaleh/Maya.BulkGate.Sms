# Send to groups from address book

It is possible to send message to contacts saved in groups in BulkGate address book. Only `Group ID` and the text is needed:

```c#
// specify the groups
var groups = new List<int>
{
    1, 4
};

// sending SMS
var resultGroup = await bulkSmsClient.Promotional.SendSmsToGroups(groups, text: "Hello <first_name>, we sent to your email <email> some content...")
    .ConfigureAwait(false);
```

For sending SMS text for groups, there is the list of available variables:

| VARIABLE               | MEANING                               |
| ---------------------- | ------------------------------------- |
| `<title_before>`       | Title before the name                 |
| `<first_name>`         | First name                            |
| `<last_name>`          | Last name                             |
| `<title_after>`        | Title after the name                  |
| `<first_name_vokativ>` | First name vokativ for czech language |
| `<last_name_vokativ>`  | Last name vokativ for czech language  |
| `<company_name>`       | Company name                          |
| `<phone_mobile>`       | Mobile phone number                   |
| `<phone>`              | Phone number                          |
| `<email>`              | Email address                         |
| `<fax>`                | Fax                                   |
| `<url>`                | Website address                       |
| `<street1>`            | Street 1                              |
| `<street2>`            | Street 2                              |
| `<city>`               | City                                  |
| `<zip>`                | Zip code                              |
| `<state>`              | Region                                |
| `<country>`            | Country                               |
| `<company_number>`     | Company registration number (CRN)     |
| `<company_vat>`        | VAT                                   |
| `<custom_field_0>`     | Custom field                          |
| `<custom_field_1>`     | Custom field                          |
| `<custom_field_2>`     | Custom field                          |
| `<custom_field_3>`     | Custom field                          |
| `<custom_field_4>`     | Custom field                          |
| `<custom_field_5>`     | Custom field                          |
| `<custom_field_6>`     | Custom field                          |
| `<custom_field_7>`     | Custom field                          |
| `<custom_field_8>`     | Custom field                          |
| `<custom_field_9>`     | Custom field                          |
