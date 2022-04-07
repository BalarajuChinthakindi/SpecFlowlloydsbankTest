using System;
using System.Collections.ObjectModel;

namespace SpecflowTest.Pages
{
    using OpenQA.Selenium;
    using System.Collections.Generic;
    using System.Linq;
    

    public class FindBranchPageObjects
    {
        private IWebDriver Driver;

        public FindBranchPageObjects(IWebDriver driver)
        {
            Driver = driver;
        }
        private IWebElement inputFindBranchSearchTextBox => Driver.FindElement(By.Id("q"));
        
        private IWebElement btnSearch => Driver.FindElement(By.XPath("//button[@type='submit']"));

        private IList<IWebElement> ResultsList => Driver.FindElements(By.XPath("//ol[@class='ResultList']/li"));

        public void SearchForBranchName(string sBranchName)
        {
            inputFindBranchSearchTextBox.SendKeys(sBranchName);
            btnSearch.Click();
        }
        
        public void clickOnLastResult()
        {
            int count = ResultsList.Count;
            for (int i = 0; i < count; i++)
            {
                ((IJavaScriptExecutor) Driver).ExecuteScript("arguments[0].scrollIntoView(true);",
                    ResultsList[i]);
                if (i == count - 1)
                {
                    ((IJavaScriptExecutor) Driver).ExecuteScript("arguments[0].click();",
                        ResultsList[i]);
                    // Driver.FindElement(RelativeBy(By.TagName("a")).Below(ResultsList[i])).Click();
                    Driver.FindElement(By.XPath("//ol[@class='ResultList']/li[" + count +
                                                "]/descendant::a[@class='Teaser-ctaLink']")).Click();
                }
            }
            
            

          
        }
    }
}