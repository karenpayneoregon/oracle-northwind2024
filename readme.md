# Working with EF Core for Oracle

Learn how to work with Oracle database with Microsoft Entity Framework Core (at this time version 8) database first using EF Power Tools to reverse engineer tables in the database. The database has table names and column names uppercased which will need to be addressed to conform to current coding standards. Rather than data annotations [FluentValidation](https://docs.fluentvalidation.net/en/latest/) NuGet package is used for validation.

## See also

- [FluentValidation tips](https://dev.to/karenpayneoregon/fluentvalidation-tips-c-3olf) for more indepth about FluentValidation


## Connection strings

Are stored in appsettings.json. Once creating the database, add your connection string to `Development` property below.

```json
﻿{
  "ConnectionsConfiguration": {
    "ActiveEnvironment": "Development",
    "Development": "Your connection string",
    "Stage": "Stage connection string goes here",
    "Production": "Prod connection string goes here"
  }
}
```
