# Aiico Product API

A simple ASP.NET Core 8 Web API for managing insurance products.

## Features

- Full CRUD for products
- PostgreSQL + Entity Framework Core
- Input validation
- Simple pagination on list endpoint
- Swagger documentation

## Endpoints

| Method | Endpoint              | Description              |
|--------|-----------------------|--------------------------|
| GET    | /api/products         | List products (paginated)|
| GET    | /api/products/{id}    | Get one product          |
| POST   | /api/products         | Create a product         |
| PUT    | /api/products/{id}    | Update a product         |
| DELETE | /api/products/{id}    | Delete a product         |

## Getting Started

1. Update the connection string in `appsettings.json`
2. Apply migrations:
   ```bash
   dotnet ef database update
   ```
3. Run the API:
   ```bash
   dotnet run
   ```
4. Open Swagger: http://localhost:5238/swagger

## Example Request

```json
POST /api/products
{
  "name": "Motor Insurance",
  "description": "Comprehensive motor cover",
  "price": 45000
}
```

## Tech Stack

- .NET 8
- ASP.NET Core Web API
- Entity Framework Core
- PostgreSQL
- Swagger / OpenAPI
