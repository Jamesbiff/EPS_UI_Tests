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
        //public readonly EPSHomePage _EPSHomePage;
        //public readonly Sidebar _sidebar;
        //public readonly TestRunnerPage _testRunnerPage;

        private readonly IWebDriver _webdriver;

        public PageMaster(IWebDriver webdriver)
        {
            _webdriver = webdriver;
        }


        //public PageMaster(DriverHelper driverHelper)
        //{
        //    _EPSHomePage = new EPSHomePage(driverHelper.Current);
        //    _sidebar = new Sidebar(driverHelper.Current);
        //    _testRunnerPage = new TestRunnerPage(driverHelper.Current);
        //}

        public EPSHomePage EPSHomePage => new EPSHomePage(_webdriver);
        public TestRunnerPage TestRunnerPage => new TestRunnerPage(_webdriver);
        public Sidebar Sidebar => new Sidebar(_webdriver);
        
    }


}
