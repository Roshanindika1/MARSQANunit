using MARSQA2.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OfficeOpenXml;
using System.IO;
using DataTable = System.Data.DataTable;
using OfficeOpenXml.Style;

namespace MARSQA2.Pages
{
    public class ShareSkillExcel : Commondriver
    {
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


        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        public void createSkillExcel()
        {
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > div.right.item > a", 2);
            shareSkillbutton.Click();
            excelwrite();
        }

        public void excelwrite()
        {
            string filename = "MARS Project.xlsx";
            ExcelPackage ExcelPkg = new ExcelPackage();
            ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");

            string filePath = Directory.GetParent(@"../../../").FullName
                + Path.DirectorySeparatorChar + "DataReader"
                + Path.DirectorySeparatorChar + filename;


            // setting the properties of the work sheet

            wsSheet1.TabColor = System.Drawing.Color.Black;
            wsSheet1.DefaultRowHeight = 12;

            // Setting the properties
            // of the first row
            wsSheet1.Row(1).Height = 20;
            wsSheet1.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            wsSheet1.Row(1).Style.Font.Bold = true;

            // Header of the Excel sheet
            wsSheet1.Cells[1, 1].Value = "Title";
            wsSheet1.Cells[1, 2].Value = "Description";
            wsSheet1.Cells[1, 3].Value = "Category";
            wsSheet1.Cells[1, 4].Value = "Sub Category";
            wsSheet1.Cells[1, 5].Value = "Tags";
            wsSheet1.Cells[1, 6].Value = "Skill Exchangev Tags";


            //Write the MARS program
            titleBox.SendKeys("Programar");
            descriptionBox.SendKeys("I can analyze your system and can give you the best IT solution");
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
            jse.ExecuteScript("window.scrollBy(0,500)");
            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(8) > div:nth-child(4) > div > div > div > div > div > input", 2);
            skillExchangeTag.Click();
            skillExchangeTag.SendKeys("Designing");
            skillExchangeTag.SendKeys(Keys.Enter);
            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div.ui.vertically.padded.right.aligned.grid > div > input.ui.teal.button", 2);
            saveButton.Click();



            // Inserting the article data into excel

            // First row have values as header so data will start with second row

            int recordIndex = 2;


            wsSheet1.Cells[recordIndex, 1].Value = "Programar";
            wsSheet1.Cells[recordIndex, 2].Value = "I can analyze your system and can give you the best IT solution";
            wsSheet1.Cells[recordIndex, 3].Value = "Programming & Tech";
            wsSheet1.Cells[recordIndex, 4].Value = "QA";
            wsSheet1.Cells[recordIndex, 5].Value = "C#";
            wsSheet1.Cells[recordIndex, 6].Value = "Designing";

            wsSheet1.Column(1).AutoFit();
            wsSheet1.Column(2).AutoFit();
            wsSheet1.Column(3).AutoFit();
            wsSheet1.Column(4).AutoFit();
            wsSheet1.Column(5).AutoFit();
            wsSheet1.Column(6).AutoFit();

            wsSheet1.Protection.IsProtected = false;
            wsSheet1.Protection.AllowSelectLockedCells = false;
            ExcelPkg.SaveAs(filePath);

        }

        public string GetCategoryExcel(IWebDriver driver)
        {
            DataReaderExcel reader = new DataReaderExcel();
            DataTable dt = reader.readData();

            return dt.Rows[0][0].ToString();
            
        }
        
    }
}