using System;

namespace e4subsea.Logging.Exceptions
{
    public interface IUnhandledExceptionView
    {
        /// <summary>
        /// Return a feedback message provided by the user.
        /// </summary>
        /// <param name="forException">The exception that we want feedback for</param>
        /// <returns>null if the user cancelled user feedback</returns>
        UserFeedback GetUserFeedback(Exception forException);

        /// <summary>
        /// Indicate to the view that the exception was handled.
        /// </summary>
        void ExceptionHandled(string caseStatus);

        /// <summary>
        /// Indicate to the view that an unhandled exception have occured.
        /// </summary>
        void ExternalUnhandledExceptionOccured(Exception exception);
    }
}