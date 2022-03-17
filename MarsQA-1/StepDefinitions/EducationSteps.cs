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
       
        [Given(@"Navigate to Education tab")]
        public void GivenNavigateToEducationTab()
        {
            Homepage homePage = new Homepage();
            homePage.GoToProfile(driver);
        }
        
        [When(@"I add '(.*)' and '(.*)' and '(.*)' and '(.*)' and '(.*)' to Education tab")]
        public void WhenIAddAndAndAndAndToEducationTab(string Country, string University, string Title, string Degree, string Year)
        {
            Education addEducationObj = new Education();
            addEducationObj.AddEducation(driver, Country, University, Title, Degree, Year);
        }
        
        [Then(@"The '(.*)' and '(.*)' and '(.*)' and '(.*)' and '(.*)' should be created successfully\.")]
        public void ThenTheAndAndAndAndShouldBeCreatedSuccessfully_(string Country, string University, string Title, string Degree, int Year)
        {
            Education addEducationObj = new Education();
            addEducationObj.VerifyEducationAdded(Degree);

        }
    }
}
