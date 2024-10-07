using Microsoft.EntityFrameworkCore;
using Thunders_Borders.Entities;
using Thunders_Borders.Repositories;
using Thunders_Repositories.DataContext;

namespace Thunders_Repositories.Repositories
{
    public class ToDoListRepository(ApplicationDbContext context) : IToDoListRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<IEnumerable<ToDoList>> Create(ToDoList toDoList)
        {
            _context.Add(toDoList);
            await _context.SaveChangesAsync();

            var result = await _context.Tarefas.ToListAsync();
            return result;
        }

        public async Task<IEnumerable<ToDoList>> Get()
        {
            var result = await _context.Tarefas.ToListAsync();
            return result;
        }
    }
}
