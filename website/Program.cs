using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using webpage;
using Skclusive.Material.Component;
using Skclusive.Material.Core;
using Skclusive.Core.Component;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.TryAddMaterialServices(
    new MaterialConfigBuilder()
            .WithIsServer(false)
            .WithIsPreRendering(false)
            //.WithResponsive(true)
            .WithTheme(Theme.Light)
            .WithDisableBinding(false)
            .WithDisableConfigurer(false)
    .Build()
    );
await builder.Build().RunAsync();

