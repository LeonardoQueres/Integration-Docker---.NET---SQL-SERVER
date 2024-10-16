using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Enums;
using Thunders_Borders.Shared;
using Thunders_Borders.Validators;
using Thunders_Tests.Builders;
using Xunit;

namespace Thunders_Tests.Validators
{
    public class CreateToDoListValidatorTests : BaseValidatorTests<CreateToDoListValidator, ToDoListRequest>
    {
        [Fact]
        public void Validate_WhenValidRequest_IsValid()
        {
            var request = new CreateToDoListRequestBuilder().Build();
            ActAndAssertSuccess(request);
        }

        [Fact]
        public void Validate_WhenHasEmptyTarefa_IsInvalid()
        {
            var request = new CreateToDoListRequestBuilder().WithTarefa("").Build();
            ActAndAssertFail(request, ErrorMessages.GenericRequired.Build("Tarefa"));
        }

        [Fact]
        public void Validate_WhenHasEmptyDescricao_IsInvalid()
        {
            var request = new CreateToDoListRequestBuilder().WithDescricao("").Build();
            ActAndAssertFail(request, ErrorMessages.GenericRequired.Build("Descrição"));
        }

        [Fact]
        public void Validate_WhenHasEmptyResponsavel_IsInvalid()
        {
            var request = new CreateToDoListRequestBuilder().WithResponsavel("").Build();
            ActAndAssertFail(request, ErrorMessages.GenericRequired.Build("Responsável"));
        }

        [Fact]
        public void Validate_WhenHasEmptyObservacao_IsInvalid()
        {
            var request = new CreateToDoListRequestBuilder().WithObservacao("").Build();
            ActAndAssertFail(request, ErrorMessages.GenericRequired.Build("Observações"));
        }

        [Fact]
        public void Validate_WhenHasEmptyVencimento_IsInvalid()
        {
            var request = new CreateToDoListRequestBuilder().WithVencimento(DateTime.Now).Build();
            ActAndAssertFail(request, ErrorMessages.ErroDataIgualDataAtual.Build("Vencimento"));
        }

        [Fact]
        public void Validate_WhenHasEmptyPrioridade_IsInvalid()
        {
            var request = new CreateToDoListRequestBuilder().WithPriorityType((PriorityType)99).Build();
            ActAndAssertFail(request, ErrorMessages.GenericRequired.Build("Prioridade"));
        }

        [Fact]
        public void Validate_WhenHasEmptyStatus_IsInvalid()
        {
            var request = new CreateToDoListRequestBuilder().WithStatusType((StatusType)99).Build();
            ActAndAssertFail(request, ErrorMessages.GenericRequired.Build("Status"));
        }
    }
}
