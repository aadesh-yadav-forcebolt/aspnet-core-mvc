using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async(context,next) => {
            //    await context.Response.WriteAsync("Hello from frist middleware.");
            //    await next();
            //    await context.Response.WriteAsync(" Hello from frist middleware 2nd time.");
            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync(" Hello from Second middleware.");
            //    await next();
            //    await context.Response.WriteAsync(" Hello Second frist middleware 2nd time.");
            //});

            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync(" Hello from third middleware.");
            //    await next();
            //});

            app.UseStaticFiles();
            
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
                
                endpoints.MapDefaultControllerRoute();
            });

            //http:domain.com/controllerName/ActionMethoName


            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/login", async context =>
                {
                    await context.Response.WriteAsync("logged In...");
                });


            });
        }
    }
}


//routes.MapRoute(
//    name: "Default",
//    url: "{controller}/{action}/{id}",
//    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
//);