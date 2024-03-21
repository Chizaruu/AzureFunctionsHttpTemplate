# Azure Functions Http Template

## Overview

This project is a template for creating an Azure Functions application using HTTP triggers. It's structured to provide a clean separation of concerns and organized development practices, designed to work with .NET 8.0 and leveraging several essential NuGet packages for enhanced functionality.

## Features

- HTTP-triggered Azure Functions setup.
- Entity Framework Core integration with SQL Server.
- Application Insights for telemetry data.
- Pre-configured Git settings for better source control management.

## File Structure

- **Data**: Contains the `ApplicationDbContext` for Entity Framework Core and `LogData` model.
- **Extensions**: Includes extension methods for services like DbContext & Services.
- **Functions**: The folder where all HTTP-triggered functions are placed (`ExampleFunctions.cs`).
- **Helpers**: Contains `ApiHelpers` for assisting in function development.
- **Models**: Data models used throughout the application (`Log.cs`).

## Dependencies

The project uses the following packages:

- Azure Functions packages for building function apps.
- Entity Framework Core for object-database mapping.
- Azure Application Insights for monitoring and telemetry.
- Additional packages for extended functionality and JSON handling.

For a full list of dependencies, refer to the included `csproj` file.

## Prerequisites

To work with this template, you'll need:

- .NET SDK 8.0
- Azure Functions Core Tools (for local development)
- An active Azure subscription (for deployment)
- SQL Server (for the database functionality)

## Getting Started

1. Clone the repository to your local machine.
2. Install the prerequisites.
3. Open the solution in your preferred IDE (e.g., Visual Studio).
4. Restore the NuGet packages.
5. Ensure local.settings.json is configured with your local development settings.
6. Run the project to start the local development server.

## Deployment

To deploy the function app to Azure:

1. Set up your Azure Functions environment in the Azure portal. (I suggest `Consumption Plan` for first timers! :3)
2. Configure your deployment source as your Git repository.
3. Push your code to the repository to trigger the CI/CD pipeline.
4. Monitor your deployment in the Azure portal.

For more detailed instructions on deployment, consult the [Azure Functions documentation](https://learn.microsoft.com/en-us/azure/azure-functions/).

## Contribution

Contributions to this template are welcome. Please follow the standard fork-and-pull request workflow. Ensure you adhere to the coding standards and write tests for new features.

## License

This project is licensed under the MIT License - see the LICENSE.txt file for details.

---

For any issues or questions, please open an issue on the project's repository.
