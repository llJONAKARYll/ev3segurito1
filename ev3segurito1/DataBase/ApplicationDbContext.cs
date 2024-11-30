using ev3segurito1.Models;
using Microsoft.EntityFrameworkCore;

namespace ev3segurito1.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Registro> Registro { get; set; }
        public DbSet<Respaldo> Respaldos { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }

        public DbSet<Users> Usuario {  get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
