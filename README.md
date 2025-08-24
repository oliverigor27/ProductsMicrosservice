# Product Microservice

## Overview
This is a **microservice for product management**, developed with **C# and .NET**, designed to provide a **scalable, maintainable, and observable API** for retrieving product data. The system uses **Ocelot** as the API Gateway, **Serilog** for structured logging, and **MiniProfiler** for performance profiling.

---

## Features

- **Retrieve Products:** Fetch a list of products via API endpoints.
- **Observability:** 
  - **Serilog** for structured logging and tracking requests.
  - **MiniProfiler** for performance monitoring and profiling.
- **API Gateway:** Ocelot routes incoming requests to the microservice.
- **Scalable Architecture:** Microservice structure allows easy scaling and future expansion.
- **Database:** Can be connected to SQL Server, PostgreSQL, or any preferred DB.

---

## Architecture

```plaintext
          +----------------+
          |    API Client   |
          +--------+-------+
                   |
                   v
          +----------------+
          |   Ocelot API    |
          |    Gateway      |
          +--------+-------+
                   |
                   v
          +----------------+
          | Product Service |
          +----------------+
                   |
                 Database
````

---

## Tech Stack

* **Backend:** C# / .NET 9
* **API Gateway:** Ocelot
* **Observability:** Serilog, MiniProfiler

---

## Getting Started

### Prerequisites

* [.NET 9 SDK](https://dotnet.microsoft.com/download)
* API testing tool (Postman / Swagger)

### Running the Project

1. Clone the repository:

```bash
git clone https://github.com/yourusername/product-microservice.git
cd ProductMicroservice
```

2. Configure **Ocelot Gateway** (`ocelot.json`) to route requests to the Product Service.

3. Configure database connection strings, Serilog, and MiniProfiler settings in `appsettings.json`.

4. Run the gateway and the microservice:

```bash
cd Gateway
dotnet run

cd ../Products
dotnet run
```

5. Access the API endpoints via **Swagger** or **Postman**.

---

## Logging & Profiling

* **Serilog**: Logs structured request/response information to console or files.
* **MiniProfiler**: Measures and tracks request performance to help identify bottlenecks.
* Both tools can be extended to integrate with external monitoring dashboards.

## License

This project is licensed under the MIT License.
