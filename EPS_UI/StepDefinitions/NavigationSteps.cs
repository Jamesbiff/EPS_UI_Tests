using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using EPS_UI.Pages;

namespace EPS_UI.stepdefinitions
{
    [Binding]
    public class NavigationSteps
    {
        private readonly PageMaster _pageMaster;
        public NavigationSteps(DriverHelper driverHelper)
        {
            _pageMaster = new PageMaster(driverHelper.Current);
        }

        [Given(@"I am on the Endpoint homepage")]
        public void GivenIAmOnTheEndpointHomepage()
        {
            _pageMaster.EPSHomePage.epsHomeBanner.Click();
        }
        
        [When(@"I select Test Runner")]
        public void WhenISelectTestRunner()
        {
            _pageMaster.Sidebar.testRunnerLink.Click();
        }

        [When(@"I select Manage")]
        public void WhenISelectManage()
        {

        }

        [When(@"I select Reporting")]
        public void WhenISelectReporting()
        {

        }

        [Then(@"I am taken to the test runner page")]
        public void ThenIAmTakenToTheTestRunnerPage()
        {
            _pageMaster.TestRunnerPage.testRunnerBanner.Click();
        }

        [Then(@"the manage options are expanded")]
        public void ThenTheManageOptionsAreExpanded()
        {
            _pageMaster.TestRunnerPage.testRunnerBanner.Click();
        }

        [Then(@"the reporting options are expanded")]
        public void ThenTheReportingOptionsAreExpanded()
        {
            _pageMaster.TestRunnerPage.testRunnerBanner.Click();
        }
    }
}
