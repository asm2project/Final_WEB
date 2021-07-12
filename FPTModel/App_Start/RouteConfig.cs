using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FPTModel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional },
                namespaces: new[] { "FPTModel.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] {"FPTModel.Controllers"}
            );

            routes.MapRoute(
             name: "Choose",
             url: "{controller}/{action}/{id}",
             defaults: new { controller = "Choose", action = "Choose", id = UrlParameter.Optional },
             namespaces: new[] { "FPTModel.Controllers" }
         );


        }
    }
}
