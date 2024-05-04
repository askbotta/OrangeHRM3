using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM3.POM
{
    [Binding]
    public class LoginPage
    {
       private readonly IWebDriver driver;

        //locators
        private By _UsernameLocator = By.XPath("//input[@name='username']");
        private By _passwordLocator = By.XPath("//input[@name='password']");
        private By _submitButtonLocator = By.XPath("//button[@type='submit']");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterUserName(string username)
        {
            driver.FindElement(_UsernameLocator).SendKeys(username);
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(_passwordLocator).SendKeys(password);
        }
        public void ClickSubmit()
        {
            driver.FindElement(_submitButtonLocator).Click();
        }
    }
}
