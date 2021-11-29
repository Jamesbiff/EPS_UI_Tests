using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace EPS_UI.Pages.PageBreakdown
{
    public class Sidebar : PageMaster
    {
        private IWebDriver _webDriver;

        public Sidebar(IWebDriver webDriver) : base(webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement testRunnerLink => _webDriver.FindElement(By.XPath("//span[contains(text(),'Test Runner')]"));


        public void navigateToEpsUi()
        {
            _webDriver.Navigate().GoToUrl("https://do.roq-endpoint.co.uk/");
        }
    }
}
