# LinqToSQL - Project Context & Interaction Guidelines

## Project Overview
This repository contains an **ASP.NET Core MVC** application targeting **.NET 10.0**. The primary focus of this project is learning and implementing database interactions, LINQ queries, and Object-Relational Mapping (ORM) using **Entity Framework Core** and **PostgreSQL** via `Npgsql.EntityFrameworkCore.PostgreSQL`.

---

## Technical Stack & Configuration
- **Framework:** .NET 10.0 (`net10.0`)
- **SDK:** `Microsoft.NET.Sdk.Web`
- **Language Features:** C# 13+, Nullable Reference Types (`<Nullable>enable</Nullable>`), Implicit Usings (`<ImplicitUsings>enable</ImplicitUsings>`)
- **Key Packages:**
  - `Npgsql` (10.0.3)
  - `Npgsql.EntityFrameworkCore.PostgreSQL` (10.0.3)
  - `Microsoft.EntityFrameworkCore.Design` (10.0.12)
- **Database:** PostgreSQL (default local instance `localhost:5432`, database: `testdb`)

---

## Directory Structure
```
LinqToSQL/
├── Controllers/         # MVC Controllers (e.g., HomeController.cs)
├── Models/              # Domain entities, ViewModels, DTOs
├── Views/               # Razor Views (.cshtml) and layouts
├── wwwroot/             # Client-side static assets (CSS, JS, libraries)
├── appsettings.json     # Application configuration & connection strings
├── Program.cs           # Web application bootstrap, middleware & DI container
└── LinqToSQL.csproj     # Project manifest and NuGet package references
```

---

## Common Workflows & CLI Commands

### Build & Run
- **Build Project:**
  ```bash
  dotnet build
  ```
- **Run Application:**
  ```bash
  dotnet run
  ```
- **Watch Mode:**
  ```bash
  dotnet watch
  ```

### Entity Framework Core Tooling
- **Add Migration:**
  ```bash
  dotnet ef migrations add <MigrationName>
  ```
- **Update Database:**
  ```bash
  dotnet ef database update
  ```
- **Scaffold Existing Database (Reverse Engineering):**
  ```bash
  dotnet ef dbcontext scaffold "<connection-string>" Npgsql.EntityFrameworkCore.PostgreSQL -o Models
  ```

---

## Development Standards & Conventions

### 1. C# & .NET Best Practices
- **File-Scoped Namespaces:** Always use `namespace LinqToSQL.Controllers;` instead of block-scoped namespaces.
- **Nullable Reference Types:** Annotate nullable values explicitly (`string?`, `T?`) and avoid compiler warnings.
- **Dependency Injection:** Register all services and `DbContext` in `Program.cs` using standard ASP.NET Core DI patterns:
  ```csharp
  builder.Services.AddDbContext<AppDbContext>(options =>
      options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
  ```
- **Configuration & Security:** Never hardcode database credentials in source code. Place connection strings in `appsettings.json` (or `appsettings.Development.json` / user-secrets) under `"ConnectionStrings": { "DefaultConnection": "..." }`.

### 2. LINQ & Database Queries
- Prefer asynchronous EF Core operations (`ToListAsync()`, `FirstOrDefaultAsync()`, `AnyAsync()`, etc.) with `CancellationToken` where appropriate.
- Use `.AsNoTracking()` for read-only queries to improve performance and reduce memory allocations.
- Favor explicit LINQ method syntax or query syntax consistently across features.
- Avoid N+1 queries by using `.Include()` / `.ThenInclude()` for eager loading where relational data is required.

### 3. MVC Conventions
- Keep controllers thin by encapsulating business and database logic in dedicated services or repository abstractions when complexity increases.
- Use explicit ViewModels for views rather than passing database entities directly to the presentation layer.

---

## Working with AI / Gemini CLI Guidelines
- **Verification:** Always run `dotnet build` after modifying C# code to ensure there are no syntax errors or breaking warnings.
- **Surgical Edits:** Apply focused, targeted changes without rewriting unrelated boilerplate or auto-generated scaffolding.
- **Tests & Safety:** When adding new database entities, endpoints, or LINQ queries, verify query semantics and null safety.
