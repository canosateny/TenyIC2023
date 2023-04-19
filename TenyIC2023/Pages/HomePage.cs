
using OpenQA.Selenium;
using TenyIC2023.Utilities;

namespace TenyIC2023.Pages
{
    public class HomePage 
    {
        public void GoToTMPage(IWebDriver driver)
        {
            // navigate to time and material module
            IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administration.Click();
            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 7);

            IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmOption.Click();
        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            // code to navigate to Employee page
        }
    }
}