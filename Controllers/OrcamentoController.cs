using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ProjetoApi_MontagemMoveis.Models;
using ProjetoApi_MontagemMoveis.Models.Enuns;

namespace ProjetoApi_MontagemMoveis.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class OrcamentoController : ControllerBase
    {
        private static List<Orcamento> orcamentos  = new List<Orcamento>()
        {
            new Orcamento() {Id = 1, NomeCliente = "Barbara" , Data = DateTime.Parse("03/03/2022"), TipoServico = TipoServicoEnum.Montagem , TipoMovel = "Guarda-Roupa", DescricaoMovel ="Guarda-roupa com 3 portas de espelho",   EstadoMovel = EstadoMovel_Enum.Novo , ValorOrcamento = 200.00M, status = StatusOrcamentoEnum.concluido },
            new Orcamento() {Id = 2, NomeCliente = "Sonia " , Data = DateTime.Parse("10/03/2022"), TipoServico = TipoServicoEnum.Desmontagem , TipoMovel = "Cômoda", DescricaoMovel ="Cômoda de tres gavetas",                     EstadoMovel = EstadoMovel_Enum.Usado , ValorOrcamento = 150.50M, status = StatusOrcamentoEnum.concluido },
            new Orcamento() {Id = 3, NomeCliente = "Gabriel " , Data = DateTime.Parse("10/03/2022"), TipoServico = TipoServicoEnum.Montagem , TipoMovel = "Mesa ", DescricaoMovel ="Mesa gamer 60cm - 136cm ",                     EstadoMovel = EstadoMovel_Enum.Novo , ValorOrcamento = 300.00M, status = StatusOrcamentoEnum.concluido},
            new Orcamento() {Id = 4, NomeCliente = "Anahi " , Data = DateTime.Parse("20/03/2022"), TipoServico = TipoServicoEnum.Desmontagem , TipoMovel = "Mesa", DescricaoMovel ="Mesa de 4 cadeiras",                           EstadoMovel = EstadoMovel_Enum.Usado , ValorOrcamento = 200.00M, status = StatusOrcamentoEnum.concluido},

        };

         
        [HttpGet]
        public IActionResult GetFirst() 
        {
            Orcamento o = orcamentos[0];
            return Ok(o);
        }

        [HttpGet("GetAll")]
        
            public IActionResult Get()
            {
                return Ok(orcamentos);
            }
    }
}