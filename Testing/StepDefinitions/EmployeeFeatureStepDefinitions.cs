using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Testing.Pages;
using Testing.Utilities;

namespace Testing.StepDefinitions
{
    [Binding]
    public class EmployeeFeatureStepDefinitions: CommonDriver

    {
        Loginpage loginpageObj = new Loginpage();
        Homepage homepageObj = new Homepage();
        EmployeePage employeeObj = new EmployeePage();

        [Given(@"I have successfully login to the TurnUp portal with valid credentials")]
        public void GivenIHaveSuccessfullyLoginToTheTurnUpPortalWithValidCredentials()
        {
            driver = new ChromeDriver();

            
            loginpageObj.Loginsteps(driver);
            
        }

        [Given(@"I navigated to the Employee home page")]
        public void GivenINavigatedToTheEmployeeHomePage()
        {
            
            homepageObj.GoToEmployeeHomepage(driver);
        }

        [When(@"I was creating new Emplyee record with vallid data")]
        public void WhenIWasCreatingNewEmplyeeRecordWithVallidData()
        {
            
            employeeObj.CreateEmployee(driver);
        }

        [Then(@"I could create it successfully")]
        public void ThenICouldCreateItSuccessfully()
        {

            string newemployeename = employeeObj.GetEmployeeName(driver);
            string newemployeeusername = employeeObj.GetEmployeeUserName(driver);

            Assert.That(newemployeename == "RRR", "actual name do not match the record");
            Assert.That(newemployeeusername == "TESTER2", "actual username do not match the record");

                
        }

        [When(@"I updated the '([^']*)' on Employees page")]
        public void WhenIUpdatedTheOnEmployeesPage(string b1)
        {
            employeeObj.EditEmployee(driver, b1);
        }

        [Then(@"I could edit the '([^']*)' employee record")]
        public void ThenICouldEditTheEmployeeRecord(string b1)
        {

            string editemployeename = employeeObj.EditName(driver);

            Assert.That(editemployeename == b1);

        }





    }

}
