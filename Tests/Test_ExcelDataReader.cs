


using OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.PageObjects;
using MARSQA2.Utilities;
using MARSQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace MARSQA2
{
    [TestFixture]
    internal class Test_ExcelDataReader : Commondriver
    {
        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;

        [OneTimeSetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            var Homepage = new Homepage();
            PageFactory.InitElements(driver, Homepage);
            Homepage.signInButton.Click();

            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();

        }

        [Test, Order(1)]
        public void WriteExcelFunction()
        {
            //Write data into the excel file and assert that

            var ShareSkillExcel = new ShareSkillExcel();
            PageFactory.InitElements(driver, ShareSkillExcel);
            ShareSkillExcel.createSkillExcel();


            ShareSkillExcel ShareSkillExcelObj = new ShareSkillExcel();
            PageFactory.InitElements(driver, ShareSkillExcelObj);
            string newCategory = ShareSkillExcelObj.GetCategoryExcel(driver);
            Assert.That(newCategory == "Programar", "Actual Title and Expected Title does not match");
           
        }

        [Test, Order(2)]
        public void ReadExcelFunction()
        {
            // Read data from the excel file and feed it to the MARS website

            var ReadSkillsExcel = new ReadSkillsExcel();
            PageFactory.InitElements(driver, ReadSkillsExcel);
            ReadSkillsExcel.manageSkillExcel();
                      
        }


        [Test, Order(3)]
        public void EditExcelFunction()
        {
            var EditSkillExcel = new EditSkillExcel();
            PageFactory.InitElements(driver, EditSkillExcel);
            EditSkillExcel.EditExcel();
          
        }

        /*
        [Test, Order(4)]
        public void DeleteFunction()
        {
            var DeleteSkills = new DeleteSkills();
            PageFactory.InitElements(driver, DeleteSkills);
            DeleteSkills.DeleteSkillsFunction();
            
        }*/

        [OneTimeTearDown]
        public void Closedown()
        {
            driver.Close();
        }
    }
}


















/*ing OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.PageObjects;
using MARSQA2.Utilities;
using MARSQA2.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OfficeOpenXml;
using System.IO;
using System.Threading;
using excel = Microsoft.Office.Interop.Excel;

namespace MARSQA2.Tests
{
    
    [TestFixture]

    internal class Test_ExcelDataReader : Commondriver
    {

        //Creates a new instance of Excel
        excel.Application xlApp = new excel.Application();

        //Opens demo.xlsx
        excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\Temp\demo.xlsx");
        //Selects the first Sheet
        excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        //Finds the range of cells used in the sheet
        excel.Range xlRange = xlWorksheet.UsedRange;



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

        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
        [OneTimeSetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

            var Homepage = new Homepage();
            PageFactory.InitElements(driver, Homepage);
            Homepage.signInButton.Click();

            var Loginpage = new Loginpage();
            PageFactory.InitElements(driver, Loginpage);
            Loginpage.Loginsteps();
            Thread.Sleep(1000);
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > div.right.item > a", 4);
            shareSkillbutton.Click();
        }

        [Test, Order(1)]

        
        
            [DynamicData(nameof(ManageSkillsExcel), DynamicDataSourceType.Method)]
            [TestMethod]
            public static IEnumerable<object[]> ManageSkillsExcel()
            {

                //Create Worksheet object

                using (ExcelPackage package = new ExcelPackage(new FileInfo("MARS Project.xlsx")))
                {
                    ExcelWorksheet workSheet = package.Workbook.Worksheets["Sheet1"];

                    int rowCount = workSheet.Dimension.End.Row;

                    for (int i = 2; i <= rowCount; i++)
                    {
                        yield return new object[]
                        {
                        workSheet.Cells[i,1].Value?.ToString().Trim(),// Title
                        workSheet.Cells[i, 2].Value?.ToString().Trim(),// Description
                        workSheet.Cells[i, 3].Value?.ToString().Trim(),// Category
                        workSheet.Cells[i,4].Value?.ToString().Trim()// Sub Category

                        };
                    }
                }
            }

            public void DatadrivenManageSkillsExcell(string title, string decs, string cat, string subCat)
            {

                titleBox.SendKeys(title);
                descriptionBox.SendKeys(decs);

                categoryDropdownbox.Click();
                Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(1) > select > option:nth-child(7)", 2);
                categoryOption.SendKeys(cat);

                subCategorybox.Click();
                Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(5)", 2);
                subCategoryOption.SendKeys(subCat);

            }


        } 
}
*/