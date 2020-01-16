using financeiro.ApplicationCore.Entity;
using financeiro.infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace financeiro.infrastructure.Data
{
   public class BackendContext:DbContext
    {
        public BackendContext(DbContextOptions<BackendContext> options ):base(options)
        {


        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contato> Contatos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Contato>().ToTable("Contato");

            modelBuilder.ApplyConfiguration(new ClienteMap());



        }
    }
}
