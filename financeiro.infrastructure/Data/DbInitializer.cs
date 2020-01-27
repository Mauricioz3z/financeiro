using financeiro.ApplicationCore.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace financeiro.infrastructure.Data
{
   public static class DbInitializer
    {

        public static void Initialize(BackendContext context)
        {

            if (!context.Users.Any())
            {
                var usuario = new Usuario
                {
                    Nome = "Admin",
                    Email = "admin@domain.com",
                    UserName = "admin@domain.com",
                    PasswordHash= "123123",
                    SecurityStamp = Guid.NewGuid().ToString(),
                };

                var passwordHash = new PasswordHasher<Usuario>();
                var password = passwordHash.HashPassword(usuario, usuario.PasswordHash);
                

                context.Roles.Add(new IdentityRole { Name = "Admin" });
                context.Users.Add(usuario);
                context.SaveChanges();
                var admin = context.Users.FirstOrDefault(u => u.UserName == "admin@domain.com");
                var role = context.Roles.FirstOrDefault(u => u.Name == "Admin");
 
                context.UserRoles.Add(new IdentityUserRole<string> { UserId = admin.Id, RoleId = role.Id });
                context.SaveChanges();
            }

        
              
            


          



            if (context.Cliente.Any())
            {
                return;
            }

            var clientes = new Cliente[] { 
                new Cliente { Nome = "Mauricio jose de souza", Cpf = "1111111111" },
                new Cliente { Nome = "Claudio Junior", Cpf = "1111111111" },

            };

            var contatos = new Contato[] {
                new Contato { Nome = "Contato 1", Email = "teste1@gmail.com",Cliente=clientes[0] },
                new Contato { Nome = "Contato2 ", Email = "teste2@gmail.com",Cliente=clientes[1] },

            };

            context.AddRange(clientes);
            context.AddRange(contatos);
            context.SaveChanges();


        }
    }
}
