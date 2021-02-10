using System.Web;
using System.Web.Optimization;

namespace Momenty.Web
{ 
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Static/js/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Static/js/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Static/js/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Static/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Static/css/bootstrap.css",
                      "~/Static/css/site.css"));
        }
    }
}
