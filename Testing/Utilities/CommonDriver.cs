using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Pages;

namespace Testing.Utilities
{
    internal class CommonDriver
    {
        public static IWebDriver driver;


        [OneTimeSetUp]

        public void LoginFunction()
        {
            // open chrome browser
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            // Login page object initialzation and definition

            Loginpage loginPageObj = new Loginpage();

            loginPageObj.Loginsteps(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }

    }
}   
