using Fluxor;
using Fluxor.Blazor.Persistence;
using Fluxor.Blazor.Web.ReduxDevTools;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StatePresistanceProject;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddFluxor(options =>
{
    options.UseRouting();
    options.ScanAssemblies(typeof(Program).Assembly)
    .UsePersistence(x => x.PersistenceType = PersistenceType.SessionStorage);
    options.UseReduxDevTools();
});




await builder.Build().RunAsync();
