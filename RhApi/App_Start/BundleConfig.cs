using System.Web;
using System.Web.Optimization;

namespace RhApi
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                      "~/Scripts/jquery-{version}.js",
                      "~/Scrips/jquery-ui.min.js",
                      "~/Scripts/jquery.flot.js",
                      "~/Scripts/jquery.flot.resize.js",
                      "~/Scripts/jquery.flot.pie.js",
                      "~/Scripts/jquery.flot.stack.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/excanvas.min.js",
                      "~/Scripts/sparkline.js",
                      "~/Scripts/sparkline-index.js",
                      "~/Scripts/filter.js",
                      "~/Scripts/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-switch.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/style.css",
                      "~/Content/widgets.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/jquery.gritter.css",
                      "~/Content/site.css"));

            // Set EnableOptimizations to false for debugging. For more information,
            // visit http://go.microsoft.com/fwlink/?LinkId=301862
            BundleTable.EnableOptimizations = true;
        }
    }
}
