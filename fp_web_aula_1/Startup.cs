using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace fp_web_aula_1
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ILogerApi, LogerApi>();
            services.AddMvc();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMiddleware<MeuMiddleware>();

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
