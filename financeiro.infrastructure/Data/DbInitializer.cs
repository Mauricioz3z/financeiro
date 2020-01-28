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


            if (!context.Usuario.Any())//e=>e.UserName== "admin@domain.com"
            {
              
                Usuario applicationUser = new Usuario();
                applicationUser.UserName = "admin@domain.com";
                applicationUser.Email = "admin@domain.com";
                applicationUser.NormalizedUserName = "admin@domain.com";
                context.Users.Add(applicationUser);

                var _passwordHasher = new PasswordHasher<Usuario>();
                var hasedPassword = _passwordHasher.HashPassword(applicationUser, "123123");
                applicationUser.SecurityStamp = Guid.NewGuid().ToString();
                applicationUser.PasswordHash = hasedPassword;
                context.SaveChanges();


                Usuario UserGerente = new Usuario();
                UserGerente.UserName = "gerente@domain.com";
                UserGerente.Email = "gerente@domain.com";
                UserGerente.NormalizedUserName = "gerente@domain.com";
                context.Users.Add(UserGerente);

                var _gerentepasswordHasher = new PasswordHasher<Usuario>();
                var gerentehasedPassword = _gerentepasswordHasher.HashPassword(applicationUser, "123123");
                UserGerente.SecurityStamp = Guid.NewGuid().ToString();
                UserGerente.PasswordHash = gerentehasedPassword;
                context.SaveChanges();


                Usuario UserCoordenador = new Usuario();
                UserCoordenador.UserName = "coordenador@domain.com";
                UserCoordenador.Email = "coordenador@domain.com";
                UserCoordenador.NormalizedUserName = "coordenador@domain.com";
                context.Users.Add(UserCoordenador);

                var _coordenadorpasswordHasher = new PasswordHasher<Usuario>();
                var corndenadorhasedPassword = _coordenadorpasswordHasher.HashPassword(UserCoordenador, "123123");
                UserCoordenador.SecurityStamp = Guid.NewGuid().ToString();
                UserCoordenador.PasswordHash = corndenadorhasedPassword;
                context.SaveChanges();





                context.Roles.Add(new IdentityRole { Name = "Admin" });
                context.Roles.Add(new IdentityRole { Name = "Gerente" });
                context.Roles.Add(new IdentityRole { Name = "Coordenador" });
                context.SaveChanges();


                var admin = context.Users.FirstOrDefault(u => u.UserName == "admin@domain.com");
                var adminRole = context.Roles.FirstOrDefault(u => u.Name == "Admin");
                context.UserRoles.Add(new IdentityUserRole<string> { UserId = admin.Id, RoleId = adminRole.Id });

                var gerente = context.Users.FirstOrDefault(u => u.UserName == "gerente@domain.com");
                var gerenteRole = context.Roles.FirstOrDefault(u => u.Name == "Gerente");
                context.UserRoles.Add(new IdentityUserRole<string> { UserId = gerente.Id, RoleId = gerenteRole.Id });

                var coordenador = context.Users.FirstOrDefault(u => u.UserName == "coordenador@domain.com");
                var coordenadorRole = context.Roles.FirstOrDefault(u => u.Name == "Coordenador");
                context.UserRoles.Add(new IdentityUserRole<string> { UserId = coordenador.Id, RoleId = coordenadorRole.Id });

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
