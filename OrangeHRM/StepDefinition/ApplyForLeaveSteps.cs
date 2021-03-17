//using NUnit.Framework;
//using OrangeHRM.PageObject;
//using System;
//using System.Threading;
//using TechTalk.SpecFlow;

//namespace OrangeHRM.StepDefinition
//{
//    [Binding]
//    public class AddEmployeeSteps


//    {
//        AddEmployeePage addEmployeePage;

//        public AddEmployeeSteps()
//        {
//            addEmployeePage = new AddEmployeePage();
//        }


//        [Given(@"a user navigates to https://opensource-demo\.orangehrmlive\.com/")]
//        public void GivenAUserNavigatesToHttpsOpensource_Demo_Orangehrmlive_Com()
//        {
//            addEmployeePage.NavigateToWebsite();

//        }

//        [Given(@"the user enters admin username ""(.*)""")]
//        public void GivenTheUserEntersAdminUsername(string AdminUserName)
//        {
//            addEmployeePage.EnterAdminUsername(AdminUserName);
//        }


//        [Given(@"the user enters admin password ""(.*)""")]
//        public void GivenTheUserEntersAdminPassword(string AdminPassword)
//        {
//            addEmployeePage.EnterAdminPassword(AdminPassword);
//        }


//        [Given(@"the user clicks the log in button")]
//        public void GivenTheUserClicksTheLogInButton()
//        {
//            addEmployeePage.ClickLoginButton();
//        }

//        [Given(@"the user clicks on PIM")]
//        public void GivenTheUserClicksOnPIM()
//        {
//            addEmployeePage.ClickOnPimButton();
//        }

//        [Given(@"the user clicks on Add Employee")]
//        public void GivenTheUserClicksOnAddEmployee()
//        {
//            Thread.Sleep(1000);
//            addEmployeePage.ClickAddEmployeeButton();
//        }

//        [Given(@"the user enters first name ""(.*)""")]
//        public void GivenTheUserEntersFirstName(string Firstname)
//        {
//            addEmployeePage.EnterFirstName(Firstname);
//        }


//        [Given(@"the user enters last name ""(.*)""")]
//        public void GivenTheUserEntersLastName(string Lastname)
//        {
//            addEmployeePage.EnterLastName(Lastname);
//        }


//        [Given(@"the user enters Employee number ""(.*)""")]
//        public void GivenTheUserEntersEmployeeNumber(string Employeenumber)
//        {
//            addEmployeePage.EnterEmployeeNumber(Employeenumber);
//        }


//        [Given(@"the user clicks on Choose file")]
//        public void GivenTheUserClicksOnChooseFile()
//        {
//            addEmployeePage.ClickChooseFile();
//        }

//        [Given(@"the user ticks the create Log in Details box")]
//        public void GivenTheUserTicksTheCreateLogInDetailsBox()
//        {
//            addEmployeePage.ClickCreateLoginDetailsBox();
//        }


//        [Given(@"the user enters username ""(.*)""")]
//        public void GivenTheUserEntersUsername(string UserName)
//        {
//            addEmployeePage.EnterUserName(UserName);
//        }


//        [Given(@"the user enters password ""(.*)""")]
//        public void GivenTheUserEntersPassword(string Password)
//        {
//            addEmployeePage.EnterPassword(Password);
//        }


//        [Given(@"the user confirms password ""(.*)""")]
//        public void GivenTheUserConfirmsPassword(string Password1)
//        {
//            addEmployeePage.ConfirmPassword(Password1);
//        }


//        [Given(@"the user selects the Enabled option for Status")]
//        public void GivenTheUserSelectsTheEnabledOptionForStatus()
//        {
//            addEmployeePage.EnabledOptionForStatus();

//        }

//        [Given(@"I click the save button")]
//        public void GivenIClickTheSaveButton()
//        {
//            addEmployeePage.ClickSaveButton();
//        }


//        [Given(@"I click on Leave")]
//        public void GivenIClickOnLeave()
//        {
//            addEmployeePage.ClickLeaveButton();
//        }

//        [Given(@"I click on Entitlement")]
//        public void GivenIClickOnEntitlement()
//        {
//            addEmployeePage.ClickOnEntitlementButton();
//        }

//        [Given(@"I clicks on Add Entitlement")]
//        public void GivenIClicksOnAddEntitlement()
//        {
//            addEmployeePage.SelectAddEntitlement();
//        }

//        [Given(@"I enter employee name ""(.*)""")]
//        public void GivenIEnterEmployeeName(string Firstname)
//        {
//            addEmployeePage.EnterEmployeeName(Firstname);
//        }

//        [Given(@"I select Leave type chosen")]
//        public void GivenISelectLeaveTypeChosen()
//        {
//            addEmployeePage.SelectLeaveTypeChosen();
//        }


//        [Given(@"I select Leave Period")]
//        public void GivenISelectLeavePeriod()
//        {
//            addEmployeePage.ClickLeavePeriod();
//        }

//        [Given(@"I enter number of days for entitlement ""(.*)""")]
//        public void GivenIEnterNumberOfDaysForEntitlement(string Entitlement)
//        {
//            addEmployeePage.EnterEntitlement(Entitlement);
//        }

//        [Given(@"I click on Save")]
//        public void GivenIClickOnSave()
//        {
//            addEmployeePage.ClickOnSaveButton();
//        }

//        [Given(@"I click confirm button")]
//        public void GivenIClickConfirmButton()
//        {
//            addEmployeePage.ClickConfirmButton();
//        }

//        [Given(@"I click on Profile name")]
//        public void GivenIClickOnProfileName()
//        {
//            addEmployeePage.ClickOnProfileName();
//        }

//        [When(@"I click on Log out")]
//        public void WhenIClickOnLogOut()
//        {
//            addEmployeePage.ClickLogOutButton();
//        }

//        [Then(@"I should be logged out to the login page")]
//        public void ThenIShouldBeLoggedOutToTheLoginPage()
//        {
//            Assert.That(addEmployeePage.IShouldBeLoggedOutToLoginPage);
//        }


















//    }
//}