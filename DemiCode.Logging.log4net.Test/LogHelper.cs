using System.Linq;
using log4net;
using log4net.Appender;
using log4net.Core;
using NUnit.Framework;

namespace DemiCode.Logging.log4net.Test
{
	public static class LogHelper
	{
		public static void ResetMemoryAppender(string appenderName)
		{
			var memoryAppender = (MemoryAppender)LogManager.GetRepository().GetAppenders().Single(x => x.Name == appenderName);
			memoryAppender.Clear();
		}

		public static LoggingEvent[] GetMemoryAppenderEvents(string appenderName)
		{
			var memoryAppender = (MemoryAppender) LogManager.GetRepository().GetAppenders().Single(x => x.Name == appenderName);
			return memoryAppender.GetEvents();
		}

		public static void AssertWebAppenderResult(LoggingEvent message)
		{
			var result = message.Properties["webappender:Result"] as string;
			Assert.AreEqual(result, "<?xml version=\"1.0\" ?><Success>Thanks for your submission</Success>");
		}
	}
}