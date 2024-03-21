using AzureFunctionsHttpTemplate.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(s =>
    {
        s.AddApplicationInsightsTelemetryWorkerService();
        s.AddDbContext();
        s.AddServices();
    })
    .ConfigureLogging((context, b) =>
    {
        b.AddFilter("Azure.Core", LogLevel.Warning);
        b.AddFilter("Microsoft.Identity.Client", LogLevel.Warning);
        b.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Warning);
        b.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Warning);
        b.AddFilter("System.Net", LogLevel.Warning);
    })
    .Build();

await host.RunAsync();