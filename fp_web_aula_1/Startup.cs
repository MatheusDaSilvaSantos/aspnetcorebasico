using fp_web_aula_1.Controllers;
using fp_web_aula_1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace fp_web_aula_1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ILoggerApi, LoggerApi>();
            services.AddScoped<INoticiaService, NoticiaService>();
            var connection =
    @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<CopaContext>(options => options.UseSqlServer(connection));

            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMeuMiddleware();

            app.UseStaticFiles();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc(r =>
            {
                //r.MapRoute(
                //name: "palestrantes",
                //template: "trilha/{nomedatrilha}",
                //defaults: new { controller = "Home", action = "listarpalestrantes" });


                r.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
