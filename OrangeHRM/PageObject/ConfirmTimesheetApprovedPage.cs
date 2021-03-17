using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Hooks;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.PageObject
{
    class ConfirmTimesheetApprovedPage
    {
        private readonly FileLocations _fileLocations;

        public ConfirmTimesheetApprovedPage()
        {
            driver = BaseTest.driver;
            _fileLocations = new FileLocations();
        }

        IWebDriver driver;


        IWebElement emptimesheet => driver.FindElement(By.XPath("//*[@id='menu_time_Timesheets']"));

        IWebElement mytimesheets => driver.FindElement(By.CssSelector("#menu_time_viewMyTimesheet"));

        IWebElement timesheetdate => driver.FindElement(By.XPath("//*[@id='startDates']"));

        IWebElement validatestatus => driver.FindElement(By.CssSelector("#timesheet_status > h2"));



        public void ClickOnEmptimesheet()
        {
            emptimesheet.Click();
        }

        public void ClickOnMytimesheets()
        {
            mytimesheets.Click();
        }

        public void SelectTimesheetDate()
        {
            SelectElement select = new SelectElement(timesheetdate);
            select.SelectByValue("1");
        }


        public bool IsStatusDisplayed()
        {
            return validatestatus.Displayed;
        }







    }
}
