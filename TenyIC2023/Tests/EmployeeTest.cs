using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TenyIC2023.Pages;
using TenyIC2023.Utilities;

namespace TenyIC2023.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTest : CommonDriver
    {
        // Login page object initialization and definition
        HomePage homePageObj = new HomePage();
        EmployeePage employeePageObj = new EmployeePage();

        [Test]
        public void CreateEmployee_Test()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.CreateEmployee(driver);
        }

        [Test]
        public void EditEmployee_Test()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.EditEmployee(driver);
        }

        [Test]
        public void DeleteEmployee_Test()
        {
            homePageObj.GoToEmployeePage(driver);
            employeePageObj.DeleteEmployee(driver);
        }
    
}
}
