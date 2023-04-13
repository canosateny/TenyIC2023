using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;


namespace TenyIC2023.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {

            // click on create new button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            // select Time option from dropdown
            IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
            dropdown.Click();

            Thread.Sleep(2000);

            IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            timeOption.Click();

            // type code into code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("TenyIC2023");

            // type description into description textbox
            driver.FindElement(By.Id("Description")).SendKeys("TenyIC2023");

            // type price into price per unit textbox
            IWebElement priceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceOverlap.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("120");

            // click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(3000);

            // check if new Time record has been created successfully
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement newDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement newPrice = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[4]"));

            Assert.That(newCode.Text == "TenyIC2023", "Actual code and expected code do not match.");
            Assert.That(newDescription.Text == "TenyIC2023", "Actual description and expected description do not match.");
            Assert.That(newPrice.Text == "$120.00", "Actual price and expected price do not match.");

            //if (newCode.Text == "TenyIC2023")
            //{
            //    Assert.Pass("New record has been created successfully.");
            //}
            //else
            //{
            //    Assert.Fail("Record hasn't been created.");
            //}
        }
        public void EditTM(IWebDriver driver)
        {
            //Edit time record

            //click on edit button
            Thread.Sleep(15000);

            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(2000);

            //select Time option from dropdown
            IWebElement dropdownEdit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
            dropdownEdit.Click();
            Thread.Sleep(2000);

            IWebElement timeOptionEdit = driver.FindElement(By.XPath("//*[@id=\"TypeCode-list\"]"));
            timeOptionEdit.Click();

            //edit code into code textbox
            IWebElement editcodeTextbox = driver.FindElement(By.XPath("//*[@id=\"Code\"]"));
            editcodeTextbox.Clear();
            editcodeTextbox.SendKeys("TenyIC23Edit");

            //edit description into description boxr1q
            IWebElement editdescriptionTextbox = driver.FindElement(By.XPath("//*[@id=\"Description\"]"));
            editdescriptionTextbox.Clear();
            editdescriptionTextbox.SendKeys("TenyIC23Edit");



            //edit price into price per unit textbox
            IWebElement editpriceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement editpriceTextbox = driver.FindElement(By.Id("Price"));

            editpriceOverlap.Click();
            editpriceTextbox.Clear();
            editpriceOverlap.Click();
            editpriceTextbox.SendKeys("200");

            //click on save button
            IWebElement savebuttonEdit = driver.FindElement(By.Id("SaveButton"));
            savebuttonEdit.Click();
            Thread.Sleep(2000);


            //check if Time record has been edited
            IWebElement goToEditLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToEditLastPageButton.Click();

            IWebElement editCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));

            if (editCode.Text != "TenyIC23")
            {
                Console.WriteLine("Record has been edited successfully.");
            }
            else
            {
                Console.WriteLine("User hasn't been logged in.");
            }
            Thread.Sleep(5000);


        }

        public void DeleteTM(IWebDriver driver)
        {
            // Delete record

            //click on delete button
            Thread.Sleep(2000);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();



            //Popup window Delete confirmation
            Thread.Sleep(5000);
            IAlert deleteOk = driver.SwitchTo().Alert();
            String alertText = deleteOk.Text;
            deleteOk.Accept();


            //check the record deleted successfully
            IWebElement deleteCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]"));
            if (deleteCode.Text != "TenyIC23")
            {
                Console.WriteLine("Record has been deleted successfully.");
            }
            else
            {
                Console.WriteLine("User hasn't been logged in.");
            }
            Thread.Sleep(5000);


        }
    }
}
