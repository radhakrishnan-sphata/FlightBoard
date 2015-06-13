using System.Web.Mvc;

namespace FlightBoard.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add((object)new HandleErrorAttribute());
        }
    }
}