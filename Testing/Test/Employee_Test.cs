using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Pages;
using Testing.Utilities;

namespace Testing.Test
{
    [TestFixture]
    [Parallelizable]
    internal class Employee_Test: CommonDriver
    {

         [Test, Order(1), Description("check if user is able to create Employee page with valid data")]
        public void CreateEmployee_Test()
        {
            //Home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GoToEmployeeHomepage(driver);

            //TMpage object in itialization and definition
            EmployeePage EmployeePageObj = new EmployeePage();
            EmployeePageObj.CreateEmployee(driver);
        }
        [Test, Order(2), Description("check if user is able to edit the Employee ")]
        public void EditEmployee_Test()
        {

            //Home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GoToEmployeeHomepage(driver);

            // Edit TM
            EmployeePage EmployeePageObj = new EmployeePage();
            EmployeePageObj.EditEmployee(driver);
        }
        [Test, Order(3), Description("check if user is able to delete the existing Employee")]
        public void DeleteEmployee_Test()
        {

            //Home page object initialization and definition
            Homepage homepageObj = new Homepage();
            homepageObj.GoToEmployeeHomepage(driver);

            // Delete TM
            EmployeePage tmpageObj = new EmployeePage();
            tmpageObj.DeleteEmployee(driver);

        }

        



    }
}
