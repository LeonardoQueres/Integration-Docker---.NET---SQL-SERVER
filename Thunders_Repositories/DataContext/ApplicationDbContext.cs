using Microsoft.EntityFrameworkCore;
using Thunders_Borders.Entities;

namespace Thunders_Repositories.DataContext
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ToDoList> Tarefas { get; set; }
    }
}
