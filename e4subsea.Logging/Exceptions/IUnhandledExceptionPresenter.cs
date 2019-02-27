using System;

namespace e4subsea.Logging.Exceptions
{
    public interface IUnhandledExceptionPresenter
    {
        /// <summary>
        /// Signal the presenter (from a view) that an unhandled exception have occured.
        /// </summary>
        void UnhandledExceptionOccured(Exception exception);

        /// <summary>
        /// Initialize the presenter.
        /// </summary>
        void Initialize();
    }
}