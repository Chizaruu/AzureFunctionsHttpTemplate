using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsHttpTemplate.Extensions;

public static class ServiceExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        //services.AddScoped<IService, Service>()

        return services;
    }
}