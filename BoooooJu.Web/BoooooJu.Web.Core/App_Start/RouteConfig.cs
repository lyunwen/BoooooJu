using System.Web.Mvc;
using System.Web.Routing;

namespace BoooooJu.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default1",
                url: "{controller}/{action}.html",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces:new string[] { "BoooooJu.Web.Core.Controllers" }
            );
            routes.MapRoute(
                name: "Default2",
                url: "{controller}/{action}/{id}.html",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Controllers" }
            );
            routes.MapRoute(
                name: "Default3",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Controllers" }
            );
        }
    }
    //顾问角色路由
    public class AgentAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Agent";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                 "Agent_default1",
                 "Areas/Agent/{controller}/{action}.html",
                 new {  action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Agent.Controllers" }
             );
            context.MapRoute(
                 "Agent_default2",
                 "Areas/Agent/{controller}/{action}/{id}.html",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Agent.Controllers" }
             );
            context.MapRoute(
                 "Agent_default3",
                 "Areas/Agent/{controller}/{action}/{id}",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Agent.Controllers" }
             );
        }
    }
    //卖主角色路由
    public class VendorAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Vendor";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                 "Vendor_default1",
                 "Areas/Vendor/{controller}/{action}.html",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Vendor.Controllers" }
             );
            context.MapRoute(
                 "Vendor_default2",
                 "Vendor/{controller}/{action}/{id}.html",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Vendor.Controllers" }
             );
            context.MapRoute(
                 "Vendor_default3",
                 "Vendor/{controller}/{action}/{id}",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Vendor.Controllers" }
             );
        }
    }
    //运营管理员角色路由
    public class ManagerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Manager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                 "Manager_default1",
                 "Manager/{controller}/{action}.html",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Manager.Controllers" }
             );
            context.MapRoute(
                 "Manager_default2",
                 "Manager/{controller}/{action}/{id}.html",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Manager.Controllers" }
             );
            context.MapRoute(
                 "Manager_default3",
                 "Manager/{controller}/{action}/{id}",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.Manager.Controllers" }
             );
        }
    }
    //超级管理员角色路由
    public class SuperManagerAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "SuperManager";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                 "SuperManager_default1",
                  "Areas/SuperManager/{controller}/{action}.html",
                 new {  action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.SuperManager.Controllers" }
             );
            context.MapRoute(
                 "SuperManager_default2",
                  "Areas/SuperManager/{controller}/{action}/{id}.html",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.SuperManager.Controllers" }
             );
            context.MapRoute(
                 "SuperManager_default3",
                  "Areas/SuperManager/{controller}/{action}/{id}",
                 new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.SuperManager.Controllers" }
             );
        }
    }
}