using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Form.UI;
using MudBlazor.Services;
using MudExtensions.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient {
      BaseAddress = new Uri("http://168.197.48.101:3009"),
      Timeout = TimeSpan.FromMinutes(10)
     });
builder.Services.AddMudServices();
builder.Services.AddMudExtensions();

await builder.Build().RunAsync();
