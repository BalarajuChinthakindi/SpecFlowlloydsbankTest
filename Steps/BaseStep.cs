using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowTest.Drivers;
using TechTalk.SpecFlow;

namespace SpecflowTest.Steps
{
    [Binding]
    public class BaseStep
    {
        public static IWebDriver Driver = null;

        [BeforeScenario]
        public void GetDriver()
        {
            String Browser = ConfigurationManager.AppSettings["Browser"];
            String AppURL = ConfigurationManager.AppSettings["ApplicationURL"];
            Driver = new DriverManager().InitialiseWebDriver(Browser);
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            Driver.Navigate().GoToUrl(AppURL);
          
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver?.Quit();
        }
    }
}