using Ocelot.Middleware;
using ProductsMicrosservice.Gateway.Extensions;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .Enrich.FromLogContext()
    .CreateLogger();

WebApplication BuildApp(string[] args)
{
    
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddOpenApi();
    builder.Host.UseSerilog();
    builder.Services.AddMiniProfiler(options => {
        options.RouteBasePath = "/profiler";
    });
    builder.OcelotServiceBuilder();
    return builder.Build();
}

async Task RunApp(WebApplication app)
{
    if (app.Environment.IsDevelopment())
        app.MapOpenApi();
    app.UseHttpsRedirection();
    app.UseMiniProfiler();
    await app.UseOcelot();
    app.Run();
}

await RunApp(BuildApp(args));
