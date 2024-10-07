using FluentValidation;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Shared;
using Thunders_Borders.Shared.Extensions;

namespace Thunders_Borders.Validators
{
    public class CreateToDoListValidator : AbstractValidator<ToDoListRequest>
    {
        public CreateToDoListValidator()
        {
            RuleFor(x => x.Tarefa)
                .NotEmpty().WithErrorMessage(ErrorMessages.GenericRequired.Build("{PropertyName}"))
                .WithName("Tarefa");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithErrorMessage(ErrorMessages.GenericRequired.Build("{PropertyName}"))
                .WithName("Descrição");

            RuleFor(x => x.Vencimento)
                .NotEmpty().WithErrorMessage(ErrorMessages.GenericRequired.Build("{PropertyName}"))
                .Must(VencimentoMaiorQueDataAtual).WithErrorMessage(ErrorMessages.ErroDataIgualDataAtual.Build("{PropertyName}"))
                .WithName("Vencimento");

            RuleFor(x => x.Prioridade)
                .IsInEnum().WithErrorMessage(ErrorMessages.GenericRequired.Build("{PropertyName}"))
                .WithName("Prioridade");

            RuleFor(x => x.Status)
                .IsInEnum().WithErrorMessage(ErrorMessages.GenericRequired.Build("{PropertyName}"))
                .WithName("Status");

            RuleFor(x => x.Responsavel)
                .NotEmpty().WithErrorMessage(ErrorMessages.GenericRequired.Build("{PropertyName}"))
                .WithName("Responsável");

            RuleFor(x => x.Observacoes)
                .NotEmpty().WithErrorMessage(ErrorMessages.GenericRequired.Build("{PropertyName}"))
                .WithName("Observações");
        }

        private static bool VencimentoMaiorQueDataAtual(DateTime dataNascimento)
        {
            return dataNascimento >= DateTime.Now.ToLocalTime();
        }
    }
}
