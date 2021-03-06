using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Grupo2.eCommerceMVC.UI.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Panel",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Panel", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Login",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Registro",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Registro", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
