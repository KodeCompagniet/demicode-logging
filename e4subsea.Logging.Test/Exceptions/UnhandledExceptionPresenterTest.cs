using System;
using e4subsea.Logging.Test;
using NUnit.Framework;
using Rhino.Mocks;

namespace e4subsea.Logging.Exceptions.Test
{
    [TestFixture]
    public class UnhandledExceptionPresenterTest : RequiresLog4NetTestBase
    {
        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorViewNullThrowsException()
        {
            new UnhandledExceptionPresenter(null);
        }

        [Test]
        public void UnhandledException()
        {
            var exception = new Exception("UnhandledExceptionPresenterTest.UnhandledException");

            var view = MockRepository.GenerateMock<IUnhandledExceptionView>();
            view.Stub(x => x.GetUserFeedback(Arg<Exception>.Is.Anything)).Return(UserFeedback.Empty);
            var presenter = new UnhandledExceptionPresenter(view);

            presenter.UnhandledExceptionOccured(exception);

            view.AssertWasCalled(x => x.GetUserFeedback(Arg<Exception>.Is.Equal(exception)));
            view.AssertWasCalled(x => x.ExceptionHandled(Arg<string>.Is.Equal("Thanks for your submission")));
        }

        [Test]
        public void UserCancelsSubmit()
        {
            var exception = new Exception("UnhandledExceptionPresenterTest.UnhandledException");

            var view = MockRepository.GenerateMock<IUnhandledExceptionView>();
            view.Stub(x => x.GetUserFeedback(Arg<Exception>.Is.Anything)).Return(null);

            var presenter = new UnhandledExceptionPresenter(view);
            presenter.Initialize();

            presenter.UnhandledExceptionOccured(exception);

            view.AssertWasNotCalled(x => x.ExceptionHandled(Arg<string>.Is.Anything));
        }
    }
}