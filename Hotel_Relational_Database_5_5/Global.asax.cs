using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using Hotel_Relational_Database_5_5.Models;

namespace Hotel_Relational_Database_5_5
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<Hotel_Relational_Database_5_5Context>(new DropCreateDatabaseIfModelChanges<Hotel_Relational_Database_5_5Context>());
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
