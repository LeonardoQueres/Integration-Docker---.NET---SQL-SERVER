
#nullable disable warnings
using Thunders_Borders.Entities;
using Thunders_Borders.Enums;

namespace Thunders_Borders.DTO.Internal
{
    public record ToDoListResponse
    {
        public ToDoListResponse(ToDoList toDoList)
        {
            Id = toDoList.Id;
            Tarefa = toDoList.Tarefa;
            Vencimento = toDoList.Vencimento;
            Prioridade = toDoList.Prioridade;
            Status = toDoList.Status;
            Descricao = toDoList.Descricao;
            Responsavel = toDoList.Responsavel;
            Observacoes = toDoList.Observacoes;
        }

        public Guid Id { get; init; }
        public string Tarefa { get; init; }
        public DateTime Vencimento { get; init; }
        public PriorityType Prioridade { get; init; }
        public StatusType Status { get; init; }
        public string Descricao { get; init; }
        public string Responsavel { get; init; }
        public string Observacoes { get; init; }
    }
}
