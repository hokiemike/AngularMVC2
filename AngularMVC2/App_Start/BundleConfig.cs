
using System;
using System.Web;
using System.Web.Optimization;

namespace AngularMVC2
{
    public class BundleConfig
    {

        public static void AddDefaultIgnorePatterns(IgnoreList ignoreList)
        {
            if (ignoreList == null)
                throw new ArgumentNullException("ignoreList");
            ignoreList.Ignore("*.intellisense.js");
            ignoreList.Ignore("*-vsdoc.js");
            ignoreList.Ignore("*.debug.js", OptimizationMode.WhenEnabled);
            //ignoreList.Ignore("*.min.js", OptimizationMode.WhenDisabled);
            //ignoreList.Ignore("*.min.css", OptimizationMode.WhenDisabled);
        }

       

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.IgnoreList.Clear();
            AddDefaultIgnorePatterns(bundles.IgnoreList);

            //CSS

           
            //site css
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/bootstrap-theme.min.css",
                "~/Content/site.css"));


            //javascript

            //jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // 3rd Party JavaScript files
            bundles.Add(new ScriptBundle("~/bundles/jslibs")
                //.IncludeDirectory("~/Scripts/lib", "*.js", searchSubdirectories: false));
                .Include(
                //"~/Scripts/lib/json2.js", // IE7 needs this

                    //bootstrap
                    "~/Scripts/bootstrap.min.js",

                    //angular
                    "~/Scripts/angular/libs/angular.min.js",
                    "~/Scripts/angular/app.js",
                    "~/Scripts/angular/filters.js",

                    
                    // Other 3rd party libraries
                    "~/Scripts/underscore-{version}.js"

                    ));


            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));


            
        }
    }
}