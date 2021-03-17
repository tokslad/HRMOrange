using OrangeHRM.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class EntitlementWithParameterSteps
    {
        EntitlementWithParameterPage entitlementWithParameterPage;



        public EntitlementWithParameterSteps()
        {
            entitlementWithParameterPage = new EntitlementWithParameterPage();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            entitlementWithParameterPage.NavigateToWebsite(url);
        }
        [Given(@"I enter Username ""(.*)""")]
        public void GivenIEnterUsername(string Username)
        {
            entitlementWithParameterPage.EnterUsername(Username);
        
        }

        [Given(@"I enter Password ""(.*)""")]
        public void GivenIEnterPassword(string admin123)
        {
            entitlementWithParameterPage.EnterPasword(admin123);
        
        }
        
        [Given(@"I click on Login")]
        public void GivenIClickOnLogin()
        {
            entitlementWithParameterPage.clickonLogin();
        }
        
        [Given(@"I click on PIM")]
        public void GivenIClickOnPIM()
        {
            entitlementWithParameterPage.clickonPIM();
        }
        
        [Given(@"I click on Add Employee")]
        public void GivenIClickOnAddEmployee()
        {
            Thread.Sleep(5000);
            entitlementWithParameterPage.clickonAddEmployee();
        }
        
        [Given(@"I enter First name ""(.*)""")]
        public void GivenIEnterFirstName(string firstname)
        {
            entitlementWithParameterPage.enterFirstname(firstname);
        }
        
        [Given(@"I enter Last name ""(.*)""")]
        public void GivenIEnterLastName(string lastname)
        {
            entitlementWithParameterPage.enterLastname(lastname);
        }
        
        [Given(@"I enter Employee Id ""(.*)""")]
        public void GivenIEnterEmployeeId(string number)
        {
            entitlementWithParameterPage.enterEmployeeId(number);
        }

        [Given(@"I upload Choose file ""(.*)""")]
        public void GivenIUploadChooseFile(string file)
        {
            Thread.Sleep(5000);
            entitlementWithParameterPage.ClickonchooseFile(file);
            ScenarioContext.Current["file"] = file;


        }

        
        [Given(@"Check the box for create login detail")]
        public void GivenCheckTheBoxForCreateLoginDetail()
        {
            entitlementWithParameterPage.ClickOnCheckBox();
        }
        [Given(@"I enter employee username ""(.*)""")]
        public void GivenIEnterEmployeeUsername(string username)
        {
            entitlementWithParameterPage.enterEmployeeUsername(username);
        
        }

        [Given(@"I enter employee password ""(.*)""")]
        public void GivenIEnterEmployeePassword(string employeepasword)
        {
            entitlementWithParameterPage.enterEmployeePassword(employeepasword);
        
        }

        
        [Given(@"I enter confirm password ""(.*)""")]
        public void GivenIEnterConfirmPassword(string confirmpassword)
        {
            entitlementWithParameterPage.enterConfirmPassword(confirmpassword);
        }


        
        [Given(@"I select Enabled")]
        public void GivenISelectEnabled()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on save")]
        public void WhenIClickOnSave()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be able to add employee successfully")]
        public void ThenIShouldBeAbleToAddEmployeeSuccessfully()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
