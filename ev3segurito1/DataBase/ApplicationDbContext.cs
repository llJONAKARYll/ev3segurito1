using ev3segurito1.Models;
using Microsoft.EntityFrameworkCore; // Para trabajar con Entity Framework Core
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace ev3segurito1.DataBase
{

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        private System.Data.Entity.DbSet<Users> usuarios;
        private System.Data.Entity.DbSet<Registro> registros;
        private System.Data.Entity.DbSet<Respaldo> respaldos;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
