// ------------------------------------------------------------------------
// MIT License - Copyright (c) Microsoft Corporation. All rights reserved.
// ------------------------------------------------------------------------

using FluentUI.TripPin.Client;
using FluentUI.TripPin.Model;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.FluentUI.AspNetCore.Components;
using Microsoft.OData.Extensions.Client;

var serviceRoot = new Uri("https://services.odata.org/V4/TripPinServiceRW/");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient()
    .ConfigureHttpClientDefaults(config =>
    {
        config.ConfigureHttpClient(client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));
    });
builder.Services.AddODataClient("TripPin").AddHttpClient();
builder.Services.AddScoped<DefaultContainer>(sp =>
{
    var clientFactory = sp.GetRequiredService<IODataClientFactory>();
    var container = clientFactory.CreateClient<DefaultContainer>(serviceRoot, "TripPin");
    container.BuildingRequest += (sender, eventArgs) =>
    {
        eventArgs.Headers.Remove("OData-MaxVersion");
        eventArgs.Headers.Remove("OData-Version");
    };
    return container;
});

builder.Services.AddFluentUIComponents().AddDataGridODataAdapter();

await builder.Build().RunAsync();
