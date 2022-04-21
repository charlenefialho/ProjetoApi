using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoApi_MontagemMoveis.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orcamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TipoServico = table.Column<int>(type: "int", nullable: false),
                    TipoMovel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescricaoMovel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoMovel = table.Column<int>(type: "int", nullable: false),
                    ValorOrcamento = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamentos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Orcamentos",
                columns: new[] { "Id", "Data", "DescricaoMovel", "EstadoMovel", "NomeCliente", "TipoMovel", "TipoServico", "ValorOrcamento", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guarda-roupa com 3 portas de espelho", 1, "Barbara", "Guarda-Roupa", 1, 200m, 1 },
                    { 2, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cômoda de tres gavetas", 2, "Sonia ", "Cômoda", 2, 150.50m, 1 },
                    { 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mesa gamer 60cm - 136cm ", 1, "Gabriel ", "Mesa ", 1, 300m, 1 },
                    { 4, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mesa de 4 cadeiras", 2, "Anahi ", "Mesa", 2, 200m, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orcamentos");
        }
    }
}
