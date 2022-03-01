using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Testing.Pages;

namespace Testing.pages
{
    internal class TM_Test
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            //Login page oblect initialization and definition
            Loginpage loginpageObj = new Loginpage();
            loginpageObj.Loginsteps(driver);

            //Home page oblect initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GoToHomepage(driver);

            //TMpage oblect initialization and definition
            TMpage tmpageObj = new TMpage();    
            tmpageObj.CreateTM(driver);

            //Edit TM oblect initialization and definition
           
            tmpageObj.EditTM(driver);

            //Delete TM oblect initialization and definition

            tmpageObj.DeleteTM(driver);




























        }
    }
}
