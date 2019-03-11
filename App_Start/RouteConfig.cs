using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace obajans
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Default",
                url: "{page}",
                defaults: new { controller = "default", action = "Index", page=1, category = "asda"   }
            );
            routes.MapRoute(
                name: "Default2",
                url: "Siyaset/{page}",
                defaults: new { controller = "default", action = "Index",category="siyaset" }
            );
            routes.MapRoute(
               name: "Default21",
               url: "Spor/{page}",
               defaults: new { controller = "default", action = "Index",category="spor" }
           );
            routes.MapRoute(
               name: "Default22",
               url: "Para/{page}",
               defaults: new { controller = "default", action = "Index" ,category="para" }
           );
            routes.MapRoute(
               name: "Default23",
               url: "Farkli/{page}",
               defaults: new { controller = "default", action = "Index",category="farkli"}
           );
            routes.MapRoute(
             name: "Default3",
             url: "haber/{id}",
             defaults: new { controller = "default", action = "haber", id = UrlParameter.Optional }
         );
            routes.MapRoute(
             name: "Default4",
             url: "icerik/hakkimizda",
             defaults: new { controller = "default", action = "hakkimizda" }
         );
           
            routes.MapRoute(
           name: "hata",
           url: "error/notfound",
           defaults: new { controller = "error", action = "NotFound" }
       );
            routes.MapRoute(
    "NotFound",
    "{*url}",
    new { controller = "Error", action = "NotFound" }
);

        }
    }
}
