using BoooooJu.Web.Core.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class BoAuthorizeAttribute : AuthorizeAttribute
    {
        public BoAuthorizeAttribute(Controllers.Base.BoooooJuPermit permit)
        {
            permits = (int)permit;
        }
        public readonly int permits;
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            BoooooJuer boooooJuer = filterContext.HttpContext.Session[SessionConfig.BoooooJuer] as BoooooJuer;
            if (boooooJuer == null)
            {
                string returnUrl = filterContext.HttpContext.Server.UrlEncode(filterContext.HttpContext.Request.Url.ToString());
                filterContext.HttpContext.Response.Redirect("~/wwwroot/StaticHtml/Error.Html?returnUrl=" + returnUrl);
            }
            else
            {
                if (!boooooJuer.IsSuperAdmin)
                {
                    int access = permits & boooooJuer.Permits;
                    if (access <= 0)
                    {
                        string returnUrl = filterContext.HttpContext.Server.UrlEncode(filterContext.HttpContext.Request.Url.ToString());
                        filterContext.HttpContext.Response.Redirect("~/wwwroot/StaticHtml/NotAllow.Html?returnUrl=" + returnUrl);
                    }
                }
            }
            base.OnAuthorization(filterContext);
        }
    }
}
