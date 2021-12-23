using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using website;
using website.Shared;
using Skclusive.Material.Component;
using Skclusive.Material.Layout;
using Skclusive.Material.Core;
using Skclusive.Core.Component;
using Skclusive.Material.Theme;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.TryAddDocsViewService(
    new DocsViewConfigBuilder()
            .WithIsServer(false)
            .WithIsPreRendering(false)
            //.WithResponsive(true)
            //.WithTheme(Theme.Light)
            .WithDisableBinding(false)
            .WithDisableConfigurer(false)
    .Build()
    );
await builder.Build().RunAsync();

public static class DocksViewExtension
{
    public static void TryAddDocsViewService(this IServiceCollection services, IDocsViewConfig config)
    {
        services.TryAddLayoutServices(config);

        services.TryAddMaterialServices(config);

        services.TryAddScoped<IDocsViewConfig>(sp => config);

        services.TryAddStyleTypeProvider<DocsViewStyleProvider>();

        services.TryAddStyleProducer<DocsViewStyleProducer>();
    }
}

public class DocsViewConfigBuilder : LayoutConfigBuilder<DocsViewConfigBuilder, IDocsViewConfig>
{
    protected class DocsViewConfig: LayoutConfig, IDocsViewConfig { }
    public DocsViewConfigBuilder(): base( new DocsViewConfig())
    {

    }

    protected override DocsViewConfigBuilder Builder()
    {
        return this;
    }

    protected override IDocsViewConfig Config()
    {
        return (IDocsViewConfig)_config;
    }
}

public interface IDocsViewConfig: ILayoutConfig
{

}

