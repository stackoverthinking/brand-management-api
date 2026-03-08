Brand CRUD API



A simple RESTful API built with ASP.NET Core Web API for managing brands.

This project demonstrates basic CRUD operations using Entity Framework Core and SQL Server.



Tech Stack:

\* ASP.NET Core Web API

\* Entity Framework Core

\* SQL Server

\* Swagger (OpenAPI)



Features:

\* Create a brand

\* Get all brands

\* Get brand by ID

\* Update brand

\* Delete brand



API Endpoints:



GET    /api/brands      Get all brands

GET    /api/brands/{id} Get brand by id

POST   /api/brands      Create a new brand

PUT    /api/brands/{id} Update brand

DELETE /api/brands/{id} Delete brand



Example Request:

json

{

  "name": "Oppo",

  "category": "Cameraphone",

  "isActive": true

}



Run project then open:

/swagger



https://localhost:{port}/swagger

