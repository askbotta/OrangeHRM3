using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OrangeHRM3.POM;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRM3.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions
    {
        private readonly IWebDriver driver;
        private WebDriverWait wait;
        private readonly ScenarioContext _scenarioContext;
        private readonly LoginPage loginPage;

        public LoginPageStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            this.driver = (IWebDriver)_scenarioContext["WebDriver"];
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            this._scenarioContext = scenarioContext;
            this.loginPage = new LoginPage(driver);
        }


        [Given(@"User launches the OrangeHrm Page")]
        public void GivenUserLaunchesTheOrangeHrmPage()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            wait.Until(ExpectedConditions.UrlContains("login"));
           
        }

        [When(@"User provides userName and Password")]
        public void WhenUserProvidesUserNameAndPassword()
        {
            loginPage.EnterUserName("Admin");
            loginPage.EnterPassword("admin123");
            loginPage.ClickSubmit();


        }

        [Then(@"User validates DashBoard")]
        public void ThenUserValidatesDashBoard()
        {
            //var dashboardElement = driver.FindElement(By.CssSelector("css-selector-for-dashboard-element")); // replace with actual CSS selector
            //Assert.IsTrue(dashboardElement.Displayed, "Dashboard is not displayed or login was unsuccessful.");

        }
    }
}
