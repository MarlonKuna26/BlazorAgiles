using BlazorAplicacionAgiles.UI.Client.Pages;
using BlazorAplicacionAgiles.UI.Components;

using BlazorAplicacionAgiles.Application.Interfaces;
using BlazorAplicacionAgiles.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Agrega el servicio de Producto
builder.Services.AddScoped<IProductoService, ProductoService>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorAplicacionAgiles.UI.Client._Imports).Assembly);

app.Run();
