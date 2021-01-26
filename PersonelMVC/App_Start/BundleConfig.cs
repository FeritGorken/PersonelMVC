using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace PersonelMVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                    "~/Scripts/custom.js",
                    "~/Scripts/jquery.unobtrusive-ajax.min.js",
                    "~/Scripts/bootbox.min.js",
                    "~/Scripts/DataTables/jquery.dataTables.min.js",
                    "~/Scripts/DataTables/dataTables.bootstrap.min.js"
                ));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/DataTables/css/dataTables.bootstrap.min.css",
                "~/Content/site.css"
                ));
        }
    }
}