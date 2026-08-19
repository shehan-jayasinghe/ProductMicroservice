# Product Microservice

A .NET web API project for product management, built on **ASP.NET Core**, **Entity Framework Core**, and **SQL Server**.

## Overview

The solution is structured as an ASP.NET Core web application targeting .NET 8. Entity Framework Core provides ORM and SQL Server integration, while Swashbuckle provides OpenAPI/Swagger support for API exploration and documentation.

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
ASP.NET Core Web API
    |
    +--> Controllers / API Endpoints
    |
    +--> Application / Domain Logic
    |
    v
Entity Framework Core
    |
    v
SQL Server
```

## Repository Structure

```text
ProductMicroservice/
├── ProductMicroservice.sln
├── ProductMicroservice/
│   └── ASP.NET Core application
└── README.md
```

## Data Access

The project references Entity Framework Core and the SQL Server provider. Database access should be configured through the application's normal ASP.NET Core configuration and environment-specific connection strings.

## API Documentation

Swashbuckle is included, allowing the application to expose Swagger/OpenAPI documentation when configured and enabled by the application startup code.

## Development

Restore dependencies and build the solution with:

```bash
dotnet restore
dotnet build
```

Run the application with:

```bash
dotnet run --project ProductMicroservice
```

Run tests when test projects are present:

```bash
dotnet test
```

## Security and Configuration

Do not commit production connection strings, passwords, API keys, or other secrets. Use ASP.NET Core configuration providers and environment-specific secret management for deployed environments.

## Project Status

The repository currently provides the foundation for a product-focused .NET web service, including the application project, SQL Server persistence dependencies, Entity Framework Core, and API documentation support.
