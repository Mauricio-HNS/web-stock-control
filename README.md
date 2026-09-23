# Web Stock Control

Web application for inventory management, built with C# and ASP.NET Core.

## Project history

This is an earlier project from my .NET development journey. The original goal was deliberately simple: model products and inventory operations through a web application.

The repository is preserved as a historical step rather than being presented as a modern architecture that it was not.

## What it demonstrates

- ASP.NET Core MVC
- Entity Framework Core
- SQLite
- Razor views
- inventory CRUD
- server-side web application structure

## Architecture

```text
Browser
   ↓
ASP.NET Core MVC
   ├── Controllers
   ├── Views
   └── Models / Data
          ↓
       SQLite
```

## Historical technology

The project targets .NET 5 and uses the package ecosystem from that period. .NET 5 is no longer a current supported runtime, so this repository should be considered a legacy portfolio project.

A future modernization should be treated as a controlled migration with dependency and behavior verification.

## Evolution

```text
Basic MVC
   ↓
Database persistence
   ↓
Business rules
   ↓
API-oriented architecture
   ↓
Clean Architecture / DDD
   ↓
Cloud / distributed systems
```

## Status

Historical project — documented and preserved as part of my progression with .NET.

## Future modernization

- migrate to a supported .NET release
- introduce automated tests
- separate application/domain concerns
- move configuration to environment-specific settings
- add structured logging
- containerize the application
