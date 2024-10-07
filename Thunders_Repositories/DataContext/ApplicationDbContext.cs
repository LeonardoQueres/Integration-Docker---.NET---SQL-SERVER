using Microsoft.EntityFrameworkCore;
using Thunders_Borders.Entities;

namespace Thunders_Repositories.DataContext
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<ToDoList> Tarefas { get; set; }
    }
}
