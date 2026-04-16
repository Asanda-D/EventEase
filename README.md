# EventEase - Venue Booking System (CLDV POE Part 1)

## Information
- **Name:** Asanda Dimba  
- **Student Number:** ST10366285  
- **Module:** Cloud Development (CLDV)  
- **Project:** POE Part 1  
- **System Name:** EventEase 

---

# Project Overview

EventEase is a web-based Venue Booking System developed using **ASP.NET Core MVC** and **Entity Framework Core**.  

The system is designed for internal use by EventEase staff to manage:
- Venues
- Events
- Bookings

Booking specialists use the system to create and manage bookings on behalf of clients. The application ensures proper scheduling and prevents conflicts between venues and events.

---

# Technologies Used

- ASP.NET Core MVC  
- Entity Framework Core  
- SQL Server LocalDB  
- C#  
- Razor Views  
- Bootstrap (UI Styling)  
- Visual Studio 2026  

---

# Database Approach

This project uses a **Code-First approach** with Entity Framework Core.

### Key Features:
- Database schema generated from C# models
- Automatic migration handling
- LocalDB used for development
- Supports future migration to Azure SQL Database

---

# Database Setup Instructions

## 1. Prerequisites
Ensure the following are installed:
- Visual Studio 2022 / 2026
- .NET SDK
- SQL Server LocalDB (included with Visual Studio)

---

## 2. Clone Repository

```
git clone <your-repository-url>
```
- Open:
EventEase.sln

## 3. Restore Packages

- In Visual Studio:
- Right-click Solution
- Click Restore NuGet Packages

## 4. Database Connection String

- Ensure appsettings.json contains:
```
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EventEaseDB;Trusted_Connection=True;"
}
```

## 5. Create Database (Migrations)

- Open Package Manager Console and run:
```
Add-Migration InitialCreate
Update-Database
```

## 6. Run Application

Press:
- F5 / IIS Express
- The system will automatically create the database and tables.

## 7. Verify Database

Open:
- SQL Server Object Explorer

Navigate to:
- (localdb)\MSSQLLocalDB → Databases → EventEaseDB

Tables include:
- Venues
- Events
- Bookings
__EFMigrationsHistory

# How to Run the Project
- Clone repository
- Open solution in Visual Studio
- Restore NuGet packages
- Run database migrations
- Start application (IIS Express)

# Author
- Asanda Dimba
- ST10366285
- CLDV POE Part 1 - EventEase System

# License

This project is created for academic purposes as part of a Portfolio of Evidence (POE).
