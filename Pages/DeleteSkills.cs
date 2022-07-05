using MARSQA2.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARSQA2.Pages
{
    internal class DeleteSkills : Commondriver
    {
        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > a:nth-child(3)")]
        public IWebElement manageListings { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(3) > i")]
        public IWebElement  deleteBtn { get; set; }

        public void DeleteSkillsFunction()
        {
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > a:nth-child(3)", 2);
            manageListings.Click();
                            
            Wait.WaitForvisible(driver, "CssSelector", "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(8) > div > button:nth-child(3) > i", 2);
            deleteBtn.Click();

            IWebElement deleteWindowbtn = driver.FindElement(By.CssSelector("body > div.ui.page.modals.dimmer.transition.visible.active > div > div.actions > button.ui.icon.positive.right.labeled.button"));
            Wait.WaitForvisible(driver, "CssSelector", "body > div.ui.page.modals.dimmer.transition.visible.active > div > div.actions > button.ui.icon.positive.right.labeled.button", 2);
            deleteWindowbtn.Click();

        }
    }
}
