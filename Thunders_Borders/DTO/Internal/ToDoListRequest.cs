#nullable disable warnings
using Thunders_Borders.Enums;

namespace Thunders_Borders.DTO.Internal
{
    public record ToDoListRequest
    {        
        public string Tarefa { get; init; }
        public DateTime Vencimento { get; init; }
        public PriorityType Prioridade { get; init; }
        public StatusType Status { get; init; }
        public string Descricao { get; init; }
        public string Responsavel { get; init; }
        public string Observacoes { get; init; }
    }
}
