using System.Web.Optimization;
using System.Web.Optimization.React;

namespace React_server_side_demo.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new BabelBundle("~/bundles/main").Include(
                "~/Scripts/CommentBox/CommentBox.jsx"
            ));

            // Forces files to be combined and minified in debug mode
            // Only used here to demonstrate how combination/minification works
            // Normally you would use unminified versions in debug mode.
            BundleTable.EnableOptimizations = true;
        }
    }
}