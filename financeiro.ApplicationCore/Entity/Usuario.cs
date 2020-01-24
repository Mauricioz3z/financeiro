
using Microsoft.AspNetCore.Identity;

namespace financeiro.ApplicationCore.Entity
{
    public class Usuario:IdentityUser
    {
        public int Nome { get; set; }
        public int Sobrenome { get; set; }

    }
}
