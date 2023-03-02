# ASP.NET - Starter

ASP.NET-Starter is a template project designed to help developers get started with building .NET web applications quickly and easily. The project follows a simple project structure and includes a heavily opinionated approach to Domain Driven Design (DDD). The template includes a Web API project, domain and infrastructure examples, and is designed to be flexible and easily extensible. 

In addition, the project aims to include Docker and Kubernetes deployment files to facilitate easy deployment and scaling in production environments. 

ASP.NET-Starter is aimed at developers who want a starter project for building web applications using .NET.

## Usage

To build and run this project, you will need to have [.NET 6](https://dotnet.microsoft.com/download/dotnet/6.0) installed on your machine.

Once you have installed .NET 6, you can follow these steps to build and run the project:

1. Clone the repository to your local machine: 

```
git clone https://github.com/RohanChhipa/asp.net-starter.git
```

2. Navigate to the project directory:
```
cd asp.net-starter/
```

3. Build the project using the .NET CLI:
```
dotnet build
```
4. Run the project using the .NET CLI:
```
dotnet run --project src/WebAPI/WebAPI.csproj
```
5. Access the web API by opening a browser and navigating to `http://localhost:5030/swagger`.


## Contributing

Contributions are welcome and encouraged! To contribute to this project, please follow these steps:

1. Fork the repository and create your branch from `main`.
1. Make your changes.
1. Submit a pull request, detailing the changes you made and any relevant information.

If you have any questions or suggestions, please open an issue. I'd love to hear from you!

## Change Log

All notable changes to this project will be documented in the [CHANGELOG.md](CHANGELOG.md) file. 

The format of the log entries is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). 

I encourage you to use this `CHANGELOG.md` file as a template for your own projects, to help you keep track of changes and releases in a standardized and organized way.

## Roadmap

In no specific order of priority, future additions include:
- Logging examples using Serilog
- Docker support
- Kubernetes support
- Mapping `appsettings` to a domain model
- Build pipeline using Github Actions

## License

This project is licensed under the terms of the MIT License. See the [LICENSE](LICENSE) file for more information.
