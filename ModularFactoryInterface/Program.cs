using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.SignalR.Client;
using ModularFactoryInterface;
using ModularFactoryInterface.IServices;
using ModularFactoryInterface.Services;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<HubConnection>(e => new HubConnectionBuilder().WithUrl($"http://172.17.14.61/ConfigureSvgHub").Build());
builder.Services.AddHttpClient<ISvgService, SvgService>(httpClient =>
{
    httpClient.BaseAddress = new Uri("http://172.17.14.61/");
});
builder.Services.AddMudServices();

await builder.Build().RunAsync();
