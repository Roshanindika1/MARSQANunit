using MARSQA2.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using DataTable = System.Data.DataTable;

namespace MARSQA2.Pages
{
    public class ReadSkillsExcel : Commondriver
    {

        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        [FindsBy(How = How.CssSelector, Using = "#account-profile-section > div > section.nav-secondary > div > div.right.item > a")]
        public IWebElement shareSkillbutton { get; set; }

        [FindsBy(How = How.Name, Using = "title")]
        public IWebElement titleBox { get; set; }

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement descriptionBox { get; set; }

        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement categoryDropdownbox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(1) > select > option:nth-child(7)")]
        public IWebElement categoryOption { get; set; }

        [FindsBy(How = How.Name, Using = "subcategoryId")]
        public IWebElement subCategorybox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(5)")]
        public IWebElement subCategoryOption { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input")]
        public IWebElement tagsBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div.ui.vertically.padded.right.aligned.grid > div > input.ui.teal.button")]
        public IWebElement saveButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input")]
        public IWebElement skillExchangeTag { get; set; }

        public void manageSkillExcel()
        {
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > div.right.item > a", 2);
            shareSkillbutton.Click();
            readDatafromExcel();
        }


        public void readDatafromExcel()
        {

            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();

            titleBox.SendKeys(dt.Rows[0][0].ToString());
            descriptionBox.SendKeys(dt.Rows[0][1].ToString());
            categoryDropdownbox.SendKeys(dt.Rows[0][2].ToString());
            subCategorybox.SendKeys(dt.Rows[0][3].ToString());

            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(4) > div.twelve.wide.column > div > div > div > div > input", 2);
            tagsBox.Click();
            tagsBox.SendKeys(dt.Rows[0][4].ToString());
            tagsBox.SendKeys(Keys.Enter);


            jse.ExecuteScript("window.scrollBy(0,1500)");

            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input", 2);
            skillExchangeTag.Click();

            skillExchangeTag.SendKeys(dt.Rows[0][5].ToString());
            skillExchangeTag.SendKeys(Keys.Enter);

            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div.ui.vertically.padded.right.aligned.grid > div > input.ui.teal.button", 2);
            saveButton.Click();
        }
    }
}