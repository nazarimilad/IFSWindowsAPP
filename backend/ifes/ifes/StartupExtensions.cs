using ifes.lib.domain.Catalogs;
using ifes.lib.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ifes {
    public static class StartupExtensions {
        public static void AddRepositories(this IServiceCollection services) {

            //catalog
            services.AddScoped(typeof(IRepository<Catalog>), typeof(Repository<Catalog>));
            services.AddScoped(typeof(IRepository<Food>), typeof(Repository<Food>));
            services.AddScoped(typeof(IRepository<Beverage>), typeof(Repository<Beverage>));
            services.AddScoped(typeof(IRepository<Audio>), typeof(Repository<Audio>));
            services.AddScoped(typeof(IRepository<Video>), typeof(Repository<Video>));
            services.AddScoped(typeof(IRepository<Order>), typeof(Repository<Order>));




        }
    }
}
