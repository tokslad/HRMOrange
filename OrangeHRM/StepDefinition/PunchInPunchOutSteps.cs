using NUnit.Framework;
using OrangeHRM.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class PunchInPunchOutSteps
    {
        PunchInPunchOutPage punchInPunchOutPage;

        public PunchInPunchOutSteps()
        {
            punchInPunchOutPage = new PunchInPunchOutPage();
        }






        [Given(@"i navigate to Website https://opensource-demo\.orangehrmlive\.com/")]
        public void GivenINavigateToWebsiteHttpsOpensource_Demo_Orangehrmlive_Com()
        {
            punchInPunchOutPage.NavigateToWebsite();
        }



        [Given(@"i enter new employee username ""(.*)""")]
        public void GivenIEnterNewEmployeeUsername(string EmployeeUsername)
        {
            punchInPunchOutPage.EmployeeUsername(EmployeeUsername);
        }

        [Given(@"i enter new employee password ""(.*)""")]
        public void GivenIEnterNewEmployeePassword(string EmployeePassword)
        {
            punchInPunchOutPage.EnterEmployeePassword(EmployeePassword);
        }


        [Given(@"i click on login button")]
        public void GivenIClickOnLoginButton()
        {
            punchInPunchOutPage.ClickLoginButton();
        }
        
        [Given(@"i click on Time")]
        public void GivenIClickOnTime()
        {
            punchInPunchOutPage.ClickTimeButton();
        }
        
        [Given(@"i click on Attendance")]
        public void GivenIClickOnAttendance()
        {
            punchInPunchOutPage.ClickAttendanceButton();
        }
        
        [Given(@"i click on PunchIn/PunchOut")]
        public void GivenIClickOnPunchInPunchOut()
        {
            punchInPunchOutPage.SelectPunchInandOut();
        }

        [Given(@"i enter Note ""(.*)""")]
        public void GivenIEnterNote(string Note)
        {
            punchInPunchOutPage.EnterNote(Note);
        }


        [When(@"i click on In")]
        public void WhenIClickOnIn()
        {
            punchInPunchOutPage.ClickIn();

        }

        [Then(@"i should be checked in")]
        public void ThenIShouldBeCheckedIn()
        {
            Assert.That(punchInPunchOutPage.IsEmployeeCheckedIn);
        }

        [When(@"i click on Out")]
        public void WhenIClickOnOut()
        {
            punchInPunchOutPage.ClickOut();
        }

        [Then(@"confirm i have checked out")]
        public void ThenConfirmIHaveCheckedOut()
        {
            Assert.That(punchInPunchOutPage.IsEmployeeCheckedOut);
        }













    }
}
