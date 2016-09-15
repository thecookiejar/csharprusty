using System.Web;
using System.Web.Optimization;

namespace TechJunkie
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Vendor/Components/jquery/dist/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Vendor/Components/bootstrap/dist/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/bundles/bootstrap_css").Include(
                      "~/Vendor/Components/bootstrap/dist/css/bootstrap.css"));
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/Styles.css"));

        }
    }
}