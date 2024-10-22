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
                name: "Contatos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id);
                });

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
                table: "Contatos",
                columns: new[] { "Id", "Bairro", "Cep", "Cidade", "Email", "Endereco", "Estado", "Name", "Telefone" },
                values: new object[,]
                {
                    { new Guid("2c746303-acff-4815-988e-df1e167a462a"), "atestado bairro", 98765789, "atestado cidade", "atestado@teste.com", "Teste 2 numero 2", "ML", "Teste 2", 0 },
                    { new Guid("a5dd3e54-c21e-4aa2-81b6-a18854983ecf"), "teste bairro", 12345213, "teste cidade", "teste@teste.com", "Teste 1 numero 1", "RL", "Teste 1", 0 }
                });

            migrationBuilder.InsertData(
                table: "Tarefas",
                columns: new[] { "Id", "Criacao", "Descricao", "Observacoes", "Prioridade", "Responsavel", "Status", "Tarefa", "Vencimento" },
                values: new object[,]
                {
                    { new Guid("b66910d4-f789-473d-b997-16efabdcb5d3"), new DateTime(2024, 10, 21, 21, 53, 25, 927, DateTimeKind.Local).AddTicks(6478), "Teste 2", "Teste observação 2", 1, "Thunders", 2, "Teste 2", new DateTime(2024, 11, 5, 21, 53, 25, 927, DateTimeKind.Local).AddTicks(6479) },
                    { new Guid("c2a3bf8d-4340-4adc-85a3-a0be30d572f2"), new DateTime(2024, 10, 21, 21, 53, 25, 927, DateTimeKind.Local).AddTicks(6459), "Teste 1", "Teste observação 1", 0, "Queres", 0, "Teste 1", new DateTime(2024, 11, 20, 21, 53, 25, 927, DateTimeKind.Local).AddTicks(6461) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Tarefas");
        }
    }
}
