using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using e4subsea.Logging.Exceptions;
using log4net;
using log4net.Appender;
using log4net.Core;

namespace e4subsea.Logging
{
    /// <summary>
    /// Class that submits some information to FogBugz via log4net logging capabilities.
    /// </summary>
    public static class InfoSubmitter
    {
        private const string _resultAppenderName = "ResultFromFogBugzSubmissionAppender";

        /// <summary>
        /// Get current events from appender and clear the appender.
        /// </summary>
        private static LoggingEvent[] ExtractMemoryAppenderEvents(string appenderName, TimeSpan timeout)
        {

            var appenders = LogManager.GetRepository().GetAppenders();
            var memoryAppender = (MemoryAppender)appenders.SingleOrDefault(x => x.Name == appenderName);
            if (memoryAppender == null)
                throw new InvalidOperationException("Appender '" + appenderName + "' is not configured in log4net");
			
            var events = memoryAppender.GetEvents();
            var w = Stopwatch.StartNew();
            while (events.Length == 0)
            {
                //Wait a few milliseconds so appenders can finish their business
                Thread.Sleep(100);
                events = memoryAppender.GetEvents();
                if (w.Elapsed > timeout)
                    break;
            }

            memoryAppender.Clear();

            return events;
        }

        /// <summary>
        /// Submit information text.
        /// </summary>
        /// <param name="location">The class calling this method. Usefull to indicate where in the application we're submitting from.</param>
        /// <param name="title">Title of the submitted information</param>
        /// <param name="userFeedback">The message text</param>
        public static void Submit(Type location, string title, UserFeedback userFeedback)
        {
            Submit(location, title, userFeedback, null);
        }

        /// <summary>
        /// Submit information text.
        /// </summary>
        /// <remarks>If <paramref name="exception"/> is not null, the userFeedback and exception will be submitted as a <see cref="Level.Error"/>.</remarks>
        /// <param name="location">The class calling this method. Usefull to indicate where in the application we're submitting from.</param>
        /// <param name="title">Title of the submitted information</param>
        /// <param name="userFeedback">The message text</param>
        /// <param name="exception">Exception that we want to submit</param>
        public static void Submit(Type location, string title, UserFeedback userFeedback, Exception exception)
        {
            if (String.IsNullOrEmpty(title)) throw new ArgumentNullException("title");
            if (userFeedback == null) throw new ArgumentNullException("userFeedback");

            var logger = LogManager.GetLogger(location);

            if (exception == null)
            {
                // We're using Exception here to pass the "Extra" data to the webappender
                logger.Info(title, new Exception(userFeedback.ToString()));
            }
            else
            {
                // We're using Exception here to pass the "Extra" data to the webappender
                logger.Error(title, new WrappedException(userFeedback.ToString(), exception));
            }
        }


        /// <summary>
        /// Return status of the latest submitted message.
        /// </summary>
        public static string GetSubmittedMessageStatus()
        {
            var events = ExtractMemoryAppenderEvents(_resultAppenderName, TimeSpan.FromSeconds(3));
            if (events.Length > 0)
            {
                var message = events[0];
                var resultText = (string) (message.Properties["webappender:Result"] ?? String.Empty);
                return GetResultMessage(resultText);
            }

            return String.Empty;
        }

        private static string GetResultMessage(string resultText)
        {
            var x = XElement.Parse(resultText);
            return x.Value;
        }
    }
}