using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TenyIC2023.Pages;
using TenyIC2023.Utilities;

namespace TenyIC2023.StepDefinitions
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObject = new TMPage();


        [Given(@"I logged into turn up portal successfully")]
        public void GivenILoggedIntoTurnUpPortalSuccessfully()
        {
            // Open chrome driver
            driver = new ChromeDriver();

            // Login turnup portal
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            homePageObj.GoToTMPage(driver);
        }

        [When(@"I create a new time and material record")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            tmPageObject.CreateTM(driver);
        }

        [Then(@"The record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            string newCode = tmPageObject.GetCode(driver);
            string newDescription = tmPageObject.GetDescription(driver);
            string newPrice = tmPageObject.GetPrice(driver);

            Assert.That(newCode == "TenyIC2023", "Actual code and expected code do not match.");
            Assert.That(newDescription == "TenyIC2023", "Actual description and expected description do not match.");
            Assert.That(newPrice == "$12.00", "Actual price and expected price do not match.");
        }

        [When(@"I update '([^']*)', '([^']*)','([^']*)' on an existing time and material record")]
        public void WhenIUpdateOnAnExistingTimeAndMaterialRecord(string Description, string code, string price)
        {
            tmPageObject.EditTM(driver, Description, code, price);

        }



       
        [Then(@"the record should have the updated '([^']*)','([^']*)' and '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdatedAnd(string Description, string code, string price)
        {
            string editedDescription = tmPageObject.GetDescription(driver);
            string editedCode = tmPageObject.GetCode(driver);
            string editedPrice = tmPageObject.GetPrice(driver);

            Assert.That(editedDescription == Description, "Actual Description and expected Description do not match.");
            Assert.That(editedCode == code, "Actual code and expected code do not match.");
            Assert.That(editedPrice == price, "Actual price and expected price do not match.");
        }

    }
}
