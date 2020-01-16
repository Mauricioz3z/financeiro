using financeiro.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace financeiro.ApplicationCore.Interfaces.Services
{
  public  interface IClienteServices
    {
        //da pra melhorar essa classe trabalhando com  dados gernericos

        Cliente Adicionar(Cliente entity);
        void Atualizar(Cliente entity);
        IEnumerable<Cliente> ObterTodos();
        Cliente ObterPorId(int Id);
        IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado);
        void Remover(Cliente entity);

    }
}
