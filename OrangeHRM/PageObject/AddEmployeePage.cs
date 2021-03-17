using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Hooks;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OrangeHRM.PageObject
{
    class AddEmployeePage
    {
                private readonly FileLocations _fileLocation;
        public AddEmployeePage()
        {
             driver = BaseTest.driver;
            _fileLocation = new FileLocations();
        }
        IWebDriver driver;
        

        IWebElement username => driver.FindElement(By.CssSelector("#txtUsername"));
        IWebElement password => driver.FindElement(By.CssSelector("#txtPassword"));
        IWebElement login => driver.FindElement(By.CssSelector("#btnLogin"));
        IWebElement pim => driver.FindElement(By.CssSelector("#menu_pim_viewPimModule > b"));
        IWebElement addemployee => driver.FindElement(By.CssSelector("#menu_pim_addEmployee"));
        IWebElement firstname => driver.FindElement(By.CssSelector("#firstName"));
        IWebElement middlename => driver.FindElement(By.CssSelector("#middleName"));
        IWebElement surname => driver.FindElement(By.CssSelector("#lastName"));
        IWebElement employeenumber => driver.FindElement(By.CssSelector("#employeeId"));
        IWebElement chooseFile => driver.FindElement(By.Id("photofile"));
        IWebElement checkbox => driver.FindElement(By.XPath("//*[@id='chkLogin']"));
        IWebElement userName => driver.FindElement(By.XPath("//*[@id='user_name']"));
        IWebElement passWord => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement confirmPassword => driver.FindElement(By.XPath("//*[@id='re_password']"));
        IWebElement clicksavebutton => driver.FindElement(By.XPath("//*[@id='btnSave']"));


        // Seun PageObject Element

        IWebElement adminUsername => driver.FindElement(By.XPath("//*[@id='txtUsername']"));

        IWebElement adminPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement loginButton => driver.FindElement(By.XPath("//*[@id='btnLogin']"));

        IWebElement pimButton => driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']/b"));

        IWebElement addEmployeeButton => driver.FindElement(By.XPath("//*[@id='menu_pim_addEmployee']"));

        IWebElement firstName => driver.FindElement(By.XPath("//*[@id='firstName']"));

        IWebElement lastName => driver.FindElement(By.XPath("//*[@id='lastName']"));

        IWebElement employeeNumber => driver.FindElement(By.XPath("//*[@id='employeeId']"));

        IWebElement chooseFile1 => driver.FindElement(By.XPath("//*[@id='photofile']"));

        IWebElement createLoginDetailsBox => driver.FindElement(By.XPath("//*[@id='chkLogin']"));

        IWebElement userName1 => driver.FindElement(By.XPath("//*[@id='user_name']"));

        IWebElement password1 => driver.FindElement(By.XPath("//*[@id='user_password']"));

        IWebElement confirmPassword1 => driver.FindElement(By.XPath("//*[@id='re_password']"));

        IWebElement enabledOptionForStatus => driver.FindElement(By.XPath("//*[@id='status']"));

        IWebElement saveButton => driver.FindElement(By.XPath("//*[@id='btnSave']"));

        IWebElement leaveButton => driver.FindElement(By.CssSelector("#menu_leave_viewLeaveModule > b"));

        IWebElement entitlementButton => driver.FindElement(By.Id("menu_leave_Entitlements"));

        IWebElement addEntitlement => driver.FindElement(By.Id("menu_leave_addLeaveEntitlement"));

        IWebElement employee => driver.FindElement(By.XPath("//*[@id='entitlements_employee_empName']"));

        IWebElement employeeName => driver.FindElement(By.XPath("//li[@class = 'ac_even ac_over']"));

        //IWebElement leaveType => driver.FindElement(By.XPath("//*[@id='entitlements_leave_type']"));

        IWebElement leaveTypeChosen => driver.FindElement(By.CssSelector("#entitlements_leave_type"));

        IWebElement leavePeriod => driver.FindElement(By.XPath("//*[@id='period']/option[2]"));

        IWebElement entitlement => driver.FindElement(By.XPath("//*[@id='entitlements_entitlement']"));

        IWebElement save => driver.FindElement(By.XPath("//*[@id='btnSave']"));

        IWebElement confirm => driver.FindElement(By.CssSelector("#dialogUpdateEntitlementConfirmBtn"));

        IWebElement profileName => driver.FindElement(By.XPath("//*[@id='welcome']"));

        IWebElement logOut => driver.FindElement(By.CssSelector("#welcome-menu > ul > li:nth-child(2) > a"));

        IWebElement enterUserName => driver.FindElement(By.CssSelector("#txtUsername"));

        IWebElement enterMyPassword => driver.FindElement(By.XPath("//*[@id='txtPassword']"));

        IWebElement fromCalendarOption => driver.FindElement(By.XPath("//*[@id='frmFilterLeave']/fieldset/ol/li[1]/img"));

        IWebElement leaveStart => driver.FindElement(By.CssSelector("#ui-datepicker-div > table > tbody > tr:nth-child(1) > td:nth-child(2) > a"));

        IWebElement toCalendarOption => driver.FindElement(By.CssSelector("#frmFilterLeave > fieldset > ol > li:nth-child(2) > img"));

        IWebElement leaveToDate => driver.FindElement(By.XPath("//a[text()='17']"));

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

        IWebElement validateEmployee => driver.FindElement(By.XPath("//*[@id='btnSave']"));

        IWebElement loginPageDisplayed => driver.FindElement(By.XPath("//*[@id='forgotPasswordLink']/a"));




        public void EnterUsername()
        {
            username.SendKeys("Admin");
        }

        public void EnterPassword()
        {
            password.SendKeys("admin123");
        }

        public void ClickOnLogin()
        {
            login.Click();
        }

        public void ClickOnPim()
        {
            pim.Click();
        }

        public void ClickOnAddEmployee()
        {
            addemployee.Click();
        }


        public void EnterFirstname()
        {
            firstname.SendKeys("Micheal");
        }

        public void EnterMiddlename()
        {
            middlename.SendKeys("Omotola");
        }

        public void EnterSurname()
        {
            surname.SendKeys("Brown");
        }

        public void EnterEmployeenumber()
        {
            employeenumber.SendKeys("4563");
        }

        public void ClickOnChooseFile(string fileImage)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)BaseTest.driver;
            js.ExecuteScript("window.scrollBy(0, 1500)");
            string imageFolder = _fileLocation.GetFolderLocation("TestDataImages");
            chooseFile.SendKeys(imageFolder + fileImage);
        }

        public void ClickOnBox()
        {
            checkbox.Click();
        }

        public void EnteruserName()
        {
            userName.SendKeys("Admin");
        }

        public void EnterpassWord()
        {
            passWord.SendKeys("Admin123");
        }

        public void EnterconfirmPassword()
        {
            confirmPassword.SendKeys("Admin123");
        }

        public void clickSavebutton()
        {
            clicksavebutton.Click();
        }

        

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        internal static void Enterusername()
        {
            throw new NotImplementedException();
        }

        // Seun PageObject Method

        //public void NavigateToWebsite()
        //{
        //    driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        //}

        public void EnterAdminUsername(string AdminUserName)
        {
            adminUsername.SendKeys(AdminUserName);
        }

        public void EnterAdminPassword(string AdminPassword)
        {
            adminPassword.SendKeys(AdminPassword);
        }

        public void ClickLoginButton()
        {
            loginButton.Click();
        }

        public void ClickOnPimButton()
        {
            pimButton.Click();
        }

        public void ClickAddEmployeeButton()
        {
            addEmployeeButton.Click();
        }

        public void EnterFirstName(string Firstname)
        {
            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //firstName.SendKeys("Bobby" + randomInt);
            firstName.SendKeys(Firstname);
        }

        public void EnterLastName(string Lastname)
        {
            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //lastName.SendKeys("Benson" + randomInt);
            lastName.SendKeys(Lastname);
        }

        public void EnterEmployeeNumber(string EmployeeNumber)
        {

            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //employeeNumber.SendKeys("EmployeeNumber" + randomInt);
            employeeNumber.SendKeys(EmployeeNumber);
        }

        public void ClickChooseFile()
        {
            chooseFile.Click();
        }

        public void ClickCreateLoginDetailsBox()
        {
            createLoginDetailsBox.Click();
        }

        public void EnterUserName(string UserName)
        {
            //Random randomGenerator = new Random();
            //int randomInt = randomGenerator.Next(1000);
            //userName.SendKeys("Username" + randomInt);
            userName1.SendKeys(UserName);
        }

        public void EnterPassword(string Password)
        {
           password1.SendKeys(Password);
        }

        public void ConfirmPassword(string Password1)
        {
            confirmPassword1.SendKeys(Password1);
        }

        public void EnabledOptionForStatus()
        {
            enabledOptionForStatus.Click();
        }

        public void ClickSaveButton()
        {
            saveButton.Click();
        }


        public void ClickLeaveButton()
        {
            Thread.Sleep(3000);
            leaveButton.Click();
        }

        public void ClickOnEntitlementButton()
        {
            entitlementButton.Click();
        }

        public void SelectAddEntitlement()
        {
            Thread.Sleep(2000);
            addEntitlement.Click();
        }

        public void EnterEmployeeName(string Firstname)
        {
            Thread.Sleep(2000);
            employee.SendKeys(Firstname);
            employeeName.Click();

        }


        public void SelectLeaveTypeChosen()
        {
            SelectElement select = new SelectElement(leaveTypeChosen);
            select.SelectByValue("4");

        }
        public void ClickLeavePeriod()
        {
            leavePeriod.Click();
        }

        public void ClickOnLeaveDate()
        {
            leavePeriod.Click();
        }

        public void EnterEntitlement(string Entitlement)
        {
            entitlement.SendKeys(Entitlement);
        }

        public void ClickOnSaveButton()
        {
            save.Click();
        }

        public void ClickConfirmButton()
        {
            Thread.Sleep(3000);
            confirm.Click();
        }


        public void ClickOnProfileName()
        {
            Thread.Sleep(5000);
            profileName.Click();
        }

        public void ClickLogOutButton()
        {
            Thread.Sleep(3000);

            logOut.Click();

        }

        public bool IShouldBeLoggedOutToLoginPage()
        {
            return loginPageDisplayed.Displayed;
        }




        public void UserEntersName(string UserName)
        {
            Thread.Sleep(3000);
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

        public void ClickFromCalendarIcon()
        {
            fromCalendarOption.Click();
        }

        public void ClickLeaveStart()
        {
            leaveStart.Click();

        }

        public void ClickToCalendarIcon()
        {
            toCalendarOption.Click();

        }


        public void ClickLeaveToDate()
        {
            Thread.Sleep(2000);
            leaveToDate.Click();
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







    }
}


        
    

