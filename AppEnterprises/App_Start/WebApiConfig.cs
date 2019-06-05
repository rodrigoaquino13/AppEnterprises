using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AppEnterprises
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "EmpresasCodigo",
            //    routeTemplate: "api/v1/enterprises/{codigo}",
            //    defaults: new { controller = "empresas" }
            //);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            /*
            config.Routes.MapHttpRoute(
                name: "Empresas",
                routeTemplate: "api/{v:apiVersion}/enterprises",
                defaults: new { controller = "empresas" }
            );

            config.Routes.MapHttpRoute(
                name: "EmpresasTipo",
                routeTemplate: "api/{v:apiVersion}/enterprises/{codigo}/{tipo}",
                defaults: new { controller = "empresas" }
            );*/
        }
    }
}
