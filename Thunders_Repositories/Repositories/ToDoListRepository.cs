#nullable disable warnings
using Microsoft.EntityFrameworkCore;
using Thunders_Borders.Entities;
using Thunders_Borders.Repositories;
using Thunders_Repositories.DataContext;

namespace Thunders_Repositories.Repositories
{
    public class ToDoListRepository(ApplicationDbContext context) : IToDoListRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<ToDoList> Create(ToDoList toDoList)
        {
            _context.Add(toDoList);
            await _context.SaveChangesAsync();

            return await _context.Tarefas.FirstOrDefaultAsync(x => x.Id == toDoList.Id);           
        }

        public async Task<IEnumerable<ToDoList>> Get()
        {
            var result = await _context.Tarefas.ToListAsync();
            return result;
        }
    }
}
