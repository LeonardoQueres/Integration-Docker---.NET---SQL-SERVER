using FluentValidation;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Entities;
using Thunders_Borders.Repositories;
using Thunders_Borders.Shared;
using Thunders_Borders.UseCases;
using Thunders_Borders.Validators;

namespace Thunders_UseCases.UseCases
{
    public class CreateToDoListUseCase(IToDoListRepository repository) : ICreateToDoListUseCase
    {
        public async Task<UseCaseResponse<IEnumerable<ToDoListResponse>>> Execute(ToDoListRequest request)
        {
            new CreateToDoListValidator().ValidateAndThrow(request);

            var entity = new ToDoList(request);

            var result = await repository.Create(entity);

            return UseCaseResponse<IEnumerable<ToDoListResponse>>.Success(result.Select(x => new ToDoListResponse(x)));
        }
    }
}
