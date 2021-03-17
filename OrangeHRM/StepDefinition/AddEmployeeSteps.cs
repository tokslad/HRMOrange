using NUnit.Framework;
using OrangeHRM.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class AddEmployeeSteps
    {
        AddEmployeePage addemployeePage;
        

        public AddEmployeeSteps()
        {
            addemployeePage = new AddEmployeePage();
        }









        [Given(@"a user nagivate to the website")]
        public void GivenAUserNagivateToTheWebsite()
        {
            addemployeePage.NavigateToWebsite();
        }

        [Given(@"user enter the username")]
        public void GivenUserEnterTheUsername()
        {
            addemployeePage.EnterUsername();
        }

        
        [Given(@"user enter the password")]
        public void GivenUserEnterThePassword()
        {
            addemployeePage.EnterPassword();
        }

        [When(@"user click on login")]
        public void WhenUserClickOnLogin()
        {
            addemployeePage.ClickOnLogin();
        }

        [When(@"user click on PIM")]
        public void WhenUserClickOnPIM()
        {
            addemployeePage.ClickOnPim();
        }

        [When(@"user click on add employee")]
        public void WhenUserClickOnAddEmployee()
        {
            addemployeePage.ClickOnAddEmployee();
        }

        [When(@"user enter the firstname")]
        public void WhenUserEnterTheFirstname()
        {
            addemployeePage.EnterFirstname();
        }


        [When(@"user enter the middlename")]
        public void WhenUserEnterTheMiddlename()
        {
            addemployeePage.EnterMiddlename();
        }


        [When(@"user enter the surname")]
        public void WhenUserEnterTheSurname()
        {
            addemployeePage.EnterSurname();
        }

        [When(@"user enter employee number")]
        public void WhenUserEnterEmployeeNumber()
        {
            addemployeePage.EnterEmployeenumber();
        }

        [When(@"user click on choose file ""(.*)""")]
        public void WhenUserClickOnChooseFile(string file)
        {
            Thread.Sleep(5000);
            addemployeePage.ClickOnChooseFile(file);
            ScenarioContext.Current["file"] = file;
        }

       

        [When(@"user check the box for create login details")]
        public void WhenUserCheckTheBoxForCreateLoginDetails()
        {
            addemployeePage.ClickOnBox();
        }


        [When(@"user enter the username")]
        public void WhenUserEnterTheUsername()
        {
            addemployeePage.EnteruserName();
        }

        [When(@"user enter the password")]
        public void WhenUserEnterThePassword()
        {
            addemployeePage.EnterpassWord();
        }

        [When(@"user enter confirm password")]
        public void WhenUserEnterConfirmPassword()
        {
            addemployeePage.EnterconfirmPassword();
        }

        [When(@"user select enabled for status")]
        public void WhenUserSelectEnabledForStatus()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"user click on save")]
        public void WhenUserClickOnSave()
        {
            addemployeePage.clickSavebutton();
        }
















        [Then(@"result should be able to add employee")]
        public void ThenResultShouldBeAbleToAddEmployee()
        {
            ScenarioContext.Current.Pending();
        }




        // Seun Step Definition

        [Given(@"a user navigates to https://opensource-demo\.orangehrmlive\.com/")]
        public void GivenAUserNavigatesToHttpsOpensource_Demo_Orangehrmlive_Com()
        {
            addemployeePage.NavigateToWebsite();

        }

        [Given(@"the user enters admin username ""(.*)""")]
        public void GivenTheUserEntersAdminUsername(string AdminUserName)
        {
            addemployeePage.EnterAdminUsername(AdminUserName);
        }


        [Given(@"the user enters admin password ""(.*)""")]
        public void GivenTheUserEntersAdminPassword(string AdminPassword)
        {
            addemployeePage.EnterAdminPassword(AdminPassword);
        }


        [Given(@"the user clicks the log in button")]
        public void GivenTheUserClicksTheLogInButton()
        {
            addemployeePage.ClickLoginButton();
        }

        [Given(@"the user clicks on PIM")]
        public void GivenTheUserClicksOnPIM()
        {
            addemployeePage.ClickOnPimButton();
        }

        [Given(@"the user clicks on Add Employee")]
        public void GivenTheUserClicksOnAddEmployee()
        {
            Thread.Sleep(1000);
            addemployeePage.ClickAddEmployeeButton();
        }

        [Given(@"the user enters first name ""(.*)""")]
        public void GivenTheUserEntersFirstName(string Firstname)
        {
            addemployeePage.EnterFirstName(Firstname);
        }


        [Given(@"the user enters last name ""(.*)""")]
        public void GivenTheUserEntersLastName(string Lastname)
        {
            addemployeePage.EnterLastName(Lastname);
        }


        [Given(@"the user enters Employee number ""(.*)""")]
        public void GivenTheUserEntersEmployeeNumber(string Employeenumber)
        {
            addemployeePage.EnterEmployeeNumber(Employeenumber);
        }


        [Given(@"the user clicks on Choose file")]
        public void GivenTheUserClicksOnChooseFile()
        {
            addemployeePage.ClickChooseFile();
        }

        [Given(@"the user ticks the create Log in Details box")]
        public void GivenTheUserTicksTheCreateLogInDetailsBox()
        {
            addemployeePage.ClickCreateLoginDetailsBox();
        }


        [Given(@"the user enters username ""(.*)""")]
        public void GivenTheUserEntersUsername(string UserName)
        {
            addemployeePage.EnterUserName(UserName);
        }


        [Given(@"the user enters password ""(.*)""")]
        public void GivenTheUserEntersPassword(string Password)
        {
            addemployeePage.EnterPassword(Password);
        }


        [Given(@"the user confirms password ""(.*)""")]
        public void GivenTheUserConfirmsPassword(string Password1)
        {
            addemployeePage.ConfirmPassword(Password1);
        }


        [Given(@"the user selects the Enabled option for Status")]
        public void GivenTheUserSelectsTheEnabledOptionForStatus()
        {
            addemployeePage.EnabledOptionForStatus();

        }

        [Given(@"I click the save button")]
        public void GivenIClickTheSaveButton()
        {
            addemployeePage.ClickSaveButton();
        }


        [Given(@"I click on Leave")]
        public void GivenIClickOnLeave()
        {
            addemployeePage.ClickLeaveButton();
        }

        [Given(@"I click on Entitlement")]
        public void GivenIClickOnEntitlement()
        {
           addemployeePage.ClickOnEntitlementButton();
        }

        [Given(@"I clicks on Add Entitlement")]
        public void GivenIClicksOnAddEntitlement()
        {
            addemployeePage.SelectAddEntitlement();
        }

        [Given(@"I enter employee name ""(.*)""")]
        public void GivenIEnterEmployeeName(string Firstname)
        {
            addemployeePage.EnterEmployeeName(Firstname);
        }

        [Given(@"I select Leave type chosen")]
        public void GivenISelectLeaveTypeChosen()
        {
            addemployeePage.SelectLeaveTypeChosen();
        }


        [Given(@"I select Leave Period")]
        public void GivenISelectLeavePeriod()
        {
            addemployeePage.ClickLeavePeriod();
        }

        [Given(@"I enter number of days for entitlement ""(.*)""")]
        public void GivenIEnterNumberOfDaysForEntitlement(string Entitlement)
        {
            addemployeePage.EnterEntitlement(Entitlement);
        }

        [Given(@"I click on Save")]
        public void GivenIClickOnSave()
        {
            addemployeePage.ClickOnSaveButton();
        }

        [Given(@"I click confirm button")]
        public void GivenIClickConfirmButton()
        {
            addemployeePage.ClickConfirmButton();
        }

        [Given(@"I click on Profile name")]
        public void GivenIClickOnProfileName()
        {
            addemployeePage.ClickOnProfileName();
        }

        [When(@"I click on Log out")]
        public void WhenIClickOnLogOut()
        {
            addemployeePage.ClickLogOutButton();
        }

        [Then(@"I should be logged out to the login page")]
        public void ThenIShouldBeLoggedOutToTheLoginPage()
        {
            Assert.That(addemployeePage.IShouldBeLoggedOutToLoginPage);
        }


















    }
}

    

    

