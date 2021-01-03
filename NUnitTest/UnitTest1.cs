using B2BCore.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using NUnit.Framework;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var home = new HomeController(new NullLogger<HomeController>());
            var index = home.Index();
            Assert.AreEqual(index, null);
        }
    }
}