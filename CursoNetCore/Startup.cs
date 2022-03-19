using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models;


namespace CursoNetCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            /* 
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddTransient<NoticiaService, NoticiaService>();
            services.AddTransient<AutorService, AutorService>();
            services.AddTransient<TarjetaCreditoService, TarjetaCreditoService>(); */
            services.AddControllers();
            /* services.AddCors(options => {
                options.AddPolicy("PermitirTodo",
                acceso => acceso.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
            }); */
            //leyendo appsettings
            string url = Convert.ToString(Configuration.GetSection("URL").Value);
            //string url = Convert.ToString(Configuration.GetSection("AllowedHosts").Value);

            // Enable CORS so the Vue client can send requests
            services.AddCors(options =>{
                options.AddPolicy("PermitirUrl",
                acceso => acceso.WithOrigins(url)
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
