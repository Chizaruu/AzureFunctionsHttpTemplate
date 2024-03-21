using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsHttpTemplate.Extensions;

public static class TelemetryExtensions
{
    public static IServiceCollection ConfigureTelemetry(this IServiceCollection services)
    {
        // Configure Application Insights and any custom telemetry here
        services.AddApplicationInsightsTelemetryWorkerService();

        return services;
    }
}