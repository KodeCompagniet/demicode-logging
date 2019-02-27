using System;
using Autofac;
using Autofac.Builder;
using Autofac.Core;

namespace e4subsea.Logging.Exceptions
{
    public class ExceptionsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserFeedbackForm>();
            
            builder.RegisterType<UnhandledExceptionPresenter>();
            builder.RegisterGeneratedFactory<Func<IUnhandledExceptionView, IUnhandledExceptionPresenter>>(new TypedService(typeof(UnhandledExceptionPresenter)));
            
            builder.RegisterType<UnhandledExceptionView>().As<IUnhandledExceptionView>();
        }
    }
}