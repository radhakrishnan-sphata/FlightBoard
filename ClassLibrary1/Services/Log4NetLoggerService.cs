

using log4net;
using System;

namespace FlightBoard.Core.Services
{
    public class Log4NetLoggerService
    {
        private ILog _logger;

        public Log4NetLoggerService()
        {
            this._logger = LogManager.GetLogger(this.GetType());
        }

        public void Info(string message)
        {
            this._logger.Info((object)message);
        }

        public void Warn(string message)
        {
            this._logger.Warn((object)message);
        }

        public void Debug(string message)
        {
            this._logger.Debug((object)message);
        }

        public void Error(string message)
        {
            this._logger.Error((object)message);
        }

        public void Error(Exception ex)
        {
            this._logger.Error((object)ex.Message, ex);
        }

        public void Fatal(string message)
        {
            this._logger.Fatal((object)message);
        }

        public void Fatal(Exception ex)
        {
            this._logger.Fatal((object)ex.Message, ex);
        }
    }
}
