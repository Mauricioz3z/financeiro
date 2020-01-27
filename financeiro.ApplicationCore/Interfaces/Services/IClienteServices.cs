using financeiro.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace financeiro.ApplicationCore.Interfaces.Services
{
  public  interface IClienteServices : IServiceBase<Cliente>    {
        //da pra melhorar essa classe trabalhando com  dados gernericos
        Cliente ObterClientePorContato(int contatoId);


    }
}
