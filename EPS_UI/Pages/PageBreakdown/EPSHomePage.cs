using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using IronOcr;

namespace EPS_UI.Pages.PageBreakdown
{
    public class EPSHomePage
    {
        private readonly IWebDriver _webDriver;

        public EPSHomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public IWebElement epsHomeBanner  => _webDriver.FindElement(By.XPath("//h1[contains(text(),'Welcome to End-Point')]"));
        public IWebElement roqLogo => _webDriver.FindElement(By.XPath("//img[@src='images / ROQ_Master_Logo_White_2019.png']"));

        public void verifyRoqLogo()
        {
          
        }
    }
}
