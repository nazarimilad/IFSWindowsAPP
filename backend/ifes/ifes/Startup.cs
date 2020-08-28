using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ifes.Hubs;
using ifes.lib;
using ifes.lib.data;
using ifes.lib.domain.Users;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ifes {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddDbContext<ApplicationDbContext>(options =>
           options.UseMySQL(Configuration.GetConnectionString("IfesConnectionLocalMysql")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddCors(options => options.AddPolicy("AllowAllOrigins", builder => builder.AllowAnyOrigin()));


            services.AddControllers().AddNewtonsoftJson(options =>
                 options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.RegisterApp();
            services.AddRepositories();
            services.AddSwaggerDocumentation();
            services.AddSignalR();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ApplicationDbContext context, UserManager<ApplicationUser> manager) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

          //  new Init(context, manager).Run();

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseCors("AllowAllOrigins");

            app.UseAuthorization();
            app.UseSwaggerDocumentation();

            app.UseEndpoints(endpoints => { 
                endpoints.MapControllers();
                endpoints.MapHub<MessageHub>("messages");
            });
            app.UseSwaggerDocumentation();


        }
    }
}