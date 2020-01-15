using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace financeiro.ApplicationCore.Entity
{
    public class Contato
    {

        public Contato()
        {

        }
        public int Id { get; set; }
        [MaxLength(100)]
        public string Nome { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }


    }
}
