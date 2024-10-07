using Thunders_Borders.Repositories;
using Thunders_Repositories.Repositories;

namespace Thunders_Api.Configurations
{
    public static class RepositoriesConfig
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IToDoListRepository, ToDoListRepository>();
        }
    }
}
