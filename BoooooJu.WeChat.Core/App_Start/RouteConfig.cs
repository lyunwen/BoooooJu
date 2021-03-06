﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BoooooJu.WeChat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces:new string[] { "BoooooJu.Web.Core.Controllers" }
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
                 "Agent_default",
                 "Areas/Agent/{controller}/{action}/{id}",
                 new {  action = "Index", id = UrlParameter.Optional },
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
                 "Vendor_default",
                 "Areas/Vendor/{controller}/{action}/{id}",
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
                 "Manager_default",
                 "Manager/{controller}/{action}/{id}",
                 new {  action = "Index", id = UrlParameter.Optional },
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
                 "SuperManager_default",
                  "Areas/SuperManager/{controller}/{action}/{id}",
                 new {  action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BoooooJu.Web.Core.Areas.SuperManager.Controllers" }
             );
        }
    }
}