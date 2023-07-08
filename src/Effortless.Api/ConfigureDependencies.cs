using Effortless.Core;
namespace Effortless.Api;

public static class ConfigureDependencies
{
  public static IServiceCollection AddApiDependencies(this IServiceCollection services)
  {
    services.AddCoreDependencies();
    services.AddEndpointsApiExplorer();
    services.AddSwaggerGen();
    return services;
  }
}
