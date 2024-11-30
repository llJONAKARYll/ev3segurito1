using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ev3segurito1.DataBase;

using ev3segurito1.Models;  // Asegúrate de que tu clase 'Users' esté en el espacio de nombres correcto


var builder = WebApplication.CreateBuilder(args);

// Configuración de la cadena de conexión para la base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Configurar otros servicios y MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Rutas y middleware
app.UseAuthentication();  // Asegúrate de que la autenticación esté habilitada
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
