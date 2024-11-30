using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ev3segurito1.DataBase;

using ev3segurito1.Models;  // Aseg�rate de que tu clase 'Users' est� en el espacio de nombres correcto


var builder = WebApplication.CreateBuilder(args);

// Configuraci�n de la cadena de conexi�n para la base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Configurar otros servicios y MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Rutas y middleware
app.UseAuthentication();  // Aseg�rate de que la autenticaci�n est� habilitada
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
