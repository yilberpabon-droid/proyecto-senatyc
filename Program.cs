using Microsoft.EntityFrameworkCore;
using proyecto_pabon_yilber.Data;
using proyecto_pabon_yilber.implementacion;
using proyecto_pabon_yilber.services;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<dbcontex>(options =>
 options.UseNpgsql(connectionString)
 );

builder.Services.AddScoped<IUsuarioService, UsuarioServices>();
builder.Services.AddScoped<IPasswordservices, passwordservices>(); 
builder.Services.AddControllersWithViews();

// Add services to the container.
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
