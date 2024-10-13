using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Entities;
using Thunders_Borders.Enums;
using Thunders_Borders.Repositories;
using Thunders_Tests.Builders;
using Thunders_UseCases.UseCases;
using Xunit;

namespace Thunders_Tests.UseCases
{
    public class ToDoListUseCaseTests : BaseUseCaseTests<ToDoListUseCase, IEnumerable<ToDoListResponse>>
    {
        [Fact]
        public async Task Execute_WhenEverythingIsOk_ReturnsSuccess()
        {            
            IEnumerable<ToDoList> configurations = [new ToDoListBuilder().Build()];

            AutoMocker.GetMock<IToDoListRepository>().Setup(x => x.Get()).ReturnsAsync(configurations);

            await ActAndAssertSuccess(UseCaseResponseKind.Success, configurations.Select(x => new ToDoListResponse(x)));
        }
    }
}
