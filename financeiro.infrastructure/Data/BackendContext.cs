using financeiro.ApplicationCore.Entity;
using financeiro.infrastructure.EntityConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace financeiro.infrastructure.Data
{
   public class BackendContext:IdentityDbContext<Usuario>
    {
        public BackendContext(DbContextOptions<BackendContext> options ):base(options)
        {
            

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contato> Contatos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);// corrige :The entity type 'IdentityUserLogin<string>' requires a primary key to be defined
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            modelBuilder.ApplyConfiguration(new ClienteMap());



        }
    }
}
