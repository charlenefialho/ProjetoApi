using Microsoft.EntityFrameworkCore;
using  ProjetoApi_MontagemMoveis.Models;
using ProjetoApi_MontagemMoveis.Models.Enuns;
using System;
namespace ProjetoApi_MontagemMoveis.Data
{
    public class DataContext : DbContext
    {
       
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
         public DbSet<Orcamento> Orcamentos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orcamento>().HasData
            (
                new Orcamento() {Id = 1, NomeCliente = "Barbara" , Data = DateTime.Parse("01/01/2022"), TipoServico = TipoServicoEnum.Montagem , TipoMovel = "Guarda-Roupa", DescricaoMovel ="Guarda-roupa com 3 portas de espelho",   EstadoMovel = EstadoMovel_Enum.Novo , ValorOrcamento = 200, status = StatusOrcamentoEnum.concluido },
                new Orcamento() {Id = 2, NomeCliente = "Sonia " , Data = DateTime.Parse("01/01/2020"), TipoServico = TipoServicoEnum.Desmontagem , TipoMovel = "Cômoda", DescricaoMovel ="Cômoda de tres gavetas",                     EstadoMovel = EstadoMovel_Enum.Usado , ValorOrcamento = 150.50M, status = StatusOrcamentoEnum.concluido },
                new Orcamento() {Id = 3, NomeCliente = "Gabriel " , Data = DateTime.Parse("01/01/2021"), TipoServico = TipoServicoEnum.Montagem , TipoMovel = "Mesa ", DescricaoMovel ="Mesa gamer 60cm - 136cm ",                     EstadoMovel = EstadoMovel_Enum.Novo , ValorOrcamento = 300, status = StatusOrcamentoEnum.concluido },
                new Orcamento() {Id = 4, NomeCliente = "Anahi " , Data = DateTime.Parse("01/01/2022"), TipoServico = TipoServicoEnum.Desmontagem , TipoMovel = "Mesa", DescricaoMovel ="Mesa de 4 cadeiras",                           EstadoMovel = EstadoMovel_Enum.Usado , ValorOrcamento = 200, status = StatusOrcamentoEnum.concluido }

            );
           
        }


    }
}