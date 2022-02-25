using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            //indentify password text and valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");
            // click on login button
            IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginbutton.Click();
            // check if user is login successfully
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
                Console.WriteLine("Logged i successfully, test passed");
            else
                Console.WriteLine("Login failed, test failed");
            //create time and material record

            // go to time and material page

            IWebElement administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationdropdown.Click();

            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
             tmoption.Click();

            // click on create new button
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

            Thread.Sleep(1000);

            // click on Go to last page button

            IWebElement Gotolastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));

          Gotolastpagebutton.Click();

           
            //check if the record created present in the table and has expected values

            //IWebElement Actualcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

           // if (Actualcode.Text == "Teja")
            {

                Console.WriteLine("Material record created succesfully.test passed");
            }
           // else
            {
                Console.WriteLine("Test failed");
            }

            

            























        }
    }
}
