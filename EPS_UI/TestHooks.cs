using System;
using System.Collections.Generic;
using System.Text;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace EPS_UI
{
    [Binding]
    class TestHooks
    {

        [BeforeScenario]
        public static void BeforeScenario(DriverHelper driverHelper)
        {
            driverHelper.Current.Navigate().GoToUrl("https://do.roq-endpoint.co.uk/");
        }
        [AfterScenario]
        public void CloseWebDriver(DriverHelper driverHelper)
        {
            driverHelper.Current.Close();
        }
    }
}
