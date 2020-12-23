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
            var baseUrl = "https://dotnetfiddle.net/";
            var browser = "chrome";

            Pages = new PageManager(browser, baseUrl);
        }

        [TearDown]
        public void StopApplication()
        {
            DriverManager.CloseDriver(Pages.Driver);
        }
    }
}
