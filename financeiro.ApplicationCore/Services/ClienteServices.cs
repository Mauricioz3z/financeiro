using financeiro.ApplicationCore.Entity;
using financeiro.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace financeiro.ApplicationCore.Services
{
    public class ClienteServices : IClienteServices
    {
        //Regra de negocio aqui

        protected readonly IClienteServices _clienteRepository;
        public ClienteServices(IClienteServices clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public Cliente Adicionar(Cliente entity)
        {
            return _clienteRepository.Adicionar(entity);
        }

        public void Atualizar(Cliente entity)
        {
             _clienteRepository.Atualizar(entity);
        }

        public IEnumerable<Cliente> Buscar(Expression<Func<Cliente, bool>> predicado)
        {
           return _clienteRepository.Buscar(predicado);
        }

        public Cliente ObterPorId(int Id)
        {
            return _clienteRepository.ObterPorId(Id);
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            return _clienteRepository.ObterTodos();
        }

        public void Remover(Cliente entity)
        {
            _clienteRepository.Remover(entity);
        }
    }
}
