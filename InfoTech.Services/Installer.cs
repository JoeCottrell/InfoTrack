using InfoTrack.Services.Config;
using InfoTrack.Services.Factory;
using Microsoft.Extensions.DependencyInjection;

namespace InfoTrack.Services
{
    public static class Installer
    {
        public static void Install(this IServiceCollection services)
        {
            services.AddSingleton<ISearchFactory, SearchFactory>();
            services.AddSingleton<IGoogleConfig, GoogleConfig>();
            services.AddSingleton<IBingConfig, BingConfig>();
        }
    }
}
