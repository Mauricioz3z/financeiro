using financeiro.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace financeiro.ApplicationCore.Interfaces.Repository
{
   public interface  IClienteRepository:IRepository<Cliente>
    {
         Cliente ObterClientePorContato(int contatoId);
    }
}
