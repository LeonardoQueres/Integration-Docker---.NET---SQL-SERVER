using Thunders_Borders.Entities;

namespace Thunders_Borders.Repositories
{
    public interface IToDoListRepository
    {
        Task<IEnumerable<ToDoList>> Get();
        Task<ToDoList> Create(ToDoList toDoList);
    }
}
