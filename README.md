# Printpress

Printpress is a multi-project .NET solution that includes a backend API, a frontend Angular application, and supporting application, domain, infrastructure, and database projects.

## Solution structure

- **Printpress.API**: ASP.NET Core Web API entry point.
- **Printpress.Application**: Application-layer services, DTOs, validators, and helpers.
- **Printpress.Domain**: Domain entities, enums, and interfaces.
- **Printpress.Infrastructure**: EF Core context, repositories, migrations, and UoW.
- **Printpress.MigrationRunner**: Console app for applying EF Core migrations and seeding data.
- **Printpress.UI**: .NET wrapper project containing the Angular UI in `Printpress_Angular/`.
- **Printpress.Sql**: SQL Server database project (SSDT).

## Getting started

### Backend API

Open the solution and run the **Printpress.API** project. The entry point is `Printpress.API/Program.cs`.

### Database migrations

Run the **Printpress.MigrationRunner** project to apply EF Core migrations and seed data. Update the connection string in `Printpress.MigrationRunner/appsettings.json` as needed.

### Frontend (Angular)

Change into `Printpress.UI/Printpress_Angular` and use the Angular CLI:

```bash
npm install
ng serve
```

The Angular app runs at `http://localhost:4200/`.

## Notes

Frontend naming conventions are documented in `Developing notes/Frontend/FrontendNotes.txt`.
