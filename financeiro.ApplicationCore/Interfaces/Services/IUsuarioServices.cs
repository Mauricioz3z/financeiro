using financeiro.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace financeiro.ApplicationCore.Interfaces.Services
{
   public interface IUsuarioServices :IServiceBase<Usuario>
    {


        public void addRole(Usuario u,string role);

    }
}
