using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders_Borders.DTO.Internal;
using Thunders_Borders.Shared;

namespace Thunders_Borders.UseCases
{
    public interface ICreateToDoListUseCase : IUseCase<ToDoListRequest, IEnumerable<ToDoListResponse>>
    {
    }
}
