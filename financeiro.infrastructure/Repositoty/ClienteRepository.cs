using financeiro.ApplicationCore.Entity;
using financeiro.ApplicationCore.Interfaces.Repository;
using financeiro.infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace financeiro.infrastructure.Repositoty
{
    public class ClienteRepository : Repository<Cliente>,IClienteRepository
    {
        public ClienteRepository(BackendContext dbContext) : base(dbContext)
        {

        }

        public Cliente ObterClientePorContato(int contatoId)
        {
            return Buscar(x => x.Contatos.Any(p => p.Id==contatoId)).FirstOrDefault();
        }
    }
}
