using System;
using System.IO;
using HomeTasks.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HomeTasks.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "HomeTasks.API",
                        Version = "v1",
                        Description = "Api to provide resources for the HomeTasks project",
                        Contact = new OpenApiContact()
                        {
                            Name = "Everton Brzozowy Alves",
                            Url = new Uri("https://github.com/EvertonBrzozowyAlves/")
                        }
                    });

                var filePath = Path.Combine(System.AppContext.BaseDirectory, "HomeTasks.API.xml");
                c.IncludeXmlComments(filePath);
                c.IgnoreObsoleteActions();
                c.IgnoreObsoleteProperties();
                services.RegisterDependencies();
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HomeTasks.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}