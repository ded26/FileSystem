namespace FileSystem.WebApi.App_Start
{
    using System;
    using System.Linq;
    using System.Web.Optimization;

    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            RegisterScripts(bundles);
            RegisterStyles(bundles);
        }

        private static void RegisterStyles(BundleCollection bundles)
        {
            Action<string, string[]> newBundle = (s, strings) => bundles.Add(new StyleBundle("~/" + s).Include(strings.Select(s1 => "~/" + s1).ToArray()));

            newBundle("bootstrap", new[]
            {
                "content/bootstrap.min.css"
            });
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            Action<string, string[]> newBundle = (s, strings) => bundles.Add(new ScriptBundle("~/" + s).Include(strings.Select(s1 => "~/" + s1).ToArray()));

            newBundle("jquery", new[]
            {
                "scripts/jquery-{version}.js"
            });

            newBundle("bootstrapjs", new[]
            {
                "scripts/bootstrap.min.js"
            });

            newBundle("ajax", new[]
            {
                "scripts/jquery.unobtrusive-ajax.js"
            });

            newBundle("angularjs", new[]
            {
                "scripts/angular.js"
            });

            newBundle("fsapp", new[]
            {
                "scripts/app/filesystem-controller.js"
            });
        }
    }
}