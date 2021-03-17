using OpenQA.Selenium;
using OrangeHRM.Hooks;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.PageObject
{
    class TotalHoursWorkedPage
    {
        private readonly FileLocations _fileLocations;

        public TotalHoursWorkedPage()
        {
            driver = BaseTest.driver;
            _fileLocations = new FileLocations();
        }

        IWebDriver driver;

        IWebElement time => driver.FindElement(By.XPath("//*[@id='menu_time_viewTimeModule']/b"));

        IWebElement attendance => driver.FindElement(By.XPath("//*[@id='menu_attendance_Attendance']"));

        IWebElement punch => driver.FindElement(By.XPath("//*[@id='menu_attendance_punchIn']"));

        IWebElement calendarIcon => driver.FindElement(By.CssSelector("#punchTimeForm > fieldset > ol > li:nth-child(1) > img"));

        IWebElement indate => driver.FindElement(By.XPath("//a[text()='15']"));

        IWebElement intime => driver.FindElement(By.XPath("//input[@id='attendance_time']"));

        IWebElement note => driver.FindElement(By.XPath("//*[@id='attendance_note']"));

        IWebElement inbutton => driver.FindElement(By.XPath("//*[@id='btnPunch']"));

        IWebElement calendarIcon2 => driver.FindElement(By.CssSelector("#punchTimeForm > fieldset > ol > li:nth-child(3) > img"));

        IWebElement outdate => driver.FindElement(By.XPath("//a[text()='15']"));

        IWebElement outtime => driver.FindElement(By.CssSelector("#attendance_time"));

        IWebElement note2 => driver.FindElement(By.XPath("//*[@id='attendance_note']"));

        IWebElement outbutton => driver.FindElement(By.XPath("//*[@id='btnPunch']"));

        IWebElement successfulsave => driver.FindElement(By.XPath("//*[@id='btnPunch']"));

        IWebElement records => driver.FindElement(By.XPath("//*[@id='menu_attendance_viewMyAttendanceRecord']"));

        IWebElement datepicker => driver.FindElement(By.XPath("//*[@id='reportForm']/fieldset/ol/li/img"));

        IWebElement date2  => driver.FindElement(By.XPath("//a[text()='15']"));

        IWebElement validatepunch => driver.FindElement(By.CssSelector("#employeeRecordsForm > table > tbody > tr.odd > td:nth-child(3)"));


        public void ClickOnTime()

        {
            time.Click();
        }

        public void ClickOnAttendance()
        {
            attendance.Click();
        }


        public void ClickOnPunch()
        {
            punch.Click();
        }

        public void ClickOnCalendarIcon()
        {
            calendarIcon.Click();
        }


        public void ClickOnIndate()

        {
            indate.Click();
        }

        public void EnterIntime(string Intime)

        {
            intime.Clear();
            intime.SendKeys(Intime);
        }


        public void EnterNote(string Note)

        {
            note.SendKeys(Note);
        }

        public void ClickOnInbutton()
        {
            inbutton.Click();
        }

        public void ClickOnCalendarIcon2()
        {
            calendarIcon2.Click();
        }

        public void ClickOnOutdate()
        {
            outdate.Click();
        }

        public void EnterOuttime(string Outtime)

        {
            outtime.Clear();
            outtime.SendKeys(Outtime);
        }

        public void EnterNote2(string Note2)

        {
            note2.SendKeys(Note2);
        }

        public void ClickOnOutbutton()
        {
            outbutton.Click();
        }

        public void ClickOnRecords()
        {
            records.Click();
        }

        public void ClickOnDatepicker()
        {
            datepicker.Click();
        }

        public void ClickOnDate2()
        {
            date2.Click();
        }

        public bool IsValidatePunchDisplayed()
        {
            return validatepunch.Displayed;
        }

        public bool IsInDisplayed()
        {
            return successfulsave.Displayed;
        }



    }
}
