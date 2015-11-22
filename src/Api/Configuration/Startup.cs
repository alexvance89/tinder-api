using System.Web.Http;
using Microsoft.Owin;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi.OwinHost;
using Owin;
using Tinder.Api.Configuration;

[assembly: OwinStartup(typeof(Startup))]

namespace Tinder.Api.Configuration
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = CreateHttpConfiguration();

            app.UseNinjectMiddleware(Ninject.CreateKernel);
            app.UseNinjectWebApi(config);
        }

        private static HttpConfiguration CreateHttpConfiguration()
        {
            var config = new HttpConfiguration();

            config.Formatters.Clear();
            config.Formatters.Add(new JilFormatter());
            
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            return config;
        }
    }
}