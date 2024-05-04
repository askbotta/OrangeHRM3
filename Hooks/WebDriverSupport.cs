using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM3.Hooks
{
    [Binding]
    public class WebDriverSupport
    {
        private IWebDriver driver;
        private readonly ScenarioContext _scenarioContext;

        public WebDriverSupport(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario]
        public void CreateWebDriver()
        {
            
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _scenarioContext["WebDriver"] = driver; // storing driver in scenario context

        }

        [AfterScenario]
        public void DeleteWebDriver()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
