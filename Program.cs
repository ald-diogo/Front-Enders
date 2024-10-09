using CadastroNotasEstudantes.Services;
using CadastroProfessores.Services;
using FrontEnd_SIGA;
using FrontEnd_SIGA.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<ProfessorService>();

builder.Services.AddSingleton<NotaService>();

builder.Services.AddSingleton<EstudanteService>();

builder.Services.AddSingleton<UsuarioService>();

await builder.Build().RunAsync();
