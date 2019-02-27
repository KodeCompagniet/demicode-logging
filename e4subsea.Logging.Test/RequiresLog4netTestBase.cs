using System;
using System.IO;
using System.Linq;
using log4net;
using log4net.Appender;
using log4net.Config;
using NUnit.Framework;

namespace e4subsea.Logging.Test
{
    /// <summary>
    /// Base class for tests that requires that log4net is configured.
    /// </summary>
    public abstract class RequiresLog4NetTestBase
    {
        [SetUp]
        public void SetUp()
        {
            LogManager.ResetConfiguration();
            XmlConfigurator.Configure(new Uri(Path.GetFullPath(@".\log4net.config")));
            ResetMemoryAppender("ResultFromFogBugzSubmissionAppender");
        }

        [TearDown]
        public void TearDown()
        {
            LogManager.ResetConfiguration();
        }

        private static void ResetMemoryAppender(string appenderName)
        {
            var memoryAppender = (MemoryAppender)LogManager.GetRepository().GetAppenders().Single(x => x.Name == appenderName);
            memoryAppender.Clear();
        }
    }
}