using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace EPS_UI
{
    [Binding]
    class TestHooks
    {
        public TestContext TestContext { get; set; }

        [BeforeScenario]
        public static void BeforeScenario(DriverHelper driverHelper)
        {
            //driverHelper.Current.Navigate().GoToUrl("https://do.roq-endpoint.co.uk/");

            driverHelper.Current.Navigate().GoToUrl(TestContext.Parameters["EPSHome"]);
        }
        [AfterScenario]
        public void CloseWebDriver(DriverHelper driverHelper)
        {
            driverHelper.Current.Close();
        }
    }
}
