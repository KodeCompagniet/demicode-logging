using System;
using log4net;

namespace e4subsea.Logging
{
    public static class Logger
    {
        public static void Error(Type location, string message, Exception ex)
        {
            var logger = LogManager.GetLogger(location);
            logger.Error(message, ex);
        }
    }
}