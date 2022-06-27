using System.Web;
using System.Web.Optimization;

namespace PortalControleTI.Portal
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Gentelella/Layout/css").Include(
                      "~/Gentelella/bootstrap/dist/css/bootstrap.min.css",
                      "~/Gentelella/font-awesome/css/font-awesome.min.css",
                      "~/Gentelella/build/css/custom.min.css"));

            bundles.Add(new ScriptBundle("~/Gentelella/Layout/scripts").Include(
                        "~/Gentelella/jquery/dist/jquery.min.js",
                        "~/Gentelella/bootstrap/dist/js/bootstrap.bundle.min.js",
                        "~/Gentelella/build/js/custom.min.js"));

            bundles.Add(new StyleBundle("~/Gentelella/DataTable/css").Include(
                      "~/Gentelella/datatables.net-bs/css/dataTables.bootstrap.min.css",
                      "~/Gentelella/datatables.net-buttons-bs/css/buttons.bootstrap.min.css",
                      "~/Gentelella/datatables.net-fixedheader-bs/css/fixedHeader.bootstrap.min.css",
                      "~/Gentelella/datatables.net-responsive-bs/css/responsive.bootstrap.min.css",
                      "~/Gentelella/datatables.net-scroller-bs/css/scroller.bootstrap.min.css"));

            bundles.Add(new ScriptBundle("~/Gentelella/DataTable/scripts").Include(
                        "~/Gentelella/datatables.net/js/jquery.dataTables.min.js",
                        "~/Gentelella/datatables.net-bs/js/dataTables.bootstrap.min.js",
                        "~/Gentelella/datatables.net-buttons/js/dataTables.buttons.min.js",
                        "~/Gentelella/datatables.net-buttons-bs/js/buttons.bootstrap.min.js",
                        "~/Gentelella/datatables.net-buttons/js/buttons.flash.min.js",
                        "~/Gentelella/datatables.net-buttons/js/buttons.html5.min.js",
                        "~/Gentelella/datatables.net-buttons/js/buttons.print.min.js",
                        "~/Gentelella/datatables.net-fixedheader/js/dataTables.fixedHeader.min.js",
                        "~/Gentelella/datatables.net-keytable/js/dataTables.keyTable.min.js",
                        "~/Gentelella/datatables.net-responsive/js/dataTables.responsive.min.js",
                        "~/Gentelella/datatables.net-responsive-bs/js/responsive.bootstrap.js",
                        "~/Gentelella/datatables.net-scroller/js/dataTables.scroller.min.js",
                        "~/Gentelella/jszip/dist/jszip.min.js",
                        "~/Gentelella/pdfmake/build/pdfmake.min.js",
                        "~/Gentelella/pdfmake/build/vfs_fonts.js"));
        }
    }
}
