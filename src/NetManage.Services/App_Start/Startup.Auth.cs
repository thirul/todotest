using System.Web.Http;
using Owin;
using Microsoft.Owin.Cors;
using Watson.Client.Services.Ioc;

namespace NetManage.Services
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            // dependency resolver
            config.DependencyResolver = DependencyRegistration.BuildResolver();

            // enable cors
            app.UseCors(CorsOptions.AllowAll);

            // web api config            
            WebApiConfig.Register(config);
            app.UseWebApi(config);


            // default pipe
            app.Use(async(ctx,next) =>
            {
                await ctx.Response.WriteAsync("Welcome to OWIN pipeline.");
            });
        }
    }
}