
using FlightBoard.Core.Utilities;

namespace FlightBoard.Core.Services
{
    public class LoggerService
    {
        public static Log4NetLoggerService logger = ServiceFactory<Log4NetLoggerService>.Instance;
    }
}