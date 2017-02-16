using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Tests.Steps
{
    [Binding]
    public class EmployeeTestFeatureSteps : TestBase
    {
        private IWebDriver driver;

        [Given(@"I am in Log In page")]
        public void GivenIAmInLogInPage()
        {
            driver = TestBase.Driver;
            driver.Navigate().GoToUrl( BaseUrl + "/Authentication/Login");
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSecon‌​ds(10));
        }

        [Given(@"I have entered Username and Password")]
        public void GivenIHaveEnteredUsernameAndPassword(Table table)
        {
            var userNameField = driver.FindElement(By.Id("UserName"));
            var userPasswordField = driver.FindElement(By.Id("Password"));
            userNameField.SendKeys(table.Rows[0]["UserName"].ToString());
            userPasswordField.SendKeys(table.Rows[0]["Password"].ToString());
        }

        [When(@"I press Log In")]
        public void WhenIPressLogIn()
        {
            var loginButton = driver.FindElement(By.Id("BtnLogin"));
            loginButton.Click();
        }

        [Then(@"I am authenticated")]
        public void ThenIAmAuthenticated()
        {
            var userInfo = driver.FindElement(By.Id("userInfo"));
            Assert.AreEqual(userInfo.Text, "Hello, Admin Logout");
        }

    }
}
