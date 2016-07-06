using System;
using System.Web.Optimization;

namespace BoooooJu.Web.Core.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //基本Js
            bundles.Add(new ScriptBundle("~/Base/Js").Include("~/Scripts/jquery-{version}.js", "~/Scripts/commonJs.js"));

            //表单验证
            bundles.Add(new ScriptBundle("~/Js/Validate").Include("~/Scripts/jquery.validate.js"));

            //分页
            bundles.Add(new ScriptBundle("~/Js/Page").Include("~/Scripts/Page.js"));

            //bootstrap
            bundles.Add(new ScriptBundle("~/Js/Bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Css/Bootstrap").Include("~/wwwroot/css/public/bootstrap.css"));
        }
    }
}
