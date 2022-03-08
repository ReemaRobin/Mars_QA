using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using MarsQA_1.SpecFlowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class EducationSteps : Driver
    {
        Education addEducationObj = new Education();
        [Given(@"Navigate to Education tab")]
        public void GivenNavigateToEducationTab()
        {
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);
        }
        
        [When(@"I add '(.*)' and '(.*)' and '(.*)' and '(.*)' and '(.*)' to Education tab")]
        public void WhenIAddAndAndAndAndToEducationTab(string Country, string University, string Title, string Degree, string Year)
        {
            addEducationObj.AddEducation(driver, Country, University, Title, Degree, Year);
        }
        
        [Then(@"The '(.*)' and '(.*)' and '(.*)' and '(.*)' and '(.*)' should be created successfully\.")]
        public void ThenTheAndAndAndAndShouldBeCreatedSuccessfully_(string Country, string University, string Title, string Degree, string Year)
        {
            string ActualCountry = addEducationObj.GetCountry(driver);
            string ActualUniversity = addEducationObj.GetUniversity(driver);
            string ActualTitle = addEducationObj.GetTitle(driver);
            string ActualDegree = addEducationObj.GetDegree(driver);
            string ActualYear = addEducationObj.GetYear(driver);
            Assert.That(ActualCountry == Country, "Actual country and Expected country match");
            Assert.That(ActualUniversity == University, "Actual name and Expected name match");
            Assert.That(ActualTitle == Title, "Actual title and Expected title match");
            Assert.That(ActualDegree == Degree, "Actual degree and Expected degree match");
            Assert.That(ActualYear == Year, "Actual year and Expected year match");

        }
    }
}
