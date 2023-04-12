using OpenQA.Selenium;


namespace TenyIC2023.Pages
{
    public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();

            // launch turn up portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);



            // identify username textbox and enter valid username
            IWebElement usernameTexttbox = driver.FindElement(By.Id("UserName"));
            usernameTexttbox.SendKeys("hari");


            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // identify login button and click on it
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(2000);
        }
    }
}
