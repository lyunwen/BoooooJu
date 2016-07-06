using BoooooJu.Web.Core.Controllers.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BoooooJu.Web.Core.Filters
{
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
            // return base.AuthorizeCore(httpContext); 
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
