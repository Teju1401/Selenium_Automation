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
    internal class TMpage
    {
        private object actualcode;

        public void CreateTM(IWebDriver driver)
        {
            IWebElement createnewbutton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createnewbutton.Click();

            // select material from TypeCode dropdown

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDropdown.Click();

            IWebElement materialoption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));

            //identify Code textbox and input code
            IWebElement Codetextbox = driver.FindElement(By.Id("Code"));
            Codetextbox.SendKeys("Teja");

            // identify Description textbox and input description

            IWebElement Descriptiontextbox = driver.FindElement(By.Id("Description"));
            Descriptiontextbox.SendKeys("Testing");

            // identify Price per unit textbox
            IWebElement Priceperunit = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Priceperunit.SendKeys("1401");

            // ckick Save button
            IWebElement Savebutton = driver.FindElement(By.Id("SaveButton"));
            Savebutton.Click();
            
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 3);

            // click on Go to last page button
            

            IWebElement Gotolastpagebutton = driver.FindElement(By.XPath("/*[@id='tmsGrid']/div[4]/a[4]/span"));


            Gotolastpagebutton.Click();

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span", 3);

            //check if the record created present in the table and has expected values

            IWebElement Actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            Assert.That(Actualcode.Text == "Teja", "Actual code do not match")
        }


        public void EditTM(IWebDriver driver)
        {
            //Edit the previous created page

            // Click on Edit button

            IWebElement Editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            Editbutton.Click();

            // Edit code Textbox

            IWebElement CodeTextbox = driver.FindElement(By.Id("Code"));

            CodeTextbox.Clear();

            CodeTextbox.SendKeys("Mangam");

            //Edit Description Textbox
            IWebElement EditDescriptionTextBox = driver.FindElement(By.Id("Description"));
            EditDescriptionTextBox.Clear();
            EditDescriptionTextBox.SendKeys("Edit Testing");
        }

        public void DeleteTM(IWebDriver driver)
        {

        }



    }
}
   


