using Ahoy.Domain.Interfaces.Hotels;
using Ahoy.Infrastructure.Repository.Hotels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahoy.API.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddDefaultServices(this IServiceCollection services)
        {
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Ahoy Hotel API",
                    Version = "v1"
                });
            });
            services.AddControllers();
        }
    }
}
