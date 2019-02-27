using System;

namespace e4subsea.Logging.Exceptions
{
    public class UnhandledExceptionPresenter : IUnhandledExceptionPresenter
    {
        private readonly IUnhandledExceptionView _view;

        public UnhandledExceptionPresenter(IUnhandledExceptionView view)
        {
            if (view == null) throw new ArgumentNullException("view");
            _view = view;
        }

        /// <summary>
        /// Signal the presenter (from a view) that an unhandled exception have occured.
        /// </summary>
        public void UnhandledExceptionOccured(Exception exception)
        {
            var feedback = _view.GetUserFeedback(exception);
            if (feedback == null)
                return;

            InfoSubmitter.Submit(typeof(UnhandledExceptionPresenter), "Unhandled exception occured in " + AppDomain.CurrentDomain.SetupInformation.ApplicationName, feedback, exception);
            var status = InfoSubmitter.GetSubmittedMessageStatus();
            _view.ExceptionHandled(status);
        }

        /// <summary>
        /// Initialize the presenter.
        /// </summary>
        public void Initialize()
        {
            // Currently nothing to do.
        }
    }
}