using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloWorld
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHello, Hello>();
            services.AddMvc();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IHello hello, ILogger<Startup> logger)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.UseStaticFiles();
            //app.Map("/test", TestPipeline);

            //app.UseMvcWithDefaultRoute();

            app.UseMvc(ConfigureRoutes);
            //app.Use(next => async context =>
            //{
            //    await context.Response.WriteAsync("before Hello:");
            //    await next.Invoke(context);
            //});

            app.Run(async (context) =>
            {
            //throw new Exception("Holy shit exception from Run");
            //logger.LogInformation("Request Served");
            await context.Response.WriteAsync(hello.SayHello());
            });
        }

        private static void ConfigureRoutes(IRouteBuilder routes)
        {
            routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            routes.MapRoute("shop", "shop/{controller=Home}/{action=Index}/{id?}");

        }

        private static void TestPipeline(IApplicationBuilder app)
        {
            app.MapWhen(context => { return context.Request.Query.ContainsKey("ln"); }, TestPipeline1);
            app.MapWhen(context => { return context.Request.Query.ContainsKey("q"); }, TestPipeline2);
            app.Run(async context => {
                await context.Response.WriteAsync("Hello from TestPipeline");
            });
                
        }

        private static void TestPipeline1(IApplicationBuilder app)
        {
            app.Run(async context => {
                await context.Response.WriteAsync("Hello from TestPipeline1");
            });

        }
        private static void TestPipeline2(IApplicationBuilder app)
        {
            app.Run(async context => {
                await context.Response.WriteAsync("Hello from TestPipeline2");
            });

        }

    }
}
