using financeiro.ApplicationCore.Entity;
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
