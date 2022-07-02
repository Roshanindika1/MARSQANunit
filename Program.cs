using OpenQA.Selenium.Chrome;
using System;
using SeleniumExtras.PageObjects;
using MARSQA2.Utilities;
using MARSQA2.Pages;
using NUnit.Framework;

namespace MARSQA2
{
    [TestFixture]
    internal class Program : Commondriver
    {
        
        [SetUp]
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

        [Test]
        public void CreateFunction()
        {
            var Shareskills = new Shareskills();
            PageFactory.InitElements(driver, Shareskills);
            Shareskills.ManageSkills();


            Shareskills ShareskillsObj = new Shareskills();
            PageFactory.InitElements(driver, ShareskillsObj);
            string newCategory = ShareskillsObj.GetCategory(driver);
            Assert.That(newCategory == "Programming & Tech", "Actual Category and Expected Category does not match");

        }

        [Test]  
        public void EditFunction()
        {
            var EditSkills = new EditSkills();
            PageFactory.InitElements(driver, EditSkills);
            EditSkills.EditSkillfunction();


            EditSkills EditSkillsObj = new EditSkills();
            PageFactory.InitElements(driver, EditSkillsObj);
            string newactualTitle = EditSkillsObj.GetEditedSkill(driver);
            Assert.That(newactualTitle == "Test Analyst", "Actual Title and Expected Title does not match");

            string newSkillExchange = EditSkillsObj.GetEditedSkillExchange(driver);
            Assert.That(newSkillExchange == "Database", "Actual SkillExchange and Expected SkillExchange does not match");

        }

        [Test]
        public void DeleteFunction()
        {
            var DeleteSkills = new DeleteSkills();
            PageFactory.InitElements(driver, DeleteSkills);
            DeleteSkills.DeleteSkillsFunction();

        }

        [TearDown]
        public void Closedown()
        {
            //driver.Close();
        }
    }
}
