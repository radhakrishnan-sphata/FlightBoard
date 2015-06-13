
using FlightBoard.Web.Models;
using System;
using System.Security.Principal;
using System.Web.Mvc;

namespace FlightBoard.Web.Security
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class FBAuthorizeAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!string.IsNullOrEmpty(SessionPersister.Username))
            {
                filterContext.HttpContext.User = (IPrincipal)new CustomPrincipal(new CustomIdentity(SessionPersister.Username));
                base.OnActionExecuting(filterContext);
            }
            else
                filterContext.Result = (ActionResult)new HttpUnauthorizedResult();
        }
    }
}
