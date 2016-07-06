using BoooooJu.WeChat.Core.Controllers.Base;
using System;
using System.Web;
using System.Web.Mvc;

namespace BoooooJu.WeChat.Core.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class BoAuthorizeAttribute : AuthorizeAttribute
    {
        private readonly int _roles;
        public BoAuthorizeAttribute(BoooooJuRole roles)
        {
            _roles = roles.ToInt16();
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
        }

        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            BoooooJuer booojuer = httpContext.Session[SessionConfig.BoooooJuer] as BoooooJuer;
            if (booojuer != null)
            {
                return (booojuer.Roles & _roles) > 0;
            }
            else
            {
                return false;
            } 
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new ContentResult { Content = "Not Permit!" };
            // base.HandleUnauthorizedRequest(filterContext);
        }

        protected override HttpValidationStatus OnCacheAuthorization(HttpContextBase httpContext)
        {
            return base.OnCacheAuthorization(httpContext);
        }
    }
}
