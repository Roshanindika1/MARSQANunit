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
using AutoItX3Lib;
using OfficeOpenXml;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MARSQA2.Pages
{/*
    internal class ShareSkillExcel : Commondriver
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


        [DynamicData(nameof(ManageSkillsExcel), DynamicDataSourceType.Method)]
        [TestMethod]

        public void DatadrivenManageSkillsExcell(string title, string decs, string cat, string subCat)
        {
            Wait.WaitForclicable(driver, "CssSelector", "#account-profile-section > div > section.nav-secondary > div > div.right.item > a", 2);
            shareSkillbutton.Click();

            titleBox.SendKeys(title);
            descriptionBox.SendKeys(decs);

            categoryDropdownbox.Click();
            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(1) > select > option:nth-child(7)", 2);
            categoryOption.SendKeys(cat);

            subCategorybox.Click();
            Wait.WaitForclicable(driver, "CssSelector", "#service-listing-section > div.ui.container > div > form > div:nth-child(3) > div.twelve.wide.column > div > div:nth-child(2) > div:nth-child(1) > select > option:nth-child(5)", 2);
            subCategoryOption.SendKeys(subCat);


        }


        public static IEnumerable<Object[]> ManageSkillsExcel()
        {

            //Create Worksheet object

            using (ExcelPackage package = new ExcelPackage(new FileInfo("MARS Project.xlsx")))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets["Sheet1"];

                int rowCount = workSheet.Dimension.End.Row;

                for (int i = 2; i <= rowCount; i++)
                {
                    yield return new Object[]
                    {
                        workSheet.Cells[i,1].Value?.ToString().Trim(),// Title
                        workSheet.Cells[i, 2].Value?.ToString().Trim(),// Description
                        workSheet.Cells[i, 3].Value?.ToString().Trim(),// Category
                        workSheet.Cells[i,4].Value?.ToString().Trim()// Sub Category

                    };
                }
            }

        }





        /*

            [FindsBy(How = How.CssSelector, Using = "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(2)")]
            public IWebElement actualCategory { get; set; }

            public string GetCategoryExcel(IWebDriver driver)
            {
                Wait.WaitForvisible(driver, "CssSelector", "#listing-management-section > div:nth-child(3) > div:nth-child(2) > div:nth-child(1) > table > tbody > tr:nth-child(1) > td:nth-child(2)", 2);
                return actualCategory.Text;
            }
        
    }*/
}
