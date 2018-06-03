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

## Built With

* [.NET Core 2.0](https://www.microsoft.com/net/)
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) - .NET ORM Tool
* [NpgSQL for EF Core](http://www.npgsql.org/efcore/) - PostgreSQL extension for EF
* [Angular 1.6](https://angularjs.org/) - Web Client Javascript Library

Based on original work by Baris Ceviz.
