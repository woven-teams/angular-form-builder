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

## Built With

* [.NET Core 2.0](https://www.microsoft.com/net/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - .NET ORM Tool
* [NpgSQL for EF Core](http://www.npgsql.org/efcore/) - PostgreSQL extension for EF
* [Angular 1.6](https://angularjs.org/) - Web Client Javascript Library

Based on original work by Baris Ceviz.
