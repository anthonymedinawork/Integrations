![Forbury](https://portal.forbury.com/assets/img/logo_text.png)﻿
# Forbury Integrations
 
 [![NuGet](https://img.shields.io/nuget/v/Forbury.Integrations)](https://www.nuget.org/packages/Forbury.Integrations)
 [![Licence](https://img.shields.io/github/license/Forbury/Integrations)](LICENCE.txt)

This C# client library provides an easy way for integrating with Forbury external APIs.

**_Note:_** In order to use this library, you must be an existing Forbury customer and have an API `ClientId` and `ClientSecret`.
To learn more about becoming a Forbury customer, or if you already are and would like access, please [contact us](https://www.forbury.com/contact-us).

## Documentation

Full **API documentation** can be found [here](https://api.forbury.com/docs).

## Setup
In order to get started, please follow these steps.

**1.** Install the NuGet package using one of the following commands

_Package Manager_
```
Install-Package Forbury.Integrations -Version 1.0.0
```

_.NET CLI_
```
dotnet add PROJECT package Forbury.Integrations --version 1.0.0
```
For a full list of the latest releases, please see the [package release page](https://www.nuget.org/packages/Forbury.Integrations).

**2.** Add the following to your `appsettings.config` (replace `YOUR_CLIENT_ID` and `YOUR_CLIENT_SECRET`)

```json
"Forbury": {
  "Api": {
    "Url": "https://api.forbury.com/",
  },
  "Authentication": {
    "Url": "https://account.forbury.com/",
    "ClientId": "YOUR_CLIENT_ID",
    "ClientSecret": "YOUR_CLIENT_SECRET"
  } 
}
```

**3.** Add the following inside your `Startup.cs` (replace `V1` with the appropriate [version](#Versions) depending on your requirements)

```C#
public IConfiguration Configuration { get; }

public void ConfigureServices(IServiceCollection services)
{
    ...          
    services.AddForburyApiV1(Configuration);
    ...
}
```

You should now be ready to use the API!

## Usage

Example usage inside a Service.

```C#
public class ForburyDataService
{
    private readonly IForburyApiService _forburyApiService;

    public ForburyDataService(IForburyApiService forburyApiService)
    {
        _forburyApiService = forburyApiService;
    }

    public async Task<PagedResult<TeamDto>> GetTeams(int amount = 20, int page = 1)
    {
        return await _forburyApiService.GetTeams(amount, page);
    }

    public async Task<PagedResult<ModelDto>> GetModelDataForTeam(int id, DateTime? fromDate = null)
    {
        return await _forburyApiService.GetModelDataForTeam(id, fromDate);
    }
}
```
## Versions

Currently available API versions:
- V1

