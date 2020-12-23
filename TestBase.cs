using NUnit.Framework;
using Selenium.Pages;
using Selenium.Driver;

namespace Selenium
{
    [TestFixture]
    public class TestBase
    {
        protected PageManager Pages { get; private set; }
        
        [SetUp]
        public void StartApplication()
        {
        }

        [TearDown]
        public void StopApplication()
        {
        }
    }
}
