using AzureFunctionsHttpTemplate.Data;
using AzureFunctionsHttpTemplate.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsHttpTemplate.Extensions;

public static class DbContextExtensions
{
    public static IServiceCollection AddDbContext(this IServiceCollection services)
    {
        var connectionString = Environment.GetEnvironmentVariable("SqlServerConnectionString");
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString,
            b => b.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)),
            ServiceLifetime.Transient
        );

        services.AddScoped<ILogData, LogData>();

        return services;
    }
}