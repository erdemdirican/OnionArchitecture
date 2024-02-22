# Onion Architecture Project

This project is a .NET 7 application developed using Onion architecture principles. We separated the layers of the software by using CQRS and Mediator patterns.

## Architecture

Our project is designed according to the principles of Onion architecture. In this architecture, the layers of the application are organized as nested layers:

- **Domain Layer**: Contains the core business logic of the application. This layer includes business rules, domain models, and domain services.

- **Application Layer**: Facilitates communication with the outside world. Commands, queries, and communication with Mediator are handled in this layer.

- **Infrastructure Layer**: Manages communication with external resources (databases, file systems, external services, etc.). Database access, external service calls, and other infrastructure details are located in this layer.

- **Presentation Layer**: Manages interaction with the user interface and HTTP requests. API controllers, view models, and other presentation layer components reside here.

## Usage

To run the project, you can follow these steps:

1. Clone the repository: `git clone https://github.com/erdemdirican/OnionArchitecture.git`
2. Navigate to the project folder: `cd project`
3. Install dependencies: `dotnet restore`
4. Run the application: `dotnet run`

## Technologies

The project utilizes the following technologies:

- .NET 7
- CQRS (Command Query Responsibility Segregation)
- MediatR
- Entity Framework Core
- ASP.NET Core
