using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using RestApi.DAL;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using RestApi.Models;

namespace RestApi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MyDbContext MyDbContext = new MyDbContext();
            // metodos para la inicializacion de la base de datos
            //Database.SetInitializer<MyDbContext>(new MyDbInitializer());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<MyDbContext>());
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MyDbContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<MyDbContext>());
        }
    }
}
