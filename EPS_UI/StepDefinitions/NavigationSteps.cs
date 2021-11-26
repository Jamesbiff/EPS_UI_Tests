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
        private readonly EPSHomePage _EPSHomePage;
        private readonly Sidebar _sidebar;
        private readonly TestRunnerPage _testRunnerPage;

        public NavigationSteps(DriverHelper driverHelper)
        {
            _EPSHomePage = new EPSHomePage(driverHelper.Current);
            _sidebar = new Sidebar(driverHelper.Current);
            _testRunnerPage = new TestRunnerPage(driverHelper.Current);
        }

        [Given(@"I am on the Endpoint homepage")]
        public void GivenIAmOnTheEndpointHomepage()
        {
            
            _EPSHomePage.epsHomeBanner.Click();
        }
        
        [When(@"I select Test Runner")]
        public void WhenISelectTestRunner()
        {
            _sidebar.testRunnerLink.Click();
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
            _testRunnerPage.testRunnerBanner.Click();
        }

        [Then(@"the manage options are expanded")]
        public void ThenTheManageOptionsAreExpanded()
        {
            _testRunnerPage.testRunnerBanner.Click();
        }

        [Then(@"the reporting options are expanded")]
        public void ThenTheReportingOptionsAreExpanded()
        {
            _testRunnerPage.testRunnerBanner.Click();
        }
    }
}
