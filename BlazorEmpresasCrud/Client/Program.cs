using BlazorEmpresasCrud;
using BlazorEmpresasCrud.Database;
using BlazorEmpresasCrud.Services;
using BlazorEmpresasCrud.Services.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;

namespace BlazorEmpresasCrud
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            //Banco de dados em memória
            builder.Services.AddDbContext<BlazorContext>(options=>options.UseInMemoryDatabase("EmpresasDb"));
            //Injeção de dependência dos services:
            builder.Services.AddScoped<IEmpresaService, EmpresaService>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }
    }
}