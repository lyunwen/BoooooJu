//using BoooooJu.Web.Core.Controllers.Base;
//using System;
//using System.Web;
//using System.Web.Mvc;

//namespace BoooooJu.Web.Core.Filters
//{
//    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
//    public class BoAuthorizeAttribute : ActionFilterAttribute
//    {
//        public BoAuthorizeAttribute(BoooooJuPermit permit)
//        {
//            permits = (int)permit;
//        }
//        public readonly int permits;

//        public override void OnActionExecuting(ActionExecutingContext filterContext)
//        {
//            BoooooJuer boooooJuer = filterContext.HttpContext.Session[SessionConfig.BoooooJuer] as BoooooJuer;
//            if (boooooJuer == null)
//            {
//                string returnUrl = filterContext.HttpContext.Server.UrlEncode(filterContext.HttpContext.Request.Url.ToString());
//                filterContext.HttpContext.Response.Redirect("~/wwwroot/StaticHtml/NotAllow.Html?returnUrl=" + returnUrl);
//            }
//            else
//            {
//                //超级管理员
//                if (boooooJuer.Permits == (int)BoooooJuPermit.SuperManager)
//                    return;
//                //非超级管理员
//                int access = permits & boooooJuer.Permits;
//                if (access <= 0)
//                {
//                    string returnUrl = filterContext.HttpContext.Server.UrlEncode(filterContext.HttpContext.Request.Url.ToString());
//                    filterContext.HttpContext.Response.Redirect("~/wwwroot/StaticHtml/NotAllow.Html?returnUrl=" + returnUrl); 
//                }
//            }
//        }
//    }
//}
