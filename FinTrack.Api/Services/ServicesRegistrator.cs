using FinTrack.Api.Services.Implementations;
using FinTrack.Api.Services.Interfaces;

namespace FinTrack.Api.Services
{
    public static  class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IBudgetService, BudgetService>()
            ;
    }
}
