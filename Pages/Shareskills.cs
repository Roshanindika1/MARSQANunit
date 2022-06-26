using MARSQA2.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MARSQA2.Pages
{
    internal class Shareskills : Commondriver
    {

        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > div.right.item > a")]
        public IWebElement shareSkillbutton { get; set; }

        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement titleBox { get; set; }

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement descriptionBox { get; set; }

        [FindsBy(How=How.Name, Using = "categoryId")]
        public IWebElement categoryDropdownbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(1) > select > option:nth-child(7)")]
        public IWebElement categoryOption { get; set; }

        [FindsBy(How=How.Name, Using = "subcategoryId")]
        public IWebElement subCategorybox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(5)")]
        public IWebElement subCategoryOption { get; set; }

        [FindsBy(How=How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input")]
        public IWebElement tagsBox { get; set; }

        //[FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(5) > div.twelve.wide.column > div.inline.fields > div:nth-child(1) > div > input[type=radio]")]
        //[FindsBy(How =How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(5) > div.twelve.wide.column > div.inline.fields > div:nth-child(2) > div > input[type=radio]")]
        [FindsBy(How =How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        public IWebElement serviceTypeRadioBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(6) > div.twelve.wide.column > div > div:nth-child(2) > div > input[type=radio]")]
        public IWebElement locationTypeRadioBtn { get; set; }

        //Date selection block starts

        [FindsBy(How = How.Name, Using = "startDate")]
        public IWebElement startDateBox { get; set; }

        [FindsBy(How = How.Name, Using = "endDate")]
        public IWebElement endDateBox { get; set; } 

        [FindsBy(How =How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(2) > input[type=time]")]
        public IWebElement sundayStarttime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(3) > input[type=time]")]
        public IWebElement sundayEndtime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div:nth-child(2) > input[type=time]")]
        public IWebElement mondayStarttime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div:nth-child(3) > input[type=time]")]
        public IWebElement mondayEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[2]/input")]
        public IWebElement tuesdayStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[4]/div[3]/input")]
        public IWebElement tuesdayEndtime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div:nth-child(2) > input[type=time]")]
        public IWebElement wednesdayStarttime { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div:nth-child(3) > input[type=time]")]
        public IWebElement wednesdayEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[2]/input")]
        public IWebElement thursdayStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[6]/div[3]/input")]
        public IWebElement thursdayEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[2]/input")]
        public IWebElement fridayStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[7]/div[3]/input")]
        public IWebElement fridayEndtime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[2]/input")]
        public IWebElement saturdayStarttime { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='service - listing - section']/div[2]/div/form/div[7]/div[2]/div/div[8]/div[3]/input")]
        public IWebElement saturdayEndtime { get; set; }

        
        
        //Date selection block ends


        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(2) > div > div:nth-child(1) > div > input[type=radio]")]
        public IWebElement skillTradeRadioBtn { get; set; }

        [FindsBy(How =How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input")]
        public IWebElement skillExchangeTag { get; set; }

        [FindsBy(How =How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/input")]
        public IWebElement creditInputbox { get; set; }

        [FindsBy(How =How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(10) > div.twelve.wide.column > div > div:nth-child(1) > div > input[type=radio]")]
        public IWebElement activeRadioBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div.ui.vertically.padded.right.aligned.grid > div > input.ui.teal.button")]
        public IWebElement saveButton { get; set; }


        public void ManageSkills()
        {

            Wait.WaitForclicable(driver,"CssSelector", "#account-profile-section > div > section.nav-secondary > div > div.right.item > a", 2);
            shareSkillbutton.Click();

            titleBox.SendKeys("Programar");
            descriptionBox.SendKeys("I can analyze your system and can give you the best IT solution");

            categoryDropdownbox.Click();
            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(1) > select > option:nth-child(7)", 2);
            categoryOption.Click();
            
            subCategorybox.Click();
            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(5)", 2);
            subCategoryOption.Click();

            jse.ExecuteScript("window.scrollBy(0,500)");
            
            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input", 2);
            tagsBox.Click();

            tagsBox.SendKeys("C#");
            tagsBox.SendKeys(Keys.Enter);

            tagsBox.SendKeys("VB");
            tagsBox.SendKeys(Keys.Enter);

            tagsBox.SendKeys("Java");
            tagsBox.SendKeys(Keys.Enter);

            //Radio buttons Xpaths are not accessible 

            //  Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(5) > div.twelve.wide.column > div.inline.fields > div:nth-child(1) > div > input[type=radio]", 2);
            //Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(5) > div.twelve.wide.column > div.inline.fields > div:nth-child(2) > div > input[type=radio]", 2);
            //Wait.WaitForclicable(driver, "XPath", "//*[@id='service - listing - section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input", 2);
            //serviceTypeRadioBtn.Click();

            // Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(6) > div.twelve.wide.column > div > div:nth-child(2) > div > input[type=radio]", 2);
            //locationTypeRadioBtn.Click();

            
            //Enter dates and times

            jse.ExecuteScript("window.scrollBy(0,500)");
            startDateBox.SendKeys("05/07/2022");
            endDateBox.SendKeys("25/07/2022");

            Wait.WaitForvisible(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(2) > input[type=time]", 2);
            sundayStarttime.SendKeys("09:00am");
            Wait.WaitForvisible(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(3) > input[type=time]", 2);
            sundayEndtime.SendKeys("15:00pm");

            Wait.WaitForvisible(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div:nth-child(2) > input[type=time]", 2);
            mondayStarttime.SendKeys("10:00am");
            Wait.WaitForvisible(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(3) > div:nth-child(3) > input[type=time]", 2);
            mondayEndtime.SendKeys("16:00pm");

            Wait.WaitForvisible(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div:nth-child(2) > input[type=time]", 2);
            wednesdayStarttime.SendKeys("07:00am");
            Wait.WaitForvisible(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(7) > div.twelve.wide.column > div > div:nth-child(5) > div:nth-child(3) > input[type=time]", 2);
            wednesdayEndtime.SendKeys("13:30pm");

            jse.ExecuteScript("window.scrollBy(0,800)");

           /* Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(2) > div > div:nth-child(1) > div > input[type=radio]", 2);
            skillTradeRadioBtn.Click();
           */
            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input", 2);
            skillExchangeTag.Click();

            skillExchangeTag.SendKeys("Designing");
            skillExchangeTag.SendKeys(Keys.Enter);
            skillExchangeTag.SendKeys("Advertising");
            skillExchangeTag.SendKeys(Keys.Enter);
            skillExchangeTag.SendKeys("Costing");
            skillExchangeTag.SendKeys(Keys.Enter);

           /* Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(10) > div.twelve.wide.column > div > div:nth-child(1) > div > input[type=radio]", 2);
            activeRadioBtn.Click();*/

            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div.ui.vertically.padded.right.aligned.grid > div > input.ui.teal.button", 2);
            saveButton.Click();

        }
        
        
        [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(2)")]
        public IWebElement actualCategory { get; set; }

        public string GetCategory(IWebDriver driver)
        {
            Wait.WaitForvisible(driver, "CssSelector", "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(2)", 2);
            return actualCategory.Text;
        }

    }
}
