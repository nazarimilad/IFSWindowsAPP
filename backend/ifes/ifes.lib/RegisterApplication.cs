using AutoMapper;
using ifes.lib.Mappers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ifes.lib {
   public static class RegisterApplication {
        public static void RegisterApp(this IServiceCollection services) {
             services.AddAutoMapper(Assembly.GetAssembly(typeof(RegisterApplication)));

            services.AddScoped<FoodMapper>();
            services.AddScoped<BeverageMapper>();
            services.AddScoped<VideoMapper>();
            services.AddScoped<AudioMapper>();
            services.AddScoped<OrderMapper>();



        }
    }
}
