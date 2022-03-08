using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Testing.Utilities;

namespace Testing.Pages
{
    internal class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        {

            // clicking on Create to create new employee
            IWebElement CreateEmployeebutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateEmployeebutton.Click();

            //click on Name text box and input data
            IWebElement NameTextbox = driver.FindElement(By.Id("Name"));
            NameTextbox.Click();
            NameTextbox.SendKeys("RRR");

            // click on Username Text box and input data

            IWebElement UsernameTextbox = driver.FindElement(By.Id("Username"));
            UsernameTextbox.Click();
            UsernameTextbox.SendKeys("TESTER2");

            // Click on Contact Box and provide number

            IWebElement ContactBox = driver.FindElement(By.Id("ContactDisplay"));
            ContactBox.Click();
            ContactBox.SendKeys("123456789");

            //click on Password Text box and provide password

            IWebElement PasswordTextbox = driver.FindElement(By.Id("Password"));
            PasswordTextbox.Click();
            PasswordTextbox.SendKeys("Tester@12345");

            // click on retype password text box and retype the password

            IWebElement RetypePassword = driver.FindElement(By.Id("RetypePassword"));
            RetypePassword.Click();
            RetypePassword.SendKeys("Tester@12345");

            //click on Vehicle textbox and provide data
            IWebElement Vehicle = driver.FindElement(By.XPath("//*[@id='UserEditForm']/div/div[7]/div/span[1]/span/input"));
            Vehicle.Click();
            Vehicle.SendKeys("Bus");

            // click on Groups text box and provide text

            //IWebElement Groups = driver.FindElement(By.XPath("//*[@id='groupList_listbox']/li[11]"));
            //Groups.Click();



            //click on save button

            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
           
            Savebutton.Click();

            Thread.Sleep(3000);

            // click on back to list icon

           IWebElement Backtolist = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            Backtolist.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='usersGrid']/div[4]/a[4]/span", 20);

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='usersGrid']/div[3]/table/tbody/tr[1]/td[1]", 20);

            // click on go to last page button

           IWebElement Gotolastpagetab = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));

             Gotolastpagetab.Click();

            Thread.Sleep(2000);

            // check if the created record is present in the table with the expected value

            IWebElement ActualName = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement ActualUsername = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[2]"));


            Assert.That(ActualName.Text == "RRR", "actual name do not match the record");
            Assert.That(ActualUsername.Text == "TESTER2", "actual username do not match the record");




        }


        public void EditEmployee(IWebDriver driver)

        {
            // wait till the entire employee page visible

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='usersGrid']/div[3]/table/tbody/tr[1]/td[1]", 20);


            //GO to the laste page
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();

            Thread.Sleep(2000);

            // Find the creted employee record

            IWebElement CreatedEmployeerecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (CreatedEmployeerecord.Text == "RRR")
            {
                IWebElement SelectEdit = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
                SelectEdit.Click();

            }
            else
            {
                Assert.That(CreatedEmployeerecord.Text == "Test failed");
            }

            //identify the name textbox and edit the name

            IWebElement EditName = driver.FindElement(By.Id("Name"));
            EditName.Clear();
            EditName.SendKeys("XXX");

            // identify the username Textbox and edit the username

            IWebElement EditUsername = driver.FindElement(By.Id("Username"));
            EditUsername.Clear();
            EditUsername.SendKeys("EditTester1");

            //identify the contact textbox and edit the contact

            IWebElement EditContact = driver.FindElement(By.Id("ContactDisplay"));
            EditContact.Clear();
            EditContact.SendKeys("111111111");

            //Identify the Password Textbox

            IWebElement Editpassword = driver.FindElement(By.Id("Password"));
            Editpassword.Clear();
            Editpassword.SendKeys("Password@222");

            //Identify the Retype password

            IWebElement Editretypepassword = driver.FindElement(By.Id("RetypePassword"));
            Editretypepassword.Clear();
            Editretypepassword.SendKeys("Password@222");

            // click on save button

            IWebElement Clickonsave = driver.FindElement(By.Id("SaveButton"));
            Clickonsave.Click();

            //Identify the back list

            IWebElement Backlist1 = driver.FindElement(By.XPath("//*[@id='container']/div/a"));
            Backlist1.Click();

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='usersGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // go to last page

            IWebElement Gotolastpage1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            Gotolastpage1.Click();
            Thread.Sleep(2000);

            // check if the Employee record is edited or not

            IWebElement EditName1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(EditName1.Text == "XXX", "actual name do not match the record");
           



        }

        public void DeleteEmployee(IWebDriver driver)
        {
            // Delete the created Employee record

            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='usersGrid']/div[3]/table/tbody/tr[1]/td[1]", 20);

            //GO to the laste page

            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            gotolastpage.Click();

            Thread.Sleep(2000);
            // Find the creted employee record

            IWebElement CreatedEmployeerecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

             if (CreatedEmployeerecord.Text == "XXX")
            {

             IWebElement DeleteRecord = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
             
                
                DeleteRecord.Click();

                Thread.Sleep(2000);

            driver.SwitchTo().Alert().Accept();


             }
            else
            {
             Assert.Fail("Record to be deleted hasen't found, EmployeeRecord not deleted");
             }

            //Assert that the Employee record has been deleted

             driver.Navigate().Refresh();

            // go to last page after refresh

            IWebElement gotolastpage2 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[4]/a[4]/span"));
            gotolastpage2.Click();

             //check if the created employee record is deleted or not

            //IWebElement EditName1 = driver.FindElement(By.XPath("//*[@id='usersGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
             
            //Assert.That(EditName1.Text != "XXX", "actual name do not match the record");
             









        }
    }
}
