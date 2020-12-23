using OpenQA.Selenium;
using Selenium.Infrastructure;
using System;

namespace Selenium.Pages
{
    public class HomePage : BasePage
    {
        public string url = "https://dotnetfiddle.net/";
        public HomePage(PageManager pageManager)
            : base(pageManager)
        {
        }

        private IWebElement HideButton => _pageManager.Driver.FindElement(By.ClassName("sidebar-block"))
                    .FindElement(By.XPath("//button[@type='button']//span[@class='glyphicon glyphicon-chevron-left']"));

        public HomePage Open()
        {
            _pageManager.Driver.Navigate().GoToUrl(url);
            return this;
        }

        public string GetOutputValue()
        {
            IWebElement output = _pageManager.Driver.TryToFindElement(By.Id("output"));
            return output.Text;
        }

        public void PressRunButton()
        {
            IWebElement runButton = _pageManager.Driver.TryToFindElement(By.Id("run-button"));
            runButton.Click();
        }

        public void HideOptions()
        {
            HideButton.Click();
        }

        public bool OptionsIsVisible()
        {
            if (!HideButton.Displayed) return false;

            var sidebarElement = _pageManager.Driver.FindElement(By.XPath("//div[@class='sidebar unselectable']"));
            var leftProperty = sidebarElement.GetProperty("offsetLeft");
            var left = 0;

            if (!int.TryParse(leftProperty, out left))
            {
                throw new Exception("Can't retrieve value for {left} attribute");
            }

            // Options panel should have non negative {left} attribute if visible
            return left >= 0;
        }
    }
}
