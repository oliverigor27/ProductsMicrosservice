using Ocelot.DependencyInjection;

namespace ProductsMicrosservice.Gateway.Extensions;

public static class OcelotConfigurationExtension
{
    public static WebApplicationBuilder OcelotServiceBuilder(this WebApplicationBuilder builder)
    {
        builder.Configuration.AddJsonFile("configuration.json", optional: false, reloadOnChange: true);
        builder.Services.AddOcelot();
        return builder;
    }
}
