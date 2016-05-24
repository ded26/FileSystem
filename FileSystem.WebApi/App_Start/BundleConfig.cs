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
        }

        private static void RegisterScripts(BundleCollection bundles)
        {
            Action<string, string[]> NewBundle = (s, strings) => bundles.Add(new ScriptBundle("~/" + s).Include(strings.Select(s1 => "~/" + s1).ToArray()));

            NewBundle("jquery", new[]
            {
                "scripts/jquery-{version}.js"
            });

            NewBundle("ajax", new[]
            {
                "scripts/jquery.unobtrusive-ajax.js"
            });

            NewBundle("angularjs", new[]
            {
                "scripts/angular.js"
            });

            NewBundle("fsapp", new[]
            {
                "scripts/app/filesystem-controller.js"
            });
        }
    }
}