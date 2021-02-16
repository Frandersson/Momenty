using Momenty.Web.DAL.Entities;
using Momenty.Web.DAL.Migrations.MigrationRunner;
using Momenty.Web.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Momenty.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Run database migrations
            FluentMigratorRunner.RunMigrations();


            /*
            // Test case
            IFundRepository repo = new FundRepository();
            var newFund = new Fund { Name = "Test Fond 3"};

            repo.Insert(newFund);
            */
        }

    }
}
