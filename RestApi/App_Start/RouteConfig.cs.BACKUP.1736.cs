using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

<<<<<<< HEAD

=======
>>>>>>> 47e19884534cfe28e6ccec83bcabc1a7196af1d2
namespace RestApi
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
<<<<<<< HEAD
        } 
   
=======
        }
>>>>>>> 47e19884534cfe28e6ccec83bcabc1a7196af1d2
    }
}
