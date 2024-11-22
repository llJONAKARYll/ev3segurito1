using ev3segurito1.Models;
using Microsoft.EntityFrameworkCore; // Para trabajar con Entity Framework Core
using ev3segurito1.Models; // Namespace donde están los modelos (User, Registro, etc.)

namespace ev3segurito1.DataBase {
public class ApplicationDbContext : DbContext
{
    // Constructor que utiliza opciones para configurar la conexión a la base de datos
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    // Tablas representadas como conjuntos de datos (DbSet)
    public DbSet<User> User { get; set; } // Tabla para los usuarios
    public DbSet<Registro> Registro { get; set; } // Tabla para los registros de datos
}
}
