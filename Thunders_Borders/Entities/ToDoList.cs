#nullable disable warnings
using System.Text.Json.Serialization;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Enums;

namespace Thunders_Borders.Entities
{
    public record ToDoList
    {
        public ToDoList(ToDoListRequest toDoList) : this()
        {
            Tarefa = toDoList.Tarefa;
            Vencimento = toDoList.Vencimento;
            Prioridade = toDoList.Prioridade;
            Status = toDoList.Status;
            Descricao = toDoList.Descricao;
            Responsavel = toDoList.Responsavel;
            Observacoes = toDoList.Observacoes;
        }

        public ToDoList() => Id = Guid.NewGuid();

        [JsonInclude]
        public Guid Id { get; init; }
        [JsonInclude]
        public string Tarefa { get; init; }
        [JsonInclude]
        public DateTime Vencimento { get; init; }
        [JsonInclude]
        public PriorityType Prioridade { get; init; }
        [JsonInclude]
        public StatusType Status { get; init; }
        [JsonInclude]
        public string Descricao { get; init; }
        [JsonInclude]
        public string Responsavel { get; init; }
        [JsonInclude]
        public string Observacoes { get; init; }
        [JsonInclude]
        public DateTime Criacao { get; init; } = DateTime.Now.ToLocalTime();

    }
}
