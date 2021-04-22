using Data;
using Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services;

namespace Extensions
{
    public static class ApplicationServiceExtensions  
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config) {
            //AddScoped dies after the http request lifecycle
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            
            return services;
        }
    }
}