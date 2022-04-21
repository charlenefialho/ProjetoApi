using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoApi_MontagemMoveis.Models.Enuns;

namespace ProjetoApi_MontagemMoveis.Models
{
    public class Orcamento
    {
        public int Id { get; set; }
        public string NomeCliente { get; set; } 
        //public Cliente IdCliente { get; set; }    //relacionar com classe cliente
        public DateTime Data { get; set; }
        public TipoServicoEnum TipoServico { get; set; }
        public string TipoMovel { get; set; }
        public string DescricaoMovel { get; set; }
        public EstadoMovel_Enum EstadoMovel { get; set; }
        public decimal ValorOrcamento { get; set; }
        public StatusOrcamentoEnum status { get; set;}
    }
}