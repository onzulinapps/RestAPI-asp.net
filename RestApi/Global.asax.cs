using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
<<<<<<< HEAD
using System.Web.Http;
=======
>>>>>>> 47e19884534cfe28e6ccec83bcabc1a7196af1d2
using RestApi.DAL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RestApi.Models;
<<<<<<< HEAD
using System.Net.Http.Formatting;
=======
>>>>>>> 47e19884534cfe28e6ccec83bcabc1a7196af1d2

namespace RestApi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
<<<<<<< HEAD
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
            MyDbContext MyDbContext = new MyDbContext();
            //configurar para devolver json 
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new QueryStringMapping("json", "true", "application/json"));

=======
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MyDbContext MyDbContext = new MyDbContext();
>>>>>>> 47e19884534cfe28e6ccec83bcabc1a7196af1d2
            // metodos para la inicializacion de la base de datos
            //Database.SetInitializer<MyDbContext>(new MyDbInitializer());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<MyDbContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<MyDbContext>());
        }
    }
}
