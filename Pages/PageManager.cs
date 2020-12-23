using OpenQA.Selenium;
using Selenium.Infrastructure;
using System;

namespace Selenium.Pages
{
    // Access object for pages. Will initialize them for furher work    
    public class PageManager
    {
        public PageManager(string browser, string baseUrl)
        {
            Driver = WebDriverFactory.GetDriver(browser);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Manage().Window.Maximize();

            if (!Driver.Url.StartsWith(baseUrl))
            {
                Driver.Navigate().GoToUrl(baseUrl);
            }

            Home = new HomePage(this);
        }
        public IWebDriver Driver { get; private set; }
        public HomePage Home { get; private set; }
    }
}
