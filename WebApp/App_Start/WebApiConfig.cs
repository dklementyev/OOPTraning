using System.Web.Http;

namespace WebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // TODO: Add any additional configuration code.

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional  }
            );
            config.Routes.MapHttpRoute(
                name: "ApiWithAnyPrefix",
                routeTemplate: "{prefix}/api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional  }
            );
        }

    }
}