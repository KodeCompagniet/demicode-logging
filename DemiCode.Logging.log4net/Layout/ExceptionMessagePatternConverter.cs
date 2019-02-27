/*
 * Copyright © KodeCompagniet AS 2006-2009.
 */

using System;
using System.IO;
using log4net.Core;
using log4net.Layout;
using log4net.Layout.Pattern;

namespace DemiCode.Logging.log4net.Layout
{
	/// <summary>
	/// Formats the description of the exception into a unique identifiable string.
	/// </summary>
	/// <remarks>
	/// <para>
	/// This Layout must be used as a converter with <see cref="PatternLayout"/>.
	/// </para>
	/// </remarks>
	public class ExceptionMessagePatternConverter : PatternLayoutConverter
	{
		///<summary>
		///            Derived pattern converters must override this method in order to
		///            convert conversion specifiers in the correct way.
		///</summary>
		///
		///<param name="writer"><see cref="T:System.IO.TextWriter" /> that will receive the formatted result.</param>
		///<param name="loggingEvent">The <see cref="T:log4net.Core.LoggingEvent" /> on which the pattern converter should be executed.</param>
		override protected void Convert(TextWriter writer, LoggingEvent loggingEvent)
		{
			if (loggingEvent.ExceptionObject != null)
				writer.Write(GetExceptionMessage(loggingEvent.ExceptionObject));
		}

		private static string GetExceptionMessage(Exception ex)
		{
			if (String.IsNullOrEmpty(ex.Message))
				return String.Empty;

			return ex.Message;
		}
	}

}
