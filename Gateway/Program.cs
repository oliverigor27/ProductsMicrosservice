using Ocelot.Middleware;
using ProductsMicrosservice.Gateway.Extensions;

WebApplication BuildApp(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddOpenApi();
    builder.OcelotServiceBuilder();
    return builder.Build();
}

async Task RunApp(WebApplication app)
{
    if (app.Environment.IsDevelopment())
        app.MapOpenApi();
    app.UseHttpsRedirection();
    await app.UseOcelot();
    app.Run();
}

await RunApp(BuildApp(args));
