using NUnit.Framework;

namespace e4subsea.Logging.Exceptions.Test
{
    [TestFixture]
    public class UserFeedbackTest
    {
        [Test]
        public void ToStringTest()
        {
            var fb = new UserFeedback ("Peter", "This doesn't work!!");

            Assert.That(fb.ToString(), Is.EqualTo("Username: Peter\nInfo:\nThis doesn't work!!"));
        }
    }
}