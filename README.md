
---

# MES Web Application (ASP.NET Core)

A web-based Manufacturing Execution System (MES) application built with ASP.NET Core (Razor / MVC) to manage production, monitor processes, record data, and provide insights.

## Table of Contents

* [Features](#features)
* [Architecture & Tech Stack](#architecture--tech-stack)
* [Getting Started](#getting-started)

  * [Prerequisites](#prerequisites)
  * [Setup & Installation](#setup--installation)
  * [Database & Migrations](#database--migrations)
  * [Running the Application](#running-the-application)
* [Usage](#usage)
* [Configuration](#configuration)
* [Project Structure](#project-structure)
* [Contributing](#contributing)
* [License](#license)
* [Contact / Support](#contact--support)

---

## Features

* User authentication & authorization
* CRUD operations for master data (e.g. machines, products, shifts)
* Production order tracking & status
* Data logging (e.g. start time, stop time, downtime)
* Dashboard & visual reports
* Export / import via CSV / Excel
* Role-based access control



---

## Architecture & Tech Stack

* **Backend / Web Framework**: ASP.NET Core (Razor Pages / MVC)
* **Frontend**: Razor views, HTML / CSS / (possibly JavaScript / jQuery)
* **Database**: SQL Server (or another relational DB)
* **ORM / Data Access**: Entity Framework Core (or your preferred approach)
* **Migrations / Seeding**: EF Core Migrations / Data seeding
* **Dependency Injection & Service Layer**
* **Logging / Error Handling**
* **Configuration via appsettings.json / environment variables**

---

## Getting Started

### Prerequisites

Make sure you have installed:

* [.NET SDK](https://dotnet.microsoft.com/) (version used by this project, e.g. .NET 6 / .NET 7)
* SQL Server (or SQL Server Express / LocalDB)
* (Optional) Visual Studio 2022 or VS Code

### Setup & Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/ASP-NETProj/MES_WebApplication_ASPNETCore.git
   cd MES_WebApplication_ASPNETCore
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

3. (Optional) Open solution in Visual Studio:

   ```text
   WebApplication1ASPNETCoreBlank(VS2022).sln
   ```

### Database & Migrations

1. Update your connection string in `appsettings.json` (or `appsettings.Development.json`) to point to your SQL Server instance.

2. Apply migrations (if using EF Core):

   ```bash
   dotnet ef database update
   ```

3. (Optional) Seed initial data (if seeding logic is included).

### Running the Application

Run the project:

```bash
dotnet run --project path/to/YourWebProject
```

By default it should launch at `https://localhost:5001` or similar.

Or, run from Visual Studio / VS Code via debugging.

---

## Usage

Once the application is up:

1. Register / sign in (if authentication is implemented)
2. Navigate to dashboards, master data modules
3. Create production orders, monitor execution
4. View reports, filter by date / machine / status
5. Export data to Excel / CSV



---

## Configuration

Key settings are stored in `appsettings.json` (or per-environment files). Typical settings include:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=.;Database=MesDb;Trusted_Connection=True;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```



---

## Project Structure

Here is an example / typical folder layout:

```
/MES_WebApplication_ASPNETCore
│  README.md
│  WebApplication1ASPNETCoreBlank(VS2022).sln
│  /WebApplication1ASPNETCoreBlank
│     /Controllers
│     /Pages or /Views
│     /Models
│     /Data
│     /Services
│     /wwwroot
│     appsettings.json
│     Program.cs / Startup.cs
│  /Migrations
│  /SampleData (csv, xlsx files)
```

You may also have additional helpers, utilities, or shared libraries depending on architecture.

---

## Contributing

Contributions, issues, or suggestions are welcome! Here's how to get started:

1. Fork the repository
2. Create a new branch: `feature/my-feature`
3. Make your changes and commit with clear messages
4. Submit a Pull Request
5. Ensure tests / build are passing

Please adhere to the project’s coding conventions and include documentation / tests for new features.

---

## License


```
MIT License

Copyright (c) 2025 Budi Setiawan

Permission is hereby granted...
```

---

## Contact / Support

* Project maintainers: *Your Name / Team*
* Email: [you@example.com](mailto:you@example.com)
* Issues: Use GitHub Issues for bug reports or feature requests

---

If you like, I can also generate a polished README with badges, screenshots placeholders, and more — would you like me to do that for you?
