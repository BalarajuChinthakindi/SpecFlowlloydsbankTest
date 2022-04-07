using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowTest.Pages;
using TechTalk.SpecFlow.Assist;

namespace SpecflowTest.Steps
{
    using TechTalk.SpecFlow;

    [Binding]
    public class FindBranchDetailsSteps

    {
        
        public static IWebDriver Driver = BaseStep.Driver;
    private readonly ScenarioContext _scenarioContext;
    private HomePageObjects HomePageObjects = new HomePageObjects(Driver);
    private FindBranchPageObjects FindBranchPageObjects = new FindBranchPageObjects(Driver);
    private BranchDetailsPageObjects BranchDetailsPageObjects = new BranchDetailsPageObjects(Driver);

    public FindBranchDetailsSteps(ScenarioContext scenarioContext)
    {
        _scenarioContext = scenarioContext;
    }

    [Given(@"you are on the personal banking home page")]
    public void GivenYouAreOnThePersonalBankingHomePage()
    {
        Console.WriteLine("In step1");
        Assert.That(Driver.Title.Equals(@"Lloyds Bank - Personal Banking, Personal Finances & Bank Accounts"));
    }

    [When(@"you click on branch finder link")]
    public void WhenYouClickOnBranchFinderLink()
    {
        Console.WriteLine("In step2");
        HomePageObjects.ClickOnBranchDetailsLink();
    }

    [When(@"search with the word '(.*)'")]
    public void WhenSearchWithTheWord(string branchName)
    {
        Console.WriteLine("In step3");
        FindBranchPageObjects.SearchForBranchName(branchName);
    }

    [Then(@"select the last displayed branch from the results")]
    public void ThenSelectTheLastDisplayedBranchFromTheResults()
    {
        Console.WriteLine("In step4");
        FindBranchPageObjects.clickOnLastResult();
    }

    [Then(@"verify below branch details are displayed successfully")]
    public void ThenVerifyBelowBranchDetailsAreDisplayedSuccessfully(Table table)
    {
        dynamic branchDetails = table.CreateDynamicInstance();
        Assert.Multiple(() =>
        {
            Assert.AreEqual(branchDetails.Location, BranchDetailsPageObjects.getLocationName() );
            Assert.AreEqual(branchDetails.Street, BranchDetailsPageObjects.getStreetName() );
            Assert.AreEqual(branchDetails.City, BranchDetailsPageObjects.getCityName() );
            Assert.AreEqual(branchDetails.Postcode, BranchDetailsPageObjects.getPostcode() );
            Assert.AreEqual(branchDetails.SaturdayHrs, BranchDetailsPageObjects.getSaturdayHrs() );
            Assert.AreEqual(branchDetails.SundayHrs, BranchDetailsPageObjects.getSundayHrs() );
        });
    } 
    }
}