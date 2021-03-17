using OpenQA.Selenium;
using OrangeHRM.Hooks;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.PageObject
{
    class EntitlementWithParameterPage
    {
        private readonly FileLocations fileLocations;
        public EntitlementWithParameterPage()
        {
            driver = BaseTest.driver;
            fileLocations = new FileLocations();
          
        }

        IWebDriver driver;

        IWebElement Username => driver.FindElement(By.Id("txtUsername"));
        
        IWebElement Password => driver.FindElement(By.XPath("//input[@type='password']"));
        
        IWebElement Login => driver.FindElement(By.XPath("//input[@type='submit']"));

        IWebElement PIM => driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']"));

        IWebElement AddEmployee => driver.FindElement(By.XPath("//*[@id='menu_pim_addEmployee']"));

        IWebElement Firstname => driver.FindElement(By.XPath("//input[@type='text']"));

        IWebElement Lastname => driver.FindElement(By.Id("lastName"));

        IWebElement EmployeeId => driver.FindElement(By.XPath("//*[@id='employeeId']"));

        IWebElement ChooseFile => driver.FindElement(By.Id("photofile"));

        IWebElement CheckTheBox => driver.FindElement(By.XPath("//input[@type='checkbox']"));

        IWebElement employeeUsername => driver.FindElement(By.Id("user_name"));

        IWebElement employeePassword => driver.FindElement(By.Name("user_password"));

        IWebElement confirmPassword => driver.FindElement(By.Name("re_password"));







        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
        public void EnterUsername(string username)
        {
            Username.SendKeys(username);
        }
        public void EnterPasword(string password)
        {
            Password.SendKeys(password);
           
        }
        public void clickonLogin()
        {
            Login.Click();
        }

        public void clickonPIM()
        {
            PIM.Click();
        }
        public void clickonAddEmployee()
        {
            AddEmployee.Click();
        }
        public void enterFirstname(string firstname)
        {
            Firstname.SendKeys(firstname);
            
        }
        public void enterLastname(string lastname)
        {
            Lastname.SendKeys(lastname);
        }
        public void enterEmployeeId(string numbers)
        {
            EmployeeId.SendKeys(numbers);
        }
        public void ClickonchooseFile(string fileImage)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
            js.ExecuteScript("window.scrollBy(0, 1500)");
            string imageFolder = fileLocations.GetFolderLocation("TestDataImages");
            ChooseFile.SendKeys(imageFolder + fileImage);
        }
        public void ClickOnCheckBox()
        {
            CheckTheBox.Click();
        }
        public void enterEmployeeUsername(string username)
        {
            employeeUsername.SendKeys(username);
        }
        public void enterEmployeePassword(string employeepassword)
        {
            employeePassword.SendKeys(employeepassword);
        }
        public void enterConfirmPassword(string confirmpassword)
        {
            confirmPassword.SendKeys(confirmpassword);
        }
            
            

 






        


           
            
       

        








        

















    }
}
