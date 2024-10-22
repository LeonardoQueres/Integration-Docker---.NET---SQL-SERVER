using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Thunders_Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AtualizaCampoTelefone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: new Guid("2c746303-acff-4815-988e-df1e167a462a"),
                column: "Telefone",
                value: 90987890);

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: new Guid("a5dd3e54-c21e-4aa2-81b6-a18854983ecf"),
                column: "Telefone",
                value: 12342134);

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: new Guid("b66910d4-f789-473d-b997-16efabdcb5d3"),
                columns: new[] { "Criacao", "Vencimento" },
                values: new object[] { new DateTime(2024, 10, 21, 22, 7, 34, 530, DateTimeKind.Local).AddTicks(439), new DateTime(2024, 11, 5, 22, 7, 34, 530, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: new Guid("c2a3bf8d-4340-4adc-85a3-a0be30d572f2"),
                columns: new[] { "Criacao", "Vencimento" },
                values: new object[] { new DateTime(2024, 10, 21, 22, 7, 34, 530, DateTimeKind.Local).AddTicks(432), new DateTime(2024, 11, 20, 22, 7, 34, 530, DateTimeKind.Local).AddTicks(433) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: new Guid("2c746303-acff-4815-988e-df1e167a462a"),
                column: "Telefone",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Contatos",
                keyColumn: "Id",
                keyValue: new Guid("a5dd3e54-c21e-4aa2-81b6-a18854983ecf"),
                column: "Telefone",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: new Guid("b66910d4-f789-473d-b997-16efabdcb5d3"),
                columns: new[] { "Criacao", "Vencimento" },
                values: new object[] { new DateTime(2024, 10, 21, 21, 53, 25, 927, DateTimeKind.Local).AddTicks(6478), new DateTime(2024, 11, 5, 21, 53, 25, 927, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "Id",
                keyValue: new Guid("c2a3bf8d-4340-4adc-85a3-a0be30d572f2"),
                columns: new[] { "Criacao", "Vencimento" },
                values: new object[] { new DateTime(2024, 10, 21, 21, 53, 25, 927, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 11, 20, 21, 53, 25, 927, DateTimeKind.Local).AddTicks(6461) });
        }
    }
}
