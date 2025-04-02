# Web API Training Project

- this is a personal training project using **ASP.NET Core Web API**, following Clean Architecture principles.

## Project Structure

- **ApiDemo.Api** - web API entry point
- **ApiDemo.Application** - Application layer with use cases
- **ApiDemo.Common** - Shared helpers and constants
- **ApiDemo.Domain** - Domain models and logic
- **ApiDemo.Infrastructure** - Data access and external serices
- **AppiDemo.UnitTests** - Unit tests using xUnit

## Technologies

- .NET 8 
- MediatR
- Dapper
- Dependency Injection
- xUnit (testing)
- clean Architecture approach

## Purpose
This project is intented for learning and practicing backend architecture patterns in .NET

## How to run
1. clone the repo:
2. Resote Packages: dotnet restore
3. Run the API: dotnet run --project ApiDemo.Api
