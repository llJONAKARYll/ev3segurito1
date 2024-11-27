using ev3segurito1.Models;
using Microsoft.EntityFrameworkCore; // Para trabajar con Entity Framework Core
using ev3segurito1.Models; // Namespace donde están los modelos (User, Registro, etc.)

namespace ev3segurito1.DataBase {
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Users> Usuarios { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Respaldo> Respaldos { get; set; }
    }

}
