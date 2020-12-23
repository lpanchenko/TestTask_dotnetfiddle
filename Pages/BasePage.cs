using System;
using System.Threading;

namespace Selenium.Pages
{
    public class BasePage
    {
        protected static PageManager _pageManager;
        public BasePage(PageManager pageManager)
        {
            // Simplified approach
            // Wait until pages will be fully loaded
            _pageManager = pageManager;            
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }        
    }
}
