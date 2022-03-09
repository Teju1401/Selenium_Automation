using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Utilities;

namespace Testing.Pages
{
    public class Homepage
    {
        public void GoToHomepage(IWebDriver driver)
        {
            //Go To Home page

            IWebElement administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationdropdown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();

           
         
        }
        public void GoToEmployeeHomepage(IWebDriver driver)
        {
            //Go To Home page

            IWebElement administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationdropdown.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);

            IWebElement EmployeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            EmployeeOption.Click();


        }

        internal void GotoEmployeePage(IWebDriver driver)
        {
            throw new NotImplementedException();
        }

        internal void EmployeePage(IWebDriver driver)
        {
            throw new NotImplementedException();
        }
    }
}
