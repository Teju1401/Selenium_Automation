using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testing.Pages
{
    internal class TMpage
    {
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

            Thread.Sleep(3000);

            // click on Go to last page button

            IWebElement Gotolastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

            Gotolastpagebutton.Click();

            Thread.Sleep(3000);

            //check if the record created present in the table and has expected values

            IWebElement Actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (Actualcode.Text == "Teja")
            {

                Console.WriteLine("Material record created succesfully.test passed");
            }
            else
            {
                Console.WriteLine("Test failed");
            }
        }

        public void EditTM(IWebDriver driver)
        {
            //Check if a user is able to edit the material record created in the previous test

            // click on editbox
            Thread.Sleep(4000);

            IWebElement SelectEditbox = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            SelectEditbox.Click();

            // Select Time from TypeCode dropedown

            IWebElement TypeCodedropedown = driver.FindElement(By.Id("TypeCode"));


            TypeCodedropedown.Click();

            IWebElement SelectTime = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span"));

            SelectTime.Click();


            // Edit code

            IWebElement CodeTextBox = driver.FindElement(By.Id("Code"));
            CodeTextBox.SendKeys("Mangam");


            // Edit description

            IWebElement DescriptionTextbox = driver.FindElement(By.Id("Description"));
            DescriptionTextbox.SendKeys("Test");

            // Edit price per unit
            IWebElement Priceperunittextbox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Priceperunittextbox.SendKeys("1911");

            //Click on Savebutton
        }

        public void DeleteTM(IWebDriver driver)
        {

        }

    }
   
}

