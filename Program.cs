using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TNLOTR;
using Microsoft.Azure.Cosmos;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazorBootstrap();
/*var cosmosClient = new CosmosClient("7Rm8fuA96A42b81vpl48tYeMWX2kBOSgPX0QFhFIbhbA0OPOtOxEDzy6VvX4xnwGQL7ebOCduyVnACDbmE722Q==");
builder.Services.AddSingleton(cosmosClient);*/


await builder.Build().RunAsync();
