using api_calculo.Domain.Interfaces;
using api_calculo.Infra.Services;
using api_calculo.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace api_calculo
{
    public class Startup
    {
        private readonly string systemName = "Softplan";
        private readonly string systemVersion = "v1";


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<ICalculaJurosService, CalculaJurosService>();
            services.AddHttpClient<IJurosClientService, JurosClientHttpService> (client =>
            {
                client.BaseAddress = new Uri(Configuration.GetValue<string>("JurosApiUrl"));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(systemVersion, new OpenApiInfo { Title = systemName, Version = systemVersion });
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", systemName);
            });


            app.UseRouting();
            app.UseAuthorization();
            app.UseHttpsRedirection();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
