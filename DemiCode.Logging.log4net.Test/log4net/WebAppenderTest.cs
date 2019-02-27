using System;
using System.IO;
using log4net;
using log4net.Config;
using NUnit.Framework;

// ReSharper disable CheckNamespace

namespace DemiCode.Logging.log4net.Test
{
	[TestFixture]
	public class WebAppenderTest
	{
	    [SetUp]
		public void SetUp()
		{
			XmlConfigurator.Configure(new Uri(Path.GetFullPath(@".\log4net.config")));
			LogHelper.ResetMemoryAppender("ResultFromFogBugzSubmissionAppender");
		}

		[TearDown]
		public void TearDown()
		{
			LogManager.ResetConfiguration();
		}

	    [Test, Category("Integration")]
		public void LogError()
		{
			const string infoMessage = "This is some error going to demicode.fogbugz.com";

			// Log some info to FogBugz
			var logger = LogManager.GetLogger(typeof (WebAppenderTest));
			logger.Error(infoMessage);

			var events = LogHelper.GetMemoryAppenderEvents("ResultFromFogBugzSubmissionAppender");
			Assert.AreEqual(1, events.Length);
			var message = events[0];

			LogHelper.AssertWebAppenderResult(message);
		}

		[Test, Category("Integration")]
		public void LogInfo()
		{
			const string infoMessage = "This is some information going to demicode.fogbugz.com";

			// Log some info to FogBugz
			var logger = LogManager.GetLogger(typeof (WebAppenderTest));
			logger.Info(infoMessage, new Exception("Extra information to add to the case"));

			var events = LogHelper.GetMemoryAppenderEvents("ResultFromFogBugzSubmissionAppender");
			Assert.AreEqual(1, events.Length);
			var message = events[0];

			LogHelper.AssertWebAppenderResult(message);
		}
	}
}