using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace SpecflowTest.Drivers
{
    public class DriverManager
    {
        public IWebDriver InitialiseWebDriver(string sBrowserName)
        {
            switch (sBrowserName)
            {
                case "Chrome":
                    return new ChromeDriver();
                case "Firefox":
                    return new FirefoxDriver();
                default:
                    return new ChromeDriver();
            }
        }
    }
}