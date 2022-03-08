using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecFlowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class LanguageSteps : Driver
    {
        Language addLanguageObj = new Language();
        [Given(@"Navigate to Language tab")]
        public void GivenNavigateToLanguageTab()
        {
        
        }
        
        [Given(@"Navigate to the Languages tab")]
        public void GivenNavigateToTheLanguagesTab()
        {
          
        }
        [Given(@"Click on Edit button near '(.*)' ")]
        public void GivenClickOnEditButtonNear(string Language)
        {

            addLanguageObj.EditLanguageButton(Language);
        }

        [When(@"I add '(.*)' and '(.*)' to Languages tab")]
        public void WhenIAddAndToLanguagesTab(string Language, string LanguageLevel)
        {
            addLanguageObj.AddLanguage(driver, Language, LanguageLevel);
        }
        
        [When(@"I update '(.*)' and '(.*)' in Languages tab")]
        public void WhenIUpdateAndInLanguagesTab(string Language1, string LanguageLevel1)
        {
            addLanguageObj.EditLanguage(Language1, LanguageLevel1);
        }
        
        [When(@"I delete a '(.*)' in Languages tab")]
        public void WhenIDeleteAInLanguagesTab(string Language1)
        {
            addLanguageObj.DeleteLanguage(Language1);
        }
        
        [Then(@"The '(.*)' should be created successfully\.")]
        public void ThenTheAndShouldBeCreatedSuccessfully_(string Language)
        {
            addLanguageObj.VerifyAddLanguage(Language);
        }
        
        [Then(@"The '(.*)' and '(.*)' should be updated successfully\.")]
        public void ThenTheAndShouldBeUpdatedSuccessfully_(string Language1, string LanguageLevel1)
        {
            addLanguageObj.VerifyLanguageUpdated(Language1, LanguageLevel1);
        }
        
        [Then(@"The '(.*)' should be deleted successfully")]
        public void ThenTheShouldBeDeletedSuccessfully(string Language1)
        {
            Language addLanguageObj = new Language();
            string record = addLanguageObj.VerifyDeletedLanguage(driver);
            Assert.That(record != Language1, "Language not deleted");
        }
    }
}
