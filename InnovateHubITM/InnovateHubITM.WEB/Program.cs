using CurrieTechnologies.Razor.SweetAlert2;
using InnovateHubITM.WEB;
using InnovateHubITM.WEB.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//HttpClient para consumir el api desde la web

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7000/") });

//inyecci�n del Repository
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddSweetAlert2();


await builder.Build().RunAsync();
