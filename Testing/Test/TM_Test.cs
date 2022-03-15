using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using Testing.Pages;
using Testing.Utilities;

namespace Testing.pages
{
    [TestFixture]
    [Parallelizable]
    public class TM_Test: CommonDriver

    { 
        [Test, Order (1), Description ("check if user is able to create material report with valid data")]
         public void CreateTM_Test()
       
        {
        //Home page object initialization and definition
        Homepage homepageObj = new Homepage();
            homepageObj.GoToHomepage(driver);

        //TMpage object initialization and definition
        TMpage tmpageObj = new TMpage();
            tmpageObj.CreateTM(driver);
        }
         [Test, Order (2), Description("check if user is able to edit the material")]
        public void EditTM_Test()
        {
            //Home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GoToHomepage(driver);

            // Edit TM
            TMpage tmpageObj = new TMpage();
            tmpageObj.EditTM(driver, "ABC","XYZ","AWS");


        }
        // [Test, Order (3), Description("check if user is able to delete the existing material report")]
        //public void DeleteTM_Test()
        //{
        //    //Home page object initialization and definition
        //    Homepage homepageObj = new Homepage();
        //    homepageObj.GoToHomepage(driver);

        //    // Delete TM
        //    TMpage tmpageObj = new TMpage();
        //    tmpageObj.DeleteTM(driver);

        //}
       
         
         

    }
}
