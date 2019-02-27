using System;
using System.Threading;
using System.Windows.Forms;

namespace e4subsea.Logging.Exceptions
{
    /// <summary>
    /// Simple implementation of <see cref="IUnhandledExceptionView"/>.
    /// </summary>
    public class UnhandledExceptionView : IUnhandledExceptionView
    {
        private readonly UserFeedbackForm _userFeedbackForm;
        private readonly IUnhandledExceptionPresenter _presenter;

        public UnhandledExceptionView(Func<IUnhandledExceptionView, IUnhandledExceptionPresenter> presenterFactory, UserFeedbackForm userFeedbackForm)
        {
            AppDomain.CurrentDomain.UnhandledException += OnCurrentDomainUnhandledException;
            Application.ThreadException += OnApplicationThreadException;
            
            _userFeedbackForm = userFeedbackForm;
	        
            _presenter = presenterFactory(this);
            _presenter.Initialize();
        }

        #region IUnhandledExceptionView Members

        UserFeedback IUnhandledExceptionView.GetUserFeedback(Exception forException)
        {
            return _userFeedbackForm.ShowException(forException);
        }

        void IUnhandledExceptionView.ExceptionHandled(string caseStatus)
        {
            _userFeedbackForm.ExceptionHandled(caseStatus);
        }

        /// <summary>
        /// Indicate that an exception was not handled.
        /// </summary>
        void IUnhandledExceptionView.ExternalUnhandledExceptionOccured(Exception exception)
        {
            if (exception == null) throw new ArgumentNullException("exception");
            OnUnhandledExceptionOccured(exception);
        }

        #endregion

        private void OnApplicationThreadException(object sender, ThreadExceptionEventArgs e)
        {
            OnUnhandledExceptionOccured(e.Exception);
        }

        private void OnCurrentDomainUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex != null)
                OnUnhandledExceptionOccured(ex);
        }

        private void OnUnhandledExceptionOccured(Exception exception)
        {
            _presenter.UnhandledExceptionOccured(exception);
        }

    }
}