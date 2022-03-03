using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Testing.Pages;
using Testing.Utilities;

namespace Testing.pages
{[TestFixture]
    internal class TM_Test:CommonDriver

    {

         [SetUp]
        public void LoginFunction()
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            // Login page object initialzation and definition

            LoginPage loginPageObj = new LoginPage();

            loginPageObj.LoginSteps(driver);


            //Home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GoToHomepage(driver);
        }
        [Test]
        public void CreateTM_Test()
        {
            //TMpage object initialization and definition
            TMpage tmpageObj = new TMpage();
            tmpageObj.CreateTM(driver);
        }
        [Test]
        public void EditTM_Test()
        {
            // Edit TM
            TMpage tmpageObj = new TMpage();
            tmpageObj.EditTM(driver);
        }
        [Test]
        public void DeleteTM_Test()
        {
            // Delete TM
            TMpage tmpageObj = new TMpage();
            tmpageObj.DeleteTM(driver);

        }
        [TearDown]
        public void CloseTestRun()
        {

        }
         

    }
}
