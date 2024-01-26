# Clean Architecture Template

## Project Introduction

![clean-architecture-model](https://fruitbox.blob.core.windows.net/project/readme/clean-architecture-model.webp)

## Project Structure

### Domain

* Domain layer is used to store the **core business domain**.

>|-- Domain
>|   |-- Entities
>|   |-- Enums
>|   |-- Constants
>|-- GloblaUsings.cs

### Application

* Application layer is used to handle the **process of business rules**.

>|-- Application
>|   |-- Common
>|   |   |-- Interfaces
>|   |   |-- Exceptions
>|   |-- Use Case
>|   |   |-- TodoItems
>|   |   |-- TodoLists
>|-- DependencyInjection.cs
>|-- GloblaUsings.cs

### Infrastructure

* Infrastructure layer is used to interact with **external resource**.

>|-- Infrastructure
>|   |-- Common
>|   |-- Data
>|   |   |-- Configurations
>|   |-- ApplicationDbContext.cs
>|   |-- Networks
>|-- DependencyInjection.cs
>|-- GloblaUsings.cs

### Web

* Web layer is used to set up **project config and api endpoint**.

```bash
├── Web \
│ ├── Constants \
│ └── Endpoints \
│ └── Filters \
│ └── Infrastructure \
│ └── Middleware \
├── Program.cs
``````

## Tech Stack

### Program

* [.NET 8](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
* [Entity Framework Core 8](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-8.0/whatsnew)
* [MediatR](https://github.com/jbogard/MediatR)

### Test

* [NSubstitute](https://nsubstitute.github.io/)
* [FluentAssertions](https://fluentassertions.com/introduction)
* [MockQueryable.NSubstitute](https://github.com/romantitov/MockQueryable)
