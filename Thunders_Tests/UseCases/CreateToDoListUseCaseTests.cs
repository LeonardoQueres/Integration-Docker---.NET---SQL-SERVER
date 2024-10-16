using Moq;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Entities;
using Thunders_Borders.Enums;
using Thunders_Borders.Repositories;
using Thunders_Borders.Shared;
using Thunders_Tests.Builders;
using Thunders_UseCases.UseCases;
using Xunit;

namespace Thunders_Tests.UseCases
{
    public class CreateToDoListUseCaseTests : BaseUseCaseTests<CreateToDoListUseCase, ToDoListRequest, ToDoListResponse>
    {
        [Fact]
        public async Task Execute_WhenEverythingIsOk_ReturnsCreated()
        {
            var request = new CreateToDoListRequestBuilder().Build();
            var responseBuild = new ToDoListBuilder().Build();

            AutoMocker.GetMock<IToDoListRepository>().Setup(x => x.Create(It.IsAny<ToDoList>())).ReturnsAsync(responseBuild);

            var response = await GetSut().Execute(request);

            AssertSuccess(response, UseCaseResponseKind.DataPersisted, new ToDoListResponse(responseBuild));
        }

        [Fact]
        public async Task Execute_WhenToDoListWasNotFound_ReturnsBadRequest()
        {
            var request = new CreateToDoListRequestBuilder().Build();
            AutoMocker.GetMock<IToDoListRepository>().Setup(x => x.Create(It.IsAny<ToDoList>()));

            var response = await GetSut().Execute(request);

            await ActAndAssertFail(request, UseCaseResponseKind.InternalServerError, ErrorMessages.InternalServerError);
        }

    }
}
