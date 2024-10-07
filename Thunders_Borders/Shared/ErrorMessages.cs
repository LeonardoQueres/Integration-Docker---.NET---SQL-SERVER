using Thunders_Borders.Shared.Builder;

namespace Thunders_Borders.Shared
{
    public static class ErrorMessages
    {
        public static readonly ErrorMessageBuilder GenericRequired = new("02.01", "O campo {0} é obrigatório.");
        public static readonly ErrorMessage ErroCommunicacaoComServico = new("03.01", "Erro na comunicação com o serviço.");
        public static readonly ErrorMessageBuilder ErroDataIgualDataAtual = new("03.02", "O campo {0} deve ser maior que a data atual.");
        public static readonly ErrorMessageBuilder ToDoListNaoEncontrado = new("03.03", "Tarefa não encontrada.");
    }
}
