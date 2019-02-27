using System;
using System.IO;
using log4net;
using log4net.Config;
using NUnit.Framework;

// ReSharper disable CheckNamespace

namespace DemiCode.Logging.log4net.Test
{
	[TestFixture]
	public class FiltersTest
	{
		[SetUp]
		public void SetUp()
		{
			XmlConfigurator.Configure(new Uri(Path.GetFullPath(@".\log4net.config")));
			LogHelper.ResetMemoryAppender("FilteredByHostNameAppender");
		}

		[TearDown]
		public void TearDown()
		{
			LogManager.ResetConfiguration();
		}

		[Test, Explicit]
		public void FilteredByHostName()
		{
			var log = LogManager.GetLogger(typeof (FiltersTest));
			log.Debug("This is a test message");

			var events = LogHelper.GetMemoryAppenderEvents("FilteredByHostNameAppender");

			Assert.That(events, Has.Length.EqualTo(1));
		}
	}
}
