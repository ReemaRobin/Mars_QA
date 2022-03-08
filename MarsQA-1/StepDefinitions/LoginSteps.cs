using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I logged in to the skillswap website using my '(.*)' and '(.*)' successfully")]
        public void GivenILoggedInToTheSkillswapWebsiteUsingMyAndSuccessfully(string Email, string Password)
        {
            Driver.NavigateUrl();

            //Enter Url
            Driver.driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys(Email);

            //Enter password
            Driver.driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys(Password);

            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']")).Click();
        }
    }
}
