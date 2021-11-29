using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPS_UI.Pages.PageBreakdown
{
    public class TestRunnerPage
    {
        private readonly IWebDriver _webDriver;

        public TestRunnerPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement testRunnerBanner => _webDriver.FindElement(By.XPath("//h1[contains(text(),'Test Runner')]"));
    }
}
