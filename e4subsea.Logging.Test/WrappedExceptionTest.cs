using System;
using NUnit.Framework;

namespace e4subsea.Logging.Test
{
	[TestFixture]
	public class WrappedExceptionTest
	{
		[Test]
		public void Ctor_WithException_DuplicatesExceptionMessage()
		{
			var we = new WrappedException(new InvalidOperationException("Some invalid operation"));
			Assert.That(we.Message, Text.Contains("Some invalid operation"));
		}

		[Test]
		public void Ctor_WithNullException_DefaultMessage()
		{
			var we = new WrappedException((Exception)null);
			Assert.That(we.Message, Text.Contains("Missing exception information"));
		}
	}
}
