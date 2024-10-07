using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Repositories;
using Thunders_Borders.Shared;
using Thunders_Borders.UseCases;

namespace Thunders_UseCases.UseCases
{
    public class ToDoListUseCase(IToDoListRepository repository) : IToDoListUseCase
    {
        public async Task<UseCaseResponse<IEnumerable<ToDoListResponse>>> Execute()
        {
            var result = await repository.Get();

            return UseCaseResponse<IEnumerable<ToDoListResponse>>.Success(result.Select(x => new ToDoListResponse(x)));
        }
    }
}
