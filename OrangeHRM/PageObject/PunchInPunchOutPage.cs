using OpenQA.Selenium;
using OrangeHRM.Hooks;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.PageObject



{
    class PunchInPunchOutPage
    {
        public PunchInPunchOutPage()
        {
            driver = BaseTest.driver;
        }

        IWebDriver driver;

        IWebElement employeeUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));

        IWebElement employeePassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement theLoginButton => driver.FindElement(By.XPath("//*[@id='btnLogin']"));

        IWebElement time => driver.FindElement(By.CssSelector("#menu_time_viewTimeModule > b"));

        IWebElement attendance => driver.FindElement(By.XPath("//*[@id='menu_attendance_Attendance']"));

        IWebElement punchInPunchOut => driver.FindElement(By.XPath("//*[@id='menu_attendance_punchIn']"));

        IWebElement note => driver.FindElement(By.XPath("//*[@id='attendance_note']"));

        IWebElement iN => driver.FindElement(By.XPath("//*[@id='btnPunch']"));

        IWebElement checkInConfirmed => driver.FindElement(By.XPath("//*[@id='attendance_time']"));

        IWebElement outbutton => driver.FindElement(By.XPath("//*[@id='btnPunch']"));

        IWebElement checkOutConfirmed => driver.FindElement(By.XPath("//*[@id='attendance_time']"));



        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        public void EmployeeUsername(string EmployeeUsername)
        {
            employeeUsername.SendKeys(EmployeeUsername);
        }

        public void EnterEmployeePassword(string EmployeePassword)
        {
            employeePassword.SendKeys(EmployeePassword);
        }

        public void ClickLoginButton()
        {
            theLoginButton.Click();
        }

        public void ClickTimeButton()
        {
            time.Click();
        }

        public void ClickAttendanceButton()
        {
            attendance.Click();
        }

        public void SelectPunchInandOut()
        {
            punchInPunchOut.Click();
        }
        
        public void EnterNote(string Note)
        {
            note.SendKeys(Note);
        }

        public void ClickIn()
        {
            iN.Click();
        }

        public bool IsEmployeeCheckedIn()
        {
            return checkInConfirmed.Displayed;
        }

        public void ClickOut()
        {
            outbutton.Click();
        }

        public bool IsEmployeeCheckedOut()
        {
            return checkOutConfirmed.Displayed;
        }














































































    }
}
