using Thunders_Borders.UseCases;
using Thunders_UseCases.UseCases;

namespace Thunders_Api.Configurations
{
    public static class UseCasesConfig
    {
        public static IServiceCollection AddUseCases(this IServiceCollection services)
        {
            return services
                .AddScoped<IToDoListUseCase, ToDoListUseCase>()
                .AddScoped<ICreateToDoListUseCase, CreateToDoListUseCase>();
        }
    }
}
