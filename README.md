# Form Builder – Sample Project

## Setup

1. Make sure you've worked through the prep guide to install the necessary
   dependencies (.NET, Visual Studio, and Postgres).
2. We recommend creating a "Web + API" run configuration for the solution.
   This allows you to easily run both the Web and API projects with a single
   click.
3. Update `FormBuilder.API/appsettings.development.json` with the
   username, password, host, and database for your local Postgres instance.
4. Run the Web + API configuration. It should automatically migrate and seed
   your Postgres database.

You can also use [dotnet-cli](https://github.com/dotnet/cli) if you prefer a CLI
to Visual Studio.

**If you are running Visual Studio on Mac or Linux**: Change the `baseApiUrl`
port in `FormBuilder.Web/wwwroot/js/app.js` from `50730` to `50731`. On Windows,
Visual Studio proxies requests on port `50730` via IIS Express to `50731`.

## Run configuration

### Windows

1.  Right click on the top-level Solution (not a folder/Project) and select "Properties"
2.  Under Common Properties > Startup Project, select "Multiple Startup Projects"
3.  For `FormBuilder.API` and `FormBuilder.Web`, change the Action to "Start"

### MacOS

1.  Right click on the top-level Solution (not a folder/Project) and select "Options"
2.  Under Run > Configurations, create a new configuration
3.  Double click the new configuration. Check `FormBuilder.API` and `FormBuilder.Web`

### Linux

Run configurations have not been tested on Linux, but they should be similar to MacOS. Let us know if you are completing this exercise on a Linux machine and we will help you get set up.

## Built With

* [.NET Core 2.0](https://www.microsoft.com/net/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - .NET ORM Tool
* [NpgSQL for EF Core](http://www.npgsql.org/efcore/) - PostgreSQL extension for EF
* [Angular 1.6](https://angularjs.org/) - Web Client Javascript Library

Based on original work by Baris Ceviz.
