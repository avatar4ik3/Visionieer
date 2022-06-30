using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Visionieer;
using Blazored.LocalStorage;
using Visionieer.Models;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
List<Prediction> _predictions = new()
    {
        new(0, "Ты полный 0"),
        new(1, "Ты почетная еденица"),
        new(2, "Ты уверенная в себе двойка"),
        new(3, "Тройка это тоже неплохо"),
        new(4, "Ударная четверка! молодец")
    };

builder.Services.AddSingleton<List<Prediction>>(_predictions);
var app = builder.Build();

await app.RunAsync();
