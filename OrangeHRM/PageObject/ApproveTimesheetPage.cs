using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Hooks;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.PageObject
{
    class ApproveTimesheetPage
    {
        private readonly FileLocations _fileLocations;

        public ApproveTimesheetPage()
        {
            driver = BaseTest.driver;
            _fileLocations = new FileLocations();
        }

        IWebDriver driver;

        IWebElement username => driver.FindElement(By.XPath("//*[@id='txtUsername']"));

        IWebElement password => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement adminlogin => driver.FindElement(By.XPath("//*[@id='btnLogin']"));

        IWebElement pim => driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']/b"));

        IWebElement addemp => driver.FindElement(By.XPath("//*[@id='menu_pim_addEmployee']"));

        IWebElement firstname => driver.FindElement(By.XPath("//*[@id='firstName']"));

        IWebElement lastname => driver.FindElement(By.XPath("//*[@id='lastName']"));

        IWebElement chooseFile => driver.FindElement(By.Id("photofile"));

        IWebElement checkbox => driver.FindElement(By.XPath("//*[@id='chkLogin']"));

        IWebElement empusername => driver.FindElement(By.XPath("//*[@id='user_name']"));

        IWebElement empassword => driver.FindElement(By.XPath("//*[@id='user_password']"));

        IWebElement confirm => driver.FindElement(By.XPath("//*[@id='re_password']"));

        IWebElement save => driver.FindElement(By.XPath("//*[@id='btnSave']"));

        IWebElement validatename => driver.FindElement(By.XPath("//h1[text()='Lenora Williams']"));

        IWebElement welcome => driver.FindElement(By.XPath("//*[@id='welcome']"));

        IWebElement logout => driver.FindElement(By.CssSelector("#welcome-menu > ul > li:nth-child(2) > a"));

        IWebElement empusername2 => driver.FindElement(By.XPath("//*[@id='txtUsername']"));

        IWebElement empassword2 => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement userlogin => driver.FindElement(By.XPath("//*[@id='btnLogin']"));

        IWebElement timesheet => driver.FindElement(By.CssSelector("#dashboard-quick-launch-panel-menu_holder > table > tbody > tr > td:nth-child(3) > div > a > img"));

        IWebElement addtimesheet => driver.FindElement(By.XPath("//*[@id='btnAddTimesheet']"));

        IWebElement calendar => driver.FindElement(By.XPath("//*[@id='createTimesheetForm']/fieldset/ol/li/img"));

        IWebElement month => driver.FindElement(By.CssSelector("#ui-datepicker-div > div > div > select.ui-datepicker-month"));

        IWebElement date => driver.FindElement(By.XPath("//a[text()='15']"));

        IWebElement okay => driver.FindElement(By.XPath("//*[@id='addTimesheetBtn']"));

        IWebElement edit => driver.FindElement(By.XPath("//*[@id='btnEdit']"));

        IWebElement projectbox => driver.FindElement(By.CssSelector("#initialRows_0_projectName"));

        IWebElement projectname => driver.FindElement(By.CssSelector("#initialRows_0_projectName"));

        IWebElement projectname2 => driver.FindElement(By.CssSelector("body > div.ac_results > ul > li.ac_odd > strong:nth-child(1)"));

        IWebElement activity => driver.FindElement(By.CssSelector("#initialRows_0_projectActivityName"));

        IWebElement monday => driver.FindElement(By.XPath("//*[@id='initialRows_0_0']"));

        IWebElement tuesday => driver.FindElement(By.XPath("//*[@id='initialRows_0_1']"));

        IWebElement wednesday => driver.FindElement(By.XPath("//*[@id='initialRows_0_2']"));

        IWebElement thursday => driver.FindElement(By.XPath("//*[@id='initialRows_0_3']"));

        IWebElement friday => driver.FindElement(By.XPath("//*[@id='initialRows_0_4']"));

        IWebElement savetime => driver.FindElement(By.XPath("//*[@id='submitSave']"));

        IWebElement submit => driver.FindElement(By.XPath("//*[@id='btnSubmit']"));

        IWebElement validatetime => driver.FindElement(By.CssSelector("#timesheet_status > h2"));

        IWebElement username2 => driver.FindElement(By.XPath("//*[@id='txtUsername']"));

        IWebElement password2 => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement adminlogin2 => driver.FindElement(By.XPath("//*[@id='btnLogin']"));

        IWebElement time => driver.FindElement(By.XPath("//*[@id='menu_time_viewTimeModule']/b"));

        IWebElement timesheet2 => driver.FindElement(By.XPath("//*[@id='menu_time_Timesheets']"));

        IWebElement emptimesheet => driver.FindElement(By.XPath("//*[@id='menu_time_viewEmployeeTimesheet']"));

        IWebElement namebox => driver.FindElement(By.XPath("//*[@id='employee']"));

        IWebElement empname => driver.FindElement(By.XPath("//*[@id='employee']"));

        IWebElement view => driver.FindElement(By.XPath("//*[@id='btnView']"));

        IWebElement daterange => driver.FindElement(By.XPath("//*[@id='startDates']"));

        IWebElement approve => driver.FindElement(By.XPath("//*[@id='btnApprove']"));

        IWebElement approvetime => driver.FindElement(By.XPath("//*[@id='timesheet_status']/h2"));

        IWebElement employeelist => driver.FindElement(By.XPath("//*[@id='menu_pim_viewEmployeeList']"));

        IWebElement employeebox => driver.FindElement(By.XPath("//*[@id='empsearch_employee_name_empName']"));

        IWebElement employeename => driver.FindElement(By.XPath("//*[@id='empsearch_employee_name_empName']"));

        IWebElement search => driver.FindElement(By.XPath("//*[@id='searchBtn']"));

        IWebElement checkemployee => driver.FindElement(By.XPath("//*[@id='ohrmList_chkSelectAll']"));

        IWebElement delete => driver.FindElement(By.XPath("//*[@id='btnDelete']"));


        IWebElement ok => driver.FindElement(By.XPath("//*[@id='dialogDeleteBtn']"));







        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterUsername(string uname)
        {
            username.SendKeys(uname);
        }

        public void EnterPassword(string pword)
        {
            password.SendKeys(pword);
        }

        public void ClickOnAdminlogin()
        {
            adminlogin.Click();
        }

        public void ClickOnPim()
        {
            pim.Click();
        }

        public void ClickOnAddemp()
        {
            addemp.Click();
        }

        public void EnterFirstname(string fname)
        {
            
            firstname.SendKeys(fname);
        }


        public void EnterLastname(string lname)
        {
            
            lastname.SendKeys(lname);
        }

        public void ClickOnCheckbox()
        {
            checkbox.Click();
        }

        public void EnterEmpusername(string eusername)
        {
            empusername.SendKeys(eusername);
        }

        public void EnterEmpassword(string epassword)
        {
            empassword.SendKeys(epassword);
        }

        public void EnterConfirm(string conpass)
        {
            confirm.SendKeys(conpass);
        }

        public void ClickOnSave()
        {
            save.Click();
        }

        public bool IsValidatenameDisplayed()
        {
            return validatename.Displayed;
        }

        public void ClickOnWelcome()
        {
            welcome.Click();
        }

        public void ClickOnLogout()
        {
            logout.Click();
        }


        public void EnterEmpusername2(string eusername2)
        {
            empusername2.SendKeys(eusername2);
        }

        public void EnterEmpassword2(string epassword2)
        {
            empassword2.SendKeys(epassword2);
        }

        public void ClickOnUserlogin()
        {
            userlogin.Click();
        }

        public void ClickOnTimesheet()
        {
            timesheet.Click();
        }

        public void ClickOnAddtimesheet()
        {
            addtimesheet.Click();
        }

        public void ClickOnCalendar()
        {
            calendar.Click();
        }

        public void SelectMonth()
        {
            SelectElement select = new SelectElement(month);
            select.SelectByValue("1");
        }

        public void ClickOnDate()
        {
            date.Click();
        }

        public void ClickOnOkay()
        {
            okay.Click();
        }

        public void ClickOnChooseFile(string fileImage)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
            js.ExecuteScript("window.scrollBy(0, 1500)");
            string imageFolder = _fileLocations.GetFolderLocation("TestDataImages");
            chooseFile.SendKeys(imageFolder + fileImage);
        }

        public void ClickOnEdit()
        {
            edit.Click();
        }

        public void ClickOnProjectbox()
        {
            projectbox.Click();
        }

        public void EnterProjectname(string project)
        {

            projectname.SendKeys(project);
        }

        public void ClickOnProjectname2()
        {
            projectname2.Click();
        }

        public void SelectActivity()
        {
            SelectElement select = new SelectElement(activity);
            select.SelectByValue("28");
        }

        public void EnterMonday(string mday)
        {
            monday.SendKeys(mday);
        }

        public void EnterTuesday(string tday)
        {
            tuesday.SendKeys(tday);
        }

        public void EnterWednesday(string wday)
        {
            wednesday.SendKeys(wday);
        }

        public void EnterThursday(string thday)
        {
            thursday.SendKeys(thday);
        }

        public void EnterFriday(string fday)
        {
            friday.SendKeys(fday);
        }

        public void ClickOnSavetime()
        {
            savetime.Click();
        }

        public void ClickOnSubmit()
        {
            submit.Click();
        }

        public bool IsValidateTimesheetDisplayed()
        {
            return validatetime.Displayed;
        }

        public void EnterUsername2(string uname2)
        {
            username2.SendKeys(uname2);
        }

        public void EnterPassword2(string pword2)
        {
            password2.SendKeys(pword2);
        }

        public void ClickOnAdminlogin2()
        {
            adminlogin2.Click();
        }

        public void ClickOnTime()
        {
            time.Click();
        }

        public void ClickOnTimesheet2()
        {
            timesheet2.Click();
        }

        public void ClickOnEmptimesheet()
        {
            emptimesheet.Click();
        }

        public void ClickOnNamebox()
        {
            namebox.Click();
        }

        public void EnterEmpname(string ename)
        {
            empname.SendKeys(ename);
        }

        public void ClickOnView()
        {
            view.Click();
        }

        public void SelectDateRange()
        {
            SelectElement select = new SelectElement(daterange);
            select.SelectByValue("1");
        }

        public void ClickOnApprove()
        {
            approve.Click();
        }

        public bool IsApproveTimeDisplayed()
        {
            return approvetime.Displayed;
        }

        public void ClickOnEmployeeList()
        {
            employeelist.Click();
        }

        public void ClickOnEmployeeBox()
        {
            employeebox.Click();
        }

        public void EnterEmployeeName(string Employeename)
        {

            employeename.SendKeys(Employeename);
        }

        public void ClickOnSearch()
        {
            search.Click();
        }

        public void ClickOnCheckEmployee()
        {
            checkemployee.Click();
        }

        public void ClickOnDelete()
        {
            delete.Click();
        }

        public void ClickOnOk()
        {
            ok.Click();
        }


    }
}
