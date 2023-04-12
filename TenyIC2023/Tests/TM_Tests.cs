using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using TenyIC2023.Pages;


// open chrome browser
IWebDriver driver = new ChromeDriver();

// Login page object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);

// Home page object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPages(driver);

// TM page object initialization and definition
TMPage tmPageObject = new TMPage();
tmPageObject.CreateTM(driver);

// Edit TM
tmPageObject.EditTM(driver);

// Delete TM
tmPageObject.DeleteTM(driver);



//// check if use has logged in successfully
//IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
//if (helloHari.Text == "Hello hari!")
//{
//    Console.WriteLine("User has logged in successfully.");
//}

//// create new time record







