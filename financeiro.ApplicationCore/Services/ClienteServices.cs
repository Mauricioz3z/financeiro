using financeiro.ApplicationCore.Entity;
using financeiro.ApplicationCore.Interfaces.Repository;
using financeiro.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace financeiro.ApplicationCore.Services
{
    public class ClienteServices : ServiceBase<Cliente>, IClienteServices
    { 
        //Regra de negocio aqui

        protected readonly IClienteRepository _clienteReposotory;

        public ClienteServices(IClienteRepository Repository) : base(Repository)
        {
            _clienteReposotory = Repository;
        }

        public Cliente ObterClientePorContato(int contatoId)
        {
           return _clienteReposotory.ObterClientePorContato(contatoId);
        }





     
    }
}
