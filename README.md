MyBill Backend API

Backend Web API for MyBill — a mobile-first inventory & billing application built with .NET Core 8, EF Core, SQL Server, and REST APIs.

 Tech Stack

.NET Core 8 Web API

Entity Framework Core

SQL Server

C#

Repository + DTO Pattern

JWT Authentication (coming in Phase 2)

React Native frontend (separate repo)

📂 Project Structure (simplified)
MyBill.Api/
 │
 ├── Controllers/
 ├── Data/
 │    └── AppDbContext.cs
 │
 ├── Models/
 ├── DTOs/
 ├── Services/
 ├── Repositories/
 ├── wwwroot/uploads/
 │
 └── Program.cs

🛠 Setup & Run the Project:

1. Restore packages

Open project in Visual Studio → packages auto restore OR run:

dotnet restore

2. Update DB connection string

Set your SQL Server in appsettings.json:

"DefaultConnection": "Server=YOUR_SERVER;Database=MyBillDB;Trusted_Connection=True;"

3. Run EF migrations

Use Package Manager Console:

Add-Migration InitialCreate
Update-Database


This creates the MyBillDB and required tables.

4. Run API

Press F5 or:

dotnet run

 Test Endpoint (Phase 1) :

Health check:

GET /api/health


Test controller:

POST /api/test/create-user
GET /api/test/users



📌 Roadmap
Phase 1 – Backend Setup ✔️ Completed

Project scaffold

Models + DbContext

SQL Server integration

EF migrations

Test APIs

GitHub push

Phase 2 – Authentication (Register/Login + JWT) 🔜
Phase 3 – Product Management API
Phase 4 – Invoice API
Phase 5 – React Native App
Phase 6 – Final polish + screenshots + README updates


 Author : 
      Shivaji Shivaratri