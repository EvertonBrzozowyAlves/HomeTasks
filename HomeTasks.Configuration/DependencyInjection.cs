using HomeTasks.Business.Family;
using HomeTasks.Data.Family;
using HomeTasks.Data.Family.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace HomeTasks.Configuration
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Register a concrete class for each interface in the system
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IFamilyBusiness, FamilyBusiness>();
            services.AddSingleton<IFamilyData, FamilyData>();
        }
    }
}