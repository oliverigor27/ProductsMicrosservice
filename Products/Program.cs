WebApplication BuildApp(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddOpenApi();
    builder.Services.AddControllers();
    return builder.Build();
}

void RunApp(WebApplication app)
{
    if (app.Environment.IsDevelopment())
        app.MapOpenApi();
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

RunApp(BuildApp(args));
