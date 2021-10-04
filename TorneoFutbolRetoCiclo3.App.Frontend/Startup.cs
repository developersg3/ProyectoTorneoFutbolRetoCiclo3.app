using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TorneoFutbolRetoCiclo3.App.Persistencia;

namespace TorneoFutbolRetoCiclo3.App.Frontend
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
            services.AddRazorPages();
            //services.AddSingleton<IRepositorioArbitro, RepositorioArbitro>();
            services.AddSingleton<IRepositorioEquipo, RepositorioEquipo>();
            //services.AddSingleton<IRepositorioDesempeno_equipo, RepositorioDesempeno_equipo>();
            //services.AddSingleton<IRepositorioMunicipio, RepositorioMunicipio>();
            //services.AddSingleton<IRepositorioTipo_novedad, RepositorioTipo_novedad>();
            //services.AddSingleton<IRepositorioEstadio, RepositorioEstadio>();
            //services.AddSingleton<IRepositorioPosicion_jugador, RepositorioPosicion_jugador>();
            //services.AddSingleton<IRepositorioTecnico, RepositorioTecnico>();
            //services.AddSingleton<IRepositorioJugador, RepositorioJugador>();
            //services.AddSingleton<IRepositorioPartido, RepositorioPartido>();
            //services.AddSingleton<IRepositorioNovedad, RepositorioNovedad>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
