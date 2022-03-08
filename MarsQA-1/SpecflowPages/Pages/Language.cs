using MarsQA_1.Helpers;
using MarsQA_1.SpecFlowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecFlowPages.Pages
{
    class Language
    {
        private static IWebElement Language_Tab => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[1]"));
        private static IWebElement AddLanguageButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement AddLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement Dropdown_Language => Driver.driver.FindElement(By.XPath(".//*[@name='level']"));
        private static IWebElement Add_Button => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
     
        private static IWebElement EditLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
      
        private static IWebElement EditedLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[1]"));
        private static IWebElement EditedLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[2]"));
       
        private static IWebElement UpdateLanguageButton => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));
        private static IWebElement DeletedRecord => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr"));

        public void AddLanguage(IWebDriver driver, string Language, string LanguageLevel)
        {
            Language_Tab.Click();
            Wait.ElementToBeClickable(driver, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 2);
            AddLanguageButton.Click();
            AddLanguageTextBox.SendKeys(Language);
            SelectElement element = new SelectElement(Dropdown_Language);
            element.SelectByValue(LanguageLevel);
            Add_Button.Click();


        }
        public void VerifyAddLanguage(string Language)
        {
            bool LanguageAdded = false;
            IWebElement tableElement = Driver.driver.FindElement(By.XPath("(//table[@class='ui fixed table'])[1]"));
            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tbody"));
            foreach (IWebElement row in tableRow)
            {
                if (row.Text.Contains(Language))
                {
                    LanguageAdded = true;
                    Console.WriteLine("Language Added");
                    break;
                }
            }
        }
        public void EditLanguageButton(string Language)
        {
            Language_Tab.Click();
            IWebElement EditButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Language + "']/following::td[2]/descendant::i[@class='outline write icon']"));
            EditButton.Click();
        }
        internal void EditLanguage(string Language1, string LanguageLevel1)
        {
            EditLanguageTextBox.Clear();
            EditLanguageTextBox.SendKeys(Language1);
            SelectElement element = new SelectElement(Dropdown_Language);
            element.SelectByValue(LanguageLevel1);
            UpdateLanguageButton.Click();

        }
        public void VerifyLanguageUpdated(string Language1, string LanguageLevel1)

        {
            Language_Tab.Click();
            IList<IWebElement> LangTableRow = Driver.driver.FindElements(By.XPath("(//table[@class='ui fixed table'])[1]/tbody/tr"));
            var rownum = LangTableRow.Count;
            for (var i = 1; i <= rownum; i++)
            {
                if ((Language1 == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[1])[" + i + "]")).Text) &&
                    (LanguageLevel1 == Driver.driver.FindElement(By.XPath("((//table[@class='ui fixed table'])[1]/tbody/tr[1]/td[2])[" + i + "]")).Text))
                    Console.WriteLine("Language level updated");
                break;
            }
        }
        internal void DeleteLanguage(string Language1)
        {
            Language_Tab.Click();
            IWebElement DeleteLanguageButton = Driver.driver.FindElement(By.XPath("//td[text()='" + Language1 + "']/following::td[2]/descendant::i[@class='remove icon']"));
            DeleteLanguageButton.Click();
        }
        public string VerifyDeletedLanguage(IWebDriver driver)
        {
            string deletedrecordtext = DeletedRecord.Text;
            return deletedrecordtext;
        }


    }
}