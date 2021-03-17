using NUnit.Framework;
using OrangeHRM.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class ConfirmTimesheetApprovedSteps
    {
        ConfirmTimesheetApprovedPage confirmTimesheetApprovedpage;

        public ConfirmTimesheetApprovedSteps()
        {
            confirmTimesheetApprovedpage = new ConfirmTimesheetApprovedPage();
        }




        [When(@"user clicks on timesheet")]
        public void WhenUserClicksOnTimesheet()
        {
            confirmTimesheetApprovedpage.ClickOnEmptimesheet();
            
        }
        
        [When(@"user clicks on my timesheets")]
        public void WhenUserClicksOnMyTimesheets()
        {
            confirmTimesheetApprovedpage.ClickOnEmptimesheet();
        }

        [When(@"user selects date")]
        public void WhenUserSelectsDate()
        {
            Thread.Sleep(2000);
            confirmTimesheetApprovedpage.SelectTimesheetDate();
        }


        [Then(@"user should be able to confirm status of timesheet")]
        public void ThenUserShouldBeAbleToConfirmStatusOfTimesheet()
        {
            Thread.Sleep(4000);
            Assert.That(confirmTimesheetApprovedpage.IsStatusDisplayed);
        }


    }
}
