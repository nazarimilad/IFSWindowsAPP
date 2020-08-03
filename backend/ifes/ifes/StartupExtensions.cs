using ifes.lib.domain.Catalogs;
using ifes.lib.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using ifes.lib.domain.Users;
using ifes.lib.domain.Planes;

namespace ifes {
    public static class StartupExtensions {
        public static void AddRepositories(this IServiceCollection services) {

            //catalog
            services.AddScoped(typeof(IRepository<Catalog>), typeof(Repository<Catalog>));
            services.AddScoped(typeof(IRepository<CatalogItem>), typeof(Repository<CatalogItem>));
            services.AddScoped(typeof(IRepository<Food>), typeof(Repository<Food>));
            services.AddScoped(typeof(IRepository<Beverage>), typeof(Repository<Beverage>));
            services.AddScoped(typeof(IRepository<Audio>), typeof(Repository<Audio>));
            services.AddScoped(typeof(IRepository<Video>), typeof(Repository<Video>));
            services.AddScoped(typeof(IRepository<Order>), typeof(Repository<Order>));

            //plane
            services.AddScoped(typeof(IRepository<Plane>), typeof(Repository<Plane>));
            services.AddScoped(typeof(IRepository<CabinCrew>), typeof(Repository<CabinCrew>));
            services.AddScoped(typeof(IRepository<Passenger>), typeof(Repository<Passenger>));





        }
        public static void AddSwaggerDocumentation(this IServiceCollection services) {
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Ifes Api", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
                    Description = @"JWT Authorization header using the Bearer scheme.  <BR/> 
                      Enter 'Bearer' [space] and then your token in the text input below.
                       <BR/> Example: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                 {
                         {
                            new OpenApiSecurityScheme
                                {
                                     Reference = new OpenApiReference
                                      {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "Bearer"
                                      },
                                      Scheme = "oauth2",
                                      Name = "Bearer",
                                      In = ParameterLocation.Header,

                                },
                        new List<string>()
                        }
                         });

            });

        }

        public static void UseSwaggerDocumentation(this IApplicationBuilder app) {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Versioned API v1");
                c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
            });
        }

        }
    }





