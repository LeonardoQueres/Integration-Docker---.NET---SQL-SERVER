using Microsoft.AspNetCore.Mvc;
using Thunders_Api.Extensions;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Shared;
using Thunders_Borders.UseCases;

namespace Thunders_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController(IActionResultConverter actionResultConverter,
                                   IToDoListUseCase toDoListUseCase,
                                   ICreateToDoListUseCase createToDoListUseCase) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await toDoListUseCase.Execute();

            return actionResultConverter.Convert(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ToDoListResponse[]))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ErrorMessage[]))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ErrorMessage[]))]
        public async Task<IActionResult> Post([FromBody] ToDoListRequest request)
        {
            var response = await createToDoListUseCase.Execute(request);
            return actionResultConverter.Convert(response);
        }
    }
}
