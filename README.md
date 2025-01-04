
# CQRS with Domain Events API

This project demonstrates a basic implementation of the Command and Query Responsibility Segregation (CQRS) pattern with Domain Events in a .NET Core application. It uses MediatR for handling commands and queries, Entity Framework Core for database interaction, and Swagger for API documentation.




## Features

- CQRS Pattern: Separates read and write operations.
- Domain Events: Implements event-driven architecture for handling domain logic.
- Entity Framework Core: Provides data persistence.
- Dependency Injection: Built-in support for DI.
- Swagger Integration: Interactive API documentation.

## Prerequisites

- .NET 9 SDK
- SQL Server


## Getting Started

1.Clone the Repository

```bash
git clone <repository-url>
cd CQRSWithDomainEvents
```
2.Restore Dependencies

```bash
dotnet restore
```
3.Configure the Database

Update the connection string in appsettings.json (located in the API project):

```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=CQRSWithDomainEventsDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```
Ensure the SQL Server service is running on your machine.

4.Apply Migrations

Run the following commands to create and apply migrations:
```bash
dotnet ef migrations add InitialCreate --project CQRSWithDomainEvents.Infrastructure --startup-project CQRSWithDomainEvents.API
dotnet ef database update --project CQRSWithDomainEvents.Infrastructure --startup-project CQRSWithDomainEvents.API
```
5.Run the Application
```bash
dotnet run --project CQRSWithDomainEvents.API
```
The API will be available at http://localhost:<port>.

## Project Structure
```bash
CQRSWithDomainEvents
│
├── CQRSWithDomainEvents.API
│   ├── Controllers
│   ├── Program.cs
│   ├── appsettings.json
│
├── CQRSWithDomainEvents.Application
│   ├── Commands
│   ├── Queries
│   ├── Interfaces
│
├── CQRSWithDomainEvents.Domain
│   ├── Entities
│   ├── Common
│   ├── Events
│
├── CQRSWithDomainEvents.Infrastructure
│   ├── Persistence
│   ├── Repositories
│   ├── Migrations
```
