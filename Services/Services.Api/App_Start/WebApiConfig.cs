using System.Web.Http;
using AspNetIdentity.Logic.Core.Utils;
using Autofac.Integration.WebApi;

namespace Services.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            StartupUtil.InitLogic();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(StartupUtil.Container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
