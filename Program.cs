using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Price;
using Price.Exchange;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<ExchangeHandler>();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://economia.awesomeapi.com.br/")
});


await builder.Build().RunAsync();
