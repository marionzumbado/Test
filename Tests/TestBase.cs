using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class TestBase
    {
        public string BaseUrl = "http://localhost:52732";

        private static IWebDriver driver;

        public static IWebDriver Driver
        {
            get { return driver ?? (driver = new ChromeDriver()); }
        }

        [AfterTestRun]
        public static void AfterTestRun()
        {
            Driver.Close();
            Driver.Quit();
            driver = null;
        }
    }
}
