using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPICasino.Entidades;

namespace WebAPICasino
{
    public class ApplicationDbContext : IdentityDbContext //Identity contiene las tablas y roles que permiten el acceso
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<ClienteRifa>()
                //.HasKey(cl => new { cl.ClientesId, cl.RifasId });
        }


        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Rifa> Rifas { get; set; }

    }
}
