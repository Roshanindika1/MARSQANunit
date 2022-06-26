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

        }
        
        [Test]
        public void DeleteFunction()
        {

        }

        [TearDown]
        public void Closedown()
        {

        }
    }
}
