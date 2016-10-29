using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //Attribute route
            routes.MapMvcAttributeRoutes();
            //custom routes always should be before default route
            //routes.MapRoute("MoviesByReleaseDate", 
            //    "movies/released/{year}/{month}", 
            //    new {controller = "Movies", action = "ByReleaseDate"},
            //    new {year = @"2015|2016", month = @"\d{2}"});
            //new {year = @"\d{4}", month = @"\d{2}"});

            //default route
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
