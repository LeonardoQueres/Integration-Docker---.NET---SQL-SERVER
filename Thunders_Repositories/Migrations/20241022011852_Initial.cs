using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Thunders_Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tarefas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tarefa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vencimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prioridade = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Responsavel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Criacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarefas", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "Id", "Criacao", "Descricao", "Observacoes", "Prioridade", "Responsavel", "Status", "Tarefa", "Vencimento" },
                values: new object[,]
                {
                    { new Guid("b66910d4-f789-473d-b997-16efabdcb5d3"), new DateTime(2024, 10, 21, 22, 18, 51, 585, DateTimeKind.Local).AddTicks(8734), "Teste 2", "Teste observação 2", 1, "Thunders", 2, "Teste 2", new DateTime(2024, 11, 5, 22, 18, 51, 585, DateTimeKind.Local).AddTicks(8735) },
                    { new Guid("c2a3bf8d-4340-4adc-85a3-a0be30d572f2"), new DateTime(2024, 10, 21, 22, 18, 51, 585, DateTimeKind.Local).AddTicks(8726), "Teste 1", "Teste observação 1", 0, "Queres", 0, "Teste 1", new DateTime(2024, 11, 20, 22, 18, 51, 585, DateTimeKind.Local).AddTicks(8728) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
