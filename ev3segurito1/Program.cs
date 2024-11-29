using ev3segurito1.DataBase;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyApp.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configurar la cadena de conexi�n
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Configurar Identity
        builder.Services.AddIdentity<IdentityUser, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>() // Aqu� se registra el DbContext
            .AddDefaultTokenProviders();

        // Agregar controladores y vistas
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Middleware de autenticaci�n y autorizaci�n
        app.UseAuthentication();
        app.UseAuthorization();

        // Configurar rutas
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}