/*
 * Copyright © KodeCompagniet AS 2006-2009.
 */

using log4net.Layout;

namespace DemiCode.Logging.log4net.Layout
{
 
    /// <summary>
    /// A <see cref="PatternLayout"/> class that adds some extra formatting tokens.
    /// </summary>
    /// <remarks>
    /// This layout adds the following token:
    /// 
    /// <list type="table">
    /// <listheader>
    /// <term>token</term>
    /// <description>token value</description>
    /// </listheader>
    /// <item>
    /// <term>exceptiontitle</term>
    /// <description>Formats the description of the exception into a unique identifiable string.</description>
    /// </item>
    /// </list>
    /// </remarks>
    public class ExtendedPatternLayout : PatternLayout
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <remarks>
        /// <para>
        /// Constructs a ExtendedPatternLayout.
        /// </para>
        /// </remarks>
        public ExtendedPatternLayout()
        {
            AddConverter("exceptiontitle", typeof(ExceptionTitlePatternConverter));
			AddConverter("exceptionmessage", typeof(ExceptionMessagePatternConverter));
        }

        #endregion

        #region Override implementation of LayoutSkeleton

        ///// <summary>
        ///// Gets the exception text from the logging event
        ///// </summary>
        ///// <param name="writer">The TextWriter to write the formatted event to</param>
        ///// <param name="loggingEvent">the event being logged</param>
        ///// <remarks>
        ///// <para>
        ///// Write the exception string to the <see cref="TextWriter"/>.
        ///// The exception string is retrieved from <see cref="LoggingEvent.GetExceptionString()"/>.
        ///// </para>
        ///// </remarks>
        //override public void Format(TextWriter writer, LoggingEvent loggingEvent)
        //{
        //    if (writer == null)
        //        throw new ArgumentNullException("writer");

        //    if (loggingEvent == null)
        //        throw new ArgumentNullException("loggingEvent");

        //    if (loggingEvent.ExceptionObject != null)
        //    {
        //        writer.Write(GetExceptionDescription(loggingEvent.ExceptionObject));
        //    }
        //}

        #endregion
    }
}
