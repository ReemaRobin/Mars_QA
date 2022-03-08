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
    public class SkillsSteps : Driver
    {
        Skills addSkillObj = new Skills();
        [Given(@"Navigate to Skills tab")]
        public void GivenNavigateToSkillsTab()
        {
            
        }

        [Given(@"Navigate to the Skills tab")]
        public void GivenNavigateToTheSkillsTab()
        {

        }
            
        [Given(@"Navigate to the Skills tab\.")]
        public void GivenNavigateToTheSkillsTab_()
        {
            
        }
        
        [When(@"I add '(.*)' and '(.*)' to Skills tab")]
        public void WhenIAddAndToSkillsTab(string Skill, string SkillLevel)
        {
            addSkillObj.AddSkills(driver, Skill, SkillLevel);
        }
        
        [When(@"I update '(.*)' and '(.*)' to Skills tab")]
        public void WhenIUpdateAndToSkillsTab(string Skill1, string SkillLevel1)
        {
            addSkillObj.EditSkills(driver, Skill1, SkillLevel1);
        }
        
        [When(@"I delete a skill in Skills tab")]
        public void WhenIDeleteASkillInSkillsTab()
        {
            addSkillObj.DeleteSkill(driver);
        }
        
        [Then(@"The '(.*)' and '(.*)' should be created successfully")]
        public void ThenTheAndShouldBeCreatedSuccessfully(string Skill, string SkillLevel)
        {
            string ActualSkill = addSkillObj.GetSkill(driver);
            string ActualSkillLevel = addSkillObj.GetSkillLevel(driver);
            Assert.That(ActualSkill != Skill, "Actual Skill and Expected Skill do not match");
            Assert.That(ActualSkillLevel != SkillLevel, "Actual SkillLevel and Expected SkillLevel do not match");
        }
        
        [Then(@"The '(.*)' and '(.*)' should be updated successfully")]
        public void ThenTheAndShouldBeUpdatedSuccessfully(string Skill1, string SkillLevel1)
        {
            string EditedSkill = addSkillObj.GeteditedSkill(driver);
            string EditedSkillLevel = addSkillObj.GeteditedSkillLevel(driver);
            Assert.That(EditedSkill != Skill1, "Actual Skill and Expected Skill not match");
            Assert.That(EditedSkillLevel != SkillLevel1, "Actual SkillLevel and Expected SkillLevel not match ");
        }
        
        [Then(@"The skill should be deleted successfully")]
        public void ThenTheSkillShouldBeDeletedSuccessfully()
        {
            string DeletedSkill = addSkillObj.GetDeletedSkill(driver);
            string DeletedSkillLevel = addSkillObj.GetDeletedSkillLevel(driver);
            Assert.That(DeletedSkill == "Automation", "Skill deleted");
            Assert.That(DeletedSkillLevel == "Intermediate", "SkillLevel deleted");

        }
    }
}
