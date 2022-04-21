using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoApi_MontagemMoveis.Data;
using ProjetoApi_MontagemMoveis.Models;
using Microsoft.EntityFrameworkCore;
using ProjetoApi_MontagemMoveis.Models.Enuns;


namespace ProjetoApi_MontagemMoveis.Controllers
{
    
    [ApiController]
    [Route("[Controller]")]
    public class OrcamentosController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public OrcamentosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    


        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingle(int id)
        {
            try
            {
                Orcamento o = await _dataContext.Orcamentos.FirstOrDefaultAsync(oBusca => oBusca.Id == id);
                return Ok(o);

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /*[HttpGet("tipoServico/{ServicoEnum}")]
        public async Task<IActionResult> GetTipoServico(TipoServicoEnum ServicoEnum)
        {
            try
            {
                List<Orcamento> o = await _dataContext.Orcamentos.ToListAsync();
                return Ok(o);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }*/

        [HttpGet("GetAll")]

        public async Task<IActionResult> Get()
        {
            try
            {
                List<Orcamento> lista = await _dataContext.Orcamentos.ToListAsync();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("NovoOrcamento")]
        public async Task<IActionResult> Add(Orcamento NovoOrcamento)
        {
            try
            {
                await _dataContext.Orcamentos.AddAsync(NovoOrcamento);
                await _dataContext.SaveChangesAsync();

                return Ok(NovoOrcamento.Id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("UpdateOrcamento")]
        public async Task<IActionResult> Update(Orcamento NovoOrcamento)
        {
            try
            {
                _dataContext.Orcamentos.Update(NovoOrcamento);
                int linhasAfetadas = await _dataContext.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteOrcamento/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Orcamento oRemover = await _dataContext.Orcamentos.FirstOrDefaultAsync(o => o.Id == id);
                _dataContext.Orcamentos.Remove(oRemover);
                int linhasAfetadas = await _dataContext.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }









    }
}