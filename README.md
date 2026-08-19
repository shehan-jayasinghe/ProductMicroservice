# Product Microservice

A .NET web API for product management using ASP.NET Core, Entity Framework Core, and SQL Server.

## Technology Stack

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- Swagger / OpenAPI
- C# nullable reference types

## Architecture

```text
HTTP Client
    |
    v
ASP.NET Core API
    |
    +--> Controllers / Endpoints
    |
    +--> Application / Domain Logic
    |
    v
Entity Framework Core
    |
    v
SQL Server
```

## Development

```bash
dotnet restore
dotnet build
dotnet run --project ProductMicroservice
dotnet test
```

## Data Access

Entity Framework Core provides ORM-based database access with SQL Server integration. Configure connection strings through ASP.NET Core configuration and environment-specific settings.

## API Documentation

Swagger/OpenAPI support is included for exploring and documenting API endpoints when enabled by the application.

## Security

Never commit production passwords, connection strings, API keys, or other secrets. Use environment variables or a managed secret store for deployed environments.

## Project Status

The repository provides a product-focused .NET web service foundation with API, persistence, and documentation support.