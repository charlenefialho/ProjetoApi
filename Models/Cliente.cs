using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoApi_MontagemMoveis.Models
{
    public class Cliente
    {
        public int IdCliente {get; set;}
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string telefone { get; set; }
    }
}