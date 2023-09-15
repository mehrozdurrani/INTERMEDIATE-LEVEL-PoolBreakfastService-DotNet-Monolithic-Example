using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolBreakfast.Api.Services.Breakfasts
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBreakfastService(this IServiceCollection services)
        {
            services.AddScoped<IBreakfastService, BreakfastService>();
            return services;
        }
    }
}