using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TenyIC2023.Pages;
using NUnit.Framework;
using TenyIC2023.Utilities;

namespace TenyIC2023.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver

    {
        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPages(driver);
        }
        [Test]
        public void CreateTM_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTM(driver);
        }
        [Test]
        public void EditTM_Test()
        {
            // Edit TM
            TMPage tmPageObject = new TMPage();
            tmPageObject.EditTM(driver);
        }
        [Test]
        public void DeleteTM_Test()
        {
            // Delete TM
            TMPage tmPageObject = new TMPage();
            tmPageObject.DeleteTM(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {

        }

    }
}
