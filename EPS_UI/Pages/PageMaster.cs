using EPS_UI.Pages.PageBreakdown;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace EPS_UI.Pages
{

    public class PageMaster
    {

        private readonly IWebDriver _webDriver;

        public PageMaster(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public readonly EPSHomePage _EPSHomePage;
        public readonly Sidebar _sidebar;
        public readonly TestRunnerPage _testRunnerPage;

        private PageMaster(DriverHelper driverHelper)
        {
            _EPSHomePage = new EPSHomePage(driverHelper.Current);
            _sidebar = new Sidebar(driverHelper.Current);
            _testRunnerPage = new TestRunnerPage(driverHelper.Current);
        }

    }


}
