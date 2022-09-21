using Pokemones.DATOS;
using Pokemones.DATOS.Entidades;
using Pokemones.DATOS.Repositorios;
using Pokemones.NEGOCIO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<ICalculo, Calculo2>();
builder.Services.AddScoped<IcategoriasRepositorio, CategoriaRepositorio>();
builder.Services.AddScoped<ICategoriaNegocio, CategoriaNegocio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
