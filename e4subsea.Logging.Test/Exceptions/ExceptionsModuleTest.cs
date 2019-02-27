using Autofac;
using NUnit.Framework;

namespace e4subsea.Logging.Exceptions.Test
{
    [TestFixture]
    public class ExceptionsModuleTest
    {
        [Test]
        public void Load()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ExceptionsModule());

            using (var container = builder.Build())
            {
                var view = container.Resolve<IUnhandledExceptionView>();
                Assert.That(view, Is.Not.Null);
            }
        }
    }
}