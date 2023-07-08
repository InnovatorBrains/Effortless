namespace Effortless.Api;

public static class ConfigureMiddlewares
{
  public static WebApplication AddApiMiddlewares(this WebApplication app)
  {
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
      app.UseSwagger();
      app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    return app;
  }
}
