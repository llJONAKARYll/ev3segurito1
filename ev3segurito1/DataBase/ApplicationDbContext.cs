using ev3segurito1.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace ev3segurito1.DataBase
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Users> Usuarios { get; set; }
        public DbSet<Registro> Registros { get; set; }
        public DbSet<Respaldos> Respaldos { get; set; } // Asegúrate de que esta línea esté presente
    }
}

