using DotNetConfig;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();

Console.WriteLine($"Environment: {builder.Environment.EnvironmentName}");

builder.Services.AddSingleton<MyService>();

var app = builder.Build();

app.MapGet("/", (MyService service) =>
{
    return Results.Ok(service.GetMessage());
});

app.Run();
