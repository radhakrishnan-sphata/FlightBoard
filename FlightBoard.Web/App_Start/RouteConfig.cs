using System.Web.Mvc;
using System.Web.Routing;

namespace FlightBoard.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            System.Web.Mvc.RouteCollectionExtensions.IgnoreRoute(routes, "{resource}.axd/{*pathInfo}");
            System.Web.Mvc.RouteCollectionExtensions.MapRoute(routes, "Default", "{controller}/{action}/{id}", (object)new
            {
                controller = "Account",
                action = "Login",
                id = System.Web.Mvc.UrlParameter.Optional
            });
        }
    }
}
