using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Hooks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrangeHRM.PageObject
{
    class LeaveApplicationPage
    {
        public LeaveApplicationPage()
        {
            driver = BaseTest.driver;
        }

        IWebDriver driver;

        IWebElement enterUserName => driver.FindElement(By.CssSelector("#txtUsername"));

        IWebElement enterMyPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement loginButton => driver.FindElement(By.XPath("//*[@id='btnLogin']"));

        IWebElement leave => driver.FindElement(By.XPath("//*[@id='menu_leave_viewLeaveModule']/b"));

        
        IWebElement apply => driver.FindElement(By.XPath("//*[@id='menu_leave_applyLeave']"));

        IWebElement leaveType => driver.FindElement(By.XPath("//*[@id='applyleave_txtLeaveType']"));

        IWebElement fromDate => driver.FindElement(By.CssSelector("#frmLeaveApply > fieldset > ol > li:nth-child(3) > img"));

        IWebElement chooseDate => driver.FindElement(By.XPath("//a[text()='1']"));

        IWebElement toDate => driver.FindElement(By.CssSelector("#frmLeaveApply > fieldset > ol > li:nth-child(4) > img"));

        IWebElement selectedDate => driver.FindElement(By.XPath("//a[text()='5']"));

        IWebElement partialDays => driver.FindElement(By.XPath("//*[@id='applyleave_partialDays']"));

        IWebElement selectPartialDay => driver.FindElement(By.XPath("//*[@id='applyleave_partialDays']/option[1]"));

        IWebElement comment => driver.FindElement(By.XPath("//*[@id='applyleave_txtComment']"));

        IWebElement clickApply => driver.FindElement(By.XPath("//*[@id='applyBtn']"));

        IWebElement profileName => driver.FindElement(By.XPath("//*[@id='welcome']"));

        IWebElement logOut => driver.FindElement(By.CssSelector("#welcome-menu > ul > li:nth-child(2) > a"));

        IWebElement logInPage => driver.FindElement(By.XPath("//*[@id='forgotPasswordLink']/a"));

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }


        public void UserEntersName(string UserName)
        {
           
            enterUserName.SendKeys(UserName);
        }

        public void EnterMyPassword(string Password)
        {
            enterMyPassword.SendKeys(Password);
        }

        public void ClickOnLoginButton()
        {
            loginButton.Click();
        }

        public void ClickLeaveButton()
        {
            leave.Click();
        }
                
        public void ClickApply()
        {
            apply.Click();
        }

        public void SelectLeaveType()
        {
            SelectElement select = new SelectElement(leaveType);
            select.SelectByValue("4");

        }

        public void SelectFromDate()
        {
            fromDate.Click();
            chooseDate.Click();
        }

        public void SelectToDate()
        {
            toDate.Click();
            selectedDate.Click();
        }

        public void ClickPartialDays()
        {
            partialDays.Click();
            selectPartialDay.Click();
        }

        public void LeaveComment(string TaskCompleted)
        {
            comment.SendKeys(TaskCompleted);
        }

        public void ClickOnApply()
        {
            clickApply.Click();
        }

        public void ClickOnProfileName()
        {
            Thread.Sleep(3000);
            profileName.Click();
        }

        public void ClickLogOutButton()
        {
            Thread.Sleep(3000);

            logOut.Click();

        }

        public bool IsLogInPageDisplayed()
        {
            return logInPage.Displayed;
        }





































    }
}
