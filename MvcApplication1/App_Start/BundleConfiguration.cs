using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MvcApplication1
{
    public static class BundleConfiguration
    {
        public static void RegisterBundles(BundleCollection bundles) {
            var myBundle = new ScriptBundle("~/bundles/js");
            myBundle.Include("~/Scripts/jquery-2.0.3.min.js");
        }

    }
}