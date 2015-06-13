
using FlightBoard.Core.Services;
using System.Web.Mvc;

namespace FlightBoard.Web.Controllers
{
    public class BaseController : Controller
    {
        public Log4NetLoggerService _loggerService = new Log4NetLoggerService();
    }
}