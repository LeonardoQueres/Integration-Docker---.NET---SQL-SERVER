using Thunders_Borders.Shared;

namespace Thunders_Api.Extensions
{
    public static class ConfigurationExtensions
    {
        public static ApplicationConfig LoadConfiguration(this IConfiguration source) => source.Get<ApplicationConfig>()!;
    }
}
