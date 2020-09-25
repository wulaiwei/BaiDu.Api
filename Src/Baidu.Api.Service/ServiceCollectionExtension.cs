using BaidDu.Api.Service.Handler;
using Microsoft.Extensions.DependencyInjection;

namespace BaiDu.Api.Service
{
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// AddBaiDuApi
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddBaiDuApi(this IServiceCollection services)
        {
            services.AddTransient<ContentHttpClientHandler>();
            return services;
        }
        
    }
}