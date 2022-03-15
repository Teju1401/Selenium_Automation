using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Testing.Pages;
using Testing.Utilities;

namespace Testing
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        Homepage homepageObj = new Homepage();
        Loginpage loginPaageObj = new Loginpage();
        TMpage tmpageObj = new TMpage();

        [Given(@"I Logged into turnup portal successfully")]
        public void GivenILoggedIntoTurnupPortalSuccessfully()
        {
            driver = new ChromeDriver();

            loginPaageObj.Loginsteps(driver);

        }

        [Given(@"I navigate through TIme and Material page")]
        public void GivenINavigateThroughTImeAndMaterialPage()
        {

            homepageObj.GoToHomepage(driver);
        }

        [When(@"I create Time and Material page")]
        public void WhenICreateTimeAndMaterialPage()
        {

            tmpageObj.CreateTM(driver);
        }

        [Then(@"The Record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newcode = tmpageObj.Getcode(driver);
            string newtypeocde = tmpageObj.GetTypecode(driver);
            string newDescription = tmpageObj.GetDescription(driver);
            string newPrice = tmpageObj.GetPrice(driver);

            Assert.That(newcode == "Teja", "Actual code do not match");
            Assert.That(newtypeocde == "M", "Actual Typecode do not match");
            Assert.That(newDescription == "Testing", "Actual Description do not match");
            Assert.That(newPrice == "$1,401.00", "Actual Price do not match");




        }

        [When(@"I update '([^']*)','([^']*)','([^']*)' on an Time and Material page")]
        public void WhenIUpdateOnAnTimeAndMaterialPage(string p0, string p1, string p2)
        {
            tmpageObj.EditTM(driver, p0, p1, p2);
        }

        [Then(@"The Record should have the updateed '([^']*)','([^']*)','([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdateed(string p0, string p1, string p2)
        {
            string EditedDescription = tmpageObj.GetEditDescription(driver);
            string EditCode = tmpageObj.GetEditCode(driver);
            string EditPrice = tmpageObj.GetEditPrice(driver);

            Assert.That(EditedDescription == p0);
            Assert.That(EditCode == p1);
            Assert.That(EditPrice == p2);

        }



    }
}
