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

            // Must add before default route! Define from most specific to most generic. This is because the first applicable route the program sees, it applies
            routes.MapRoute("" +
                "MoviesByReleaseDate",
                "movies/released/{year}/{month}",
                new { controller = "Movies", action = "ByReleaseDate" },
                // This following line takes in our constraints such as size in regex form
                new { year = @"2015|2016", month = @"\d{2}"}
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
