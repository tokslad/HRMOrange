using NUnit.Framework;
using OrangeHRM.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class LeaveApplicationSteps
    {
        LeaveApplicationPage leaveApplicationPage;

        public LeaveApplicationSteps()
        {
            leaveApplicationPage = new LeaveApplicationPage();
        }


        [Given(@"the user navigates to https://opensource-demo\.orangehrmlive\.com/")]
        public void GivenTheUserNavigatesToHttpsOpensource_Demo_Orangehrmlive_Com()
        {
            leaveApplicationPage.NavigateToWebsite();
        }
        
        [Given(@"if user enters username ""(.*)""")]
        public void GivenIfUserEntersUsername(string UserName)
        {
            leaveApplicationPage.UserEntersName(UserName);
        }
        
        [Given(@"if user enters password ""(.*)""")]
        public void GivenIfUserEntersPassword(string Password)
        {
            leaveApplicationPage.EnterMyPassword(Password);
        }
        
        [Given(@"if user clicks the log in button")]
        public void GivenIfUserClicksTheLogInButton()
        {
            leaveApplicationPage.ClickOnLoginButton();
        }
        
        [Given(@"if user clicks on Leave")]
        public void GivenIfUserClicksOnLeave()
        {
            leaveApplicationPage.ClickLeaveButton();
        }
        
        [Given(@"the user click on apply")]
        public void GivenTheUserClickOnApply()
        {
            leaveApplicationPage.ClickApply();
        }
        
        [Given(@"if user selects Leave type")]
        public void GivenIfUserSelectsLeaveType()
        {
            leaveApplicationPage.SelectLeaveType();
        }
        
        [Given(@"the user selects from date")]
        public void GivenTheUserSelectsFromDate()
        {
            leaveApplicationPage.SelectFromDate();
        }
        
        [Given(@"the user selects to date")]
        public void GivenTheUserSelectsToDate()
        {
            leaveApplicationPage.SelectToDate();
        }
        
        [Given(@"the user selects partial days")]
        public void GivenTheUserSelectsPartialDays()
        {
            leaveApplicationPage.ClickPartialDays();
        }
        
        [Given(@"the user writes a comment ""(.*)""")]
        public void GivenTheUserWritesAComment(string TaskCompleted)
        {
            leaveApplicationPage.LeaveComment(TaskCompleted);
        }
        
        [Given(@"the user clicks on apply")]
        public void GivenTheUserClicksOnApply()
        {
            leaveApplicationPage.ClickOnApply();
        }
        
        [Given(@"if user clicks on Profile name")]
        public void GivenIfUserClicksOnProfileName()
        {
            leaveApplicationPage.ClickOnProfileName();
        }
        
        [When(@"the user clicks on Log out")]
        public void WhenTheUserClicksOnLogOut()
        {
            leaveApplicationPage.ClickLogOutButton();
        }
        
        [Then(@"the user should be logged out to the login page")]
        public void ThenTheUserShouldBeLoggedOutToTheLoginPage()
        {
            Assert.That(leaveApplicationPage.IsLogInPageDisplayed);
        }
    }
}
