using OpenQA.Selenium;

namespace Selenium.Driver
{
    public static class DriverManager
    {
        public static void CloseDriver(IWebDriver driver)
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
