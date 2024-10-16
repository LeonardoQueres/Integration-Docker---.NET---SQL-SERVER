using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thunders_Borders.Entities;
using Thunders_Borders.Enums;

namespace Thunders_Repositories.DataContext.Configurations
{
    public class TarefasConfiguration : IEntityTypeConfiguration<ToDoList>
    {
        public void Configure(EntityTypeBuilder<ToDoList> builder)
        {
            builder.HasData(
                            new ToDoList
                            {
                                Id = Guid.Parse("c2a3bf8d-4340-4adc-85a3-a0be30d572f2"),
                                Criacao = DateTime.Now,
                                Descricao = "Teste 1",
                                Observacoes = "Teste observação 1",
                                Prioridade = PriorityType.Alta,
                                Status = StatusType.Pendente,
                                Responsavel = "Queres",
                                Tarefa = "Teste 1",
                                Vencimento = DateTime.Now.AddDays(30)
                            },
                            new ToDoList
                            {
                                Id = Guid.Parse("b66910d4-f789-473d-b997-16efabdcb5d3"),
                                Criacao = DateTime.Now,
                                Descricao = "Teste 2",
                                Observacoes = "Teste observação 2",
                                Prioridade = PriorityType.Media,
                                Status = StatusType.Concluido,
                                Responsavel = "Thunders",
                                Tarefa = "Teste 2",
                                Vencimento = DateTime.Now.AddDays(15)
                            }
                        );
        }
    }
}
