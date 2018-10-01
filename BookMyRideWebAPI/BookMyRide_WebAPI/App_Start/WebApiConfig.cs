using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BookMyRide_WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors(new EnableCorsAttribute("_http://localhost:4200", headers: "*", methods: "*"));
            // Web API routes 
           
            // Web API routes
            config.MapHttpAttributeRoutes();
            ////////////////////////////////////////////
            config.Routes.MapHttpRoute(
                      name: "MapByAction",
                      routeTemplate: "api/{controller}/{action}/{id}", defaults: new { id = RouteParameter.Optional });
            ///////////////////////////////////////////
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional }
            );
        }
    }
}
