using Effortless.Api;

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