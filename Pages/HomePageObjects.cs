namespace SpecflowTest.Pages
{
    using OpenQA.Selenium;
    public class HomePageObjects
    {
        private IWebDriver Driver;
        public HomePageObjects(IWebDriver driver)
        {
            Driver = driver;
        }
        private IWebElement lnkBranchFinder => Driver.FindElement(By.XPath("//span[text()='Branch Finder']"));

        public void ClickOnBranchDetailsLink()
        {
            lnkBranchFinder.Click();
        }
    }
}