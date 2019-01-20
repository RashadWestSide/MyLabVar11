using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyLabVar11
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "List", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                null,
                "",
                new { controller = "Home", actuon = "List", type = 1, page = 1 }
            );

            routes.MapRoute(
                name: null,
                url: "Page{page}",
                defaults: new { conroller = "Home", action = "List", type = 1 },
                constraints: new { page = @"\d+" }
                );

            routes.MapRoute(
                null,
                "{type}",
                new { controller = "Home", action = "List", page = 1 }
                );

            routes.MapRoute(
                null,
                "{type}/Page{page}",
                new { controller = "Home", action = "List" },
                new { page = @"\d+" }
                );

            routes.MapRoute(
                null,
                "{controller}/{action}"
            );
        }
    }
}
