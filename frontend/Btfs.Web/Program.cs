using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Btfs;
using Btfs.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Dados mock — troque por HttpClient quando a API estiver pronta
builder.Services.AddSingleton<EventService>();

// Estado do carrinho persiste durante a sessão do browser
builder.Services.AddScoped<CartService>();

await builder.Build().RunAsync();
