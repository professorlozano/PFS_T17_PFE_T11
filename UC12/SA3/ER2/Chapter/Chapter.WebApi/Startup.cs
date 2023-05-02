using Chapter.WebApi.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace Chapter.WebApi
{
    public class Startup
    {
        // Chamado pelo host antes do método Configure para configurar os serviços do aplicativo.
        public void ConfigureServices(IServiceCollection services)
        {
            // adiciona os serviços necessários para 
            services.AddControllers();
            // a cada solicitação, uma nova instância é criada
            services.AddTransient<LivroRepository, LivroRepository>();
            // configura o swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ChapterApi", Version = "v1" });
            });
            // Adiciona o CORS ao projeto
            services.AddCors(options => {
                options.AddPolicy("CorsPolicy",
                    builder => {
                        builder.WithOrigins("*")
                                                                    .AllowAnyHeader()
                                                                    .AllowAnyMethod();
                    }
                );
            });
        }

        // O método Configure é usado para especificar como o aplicativo responde às solicitações HTTP.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                // ativa o middleware para uso do swagger
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ChapterApi v1"));
            }

            app.UseRouting();

            // Habilita o CORS
            app.UseCors("CorsPolicy");

            // mapear os controller
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
