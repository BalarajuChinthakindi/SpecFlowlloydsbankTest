using SpecflowTest.Steps;

namespace SpecflowTest.Pages
{
    using OpenQA.Selenium;
    public class BranchDetailsPageObjects 
    {
        private IWebDriver Driver;

        public BranchDetailsPageObjects(IWebDriver driver)
        {
            Driver = driver;
        }
        
        private IWebElement labelLocationName => Driver.FindElement(By.XPath("//span[@class='LocationName-geo']"));
        private IWebElement labeAddress_Street => Driver.FindElement(By.XPath("//span[@class='c-address-street-1']"));
        private IWebElement labelAddress_City => Driver.FindElement(By.XPath("//span[@class='c-address-city']"));
        private IWebElement labelAddress_Postcode => Driver.FindElement(By.XPath("//span[@class='c-address-postal-code']"));
        private IWebElement labelSaturdayHrs => Driver.FindElement(By.XPath("//tr[@content='Sa Closed']/td[2]"));
        private IWebElement labelSundayHrs => Driver.FindElement(By.XPath("//tr[@content='Su Closed']/td[2]"));

        public string getLocationName()
        {
            return labelLocationName.Text.Trim();
        }
        
        public string getStreetName()
        {
            return labeAddress_Street.Text.Trim();
        }
        
        public string getCityName()
        {
            return labelAddress_City.Text.Trim();
        }
        
        public string getPostcode()
        {
            return labelAddress_Postcode.Text.Trim();
        }
        
        public string getSaturdayHrs()
        {
            return labelSaturdayHrs.Text.Trim();
        }
        
        public string getSundayHrs()
        {
            return labelSundayHrs.Text.Trim();
        }
    }
}