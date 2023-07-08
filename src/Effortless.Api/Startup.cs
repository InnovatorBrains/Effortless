using Effortless.Api;
using Effortless.Api.Definations;
using Effortless.Core.Services.Logger;

using Serilog;

try
{
    LoggerService.EnsureInitialized();
    Log.Information($"{AppConstants.AssemblyInfo.Name} Booting Up..");

    var builder = WebApplication.CreateBuilder(args);
    {
        // Add services to the container.
        builder.Services.AddApiDependencies();
    }

    var app = builder.Build();
    {
        app.AddApiMiddlewares();
        app.Run();
    }
}
catch (Exception ex) when (!ex.GetType().Name.Equals("StopTheHostException", StringComparison.Ordinal))
{
    LoggerService.EnsureInitialized();
    Log.Error($"{AppConstants.AssemblyInfo.Name} Shutting down...");
    Log.Fatal(ex, "Unhandled exception");
    throw;
}
finally
{
    LoggerService.EnsureInitialized();
    Log.Error($"{AppConstants.AssemblyInfo.Name} Shutting down...");
    Log.CloseAndFlush();
}