using NUnit.Framework;
using OrangeHRM.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class TotalHoursWorkedSteps
    {

        TotalHoursWorkedPage totalHoursWorkedPage;

        public TotalHoursWorkedSteps()
        {
            totalHoursWorkedPage = new TotalHoursWorkedPage();
        }


        [When(@"user clicks on time")]
        public void WhenUserClicksOnTime()
        {
            totalHoursWorkedPage.ClickOnTime();
        }
        
        [When(@"user clicks on attendance")]
        public void WhenUserClicksOnAttendance()
        {
            totalHoursWorkedPage.ClickOnAttendance();
        }
        
        [When(@"user clicks on punch in or out")]
        public void WhenUserClicksOnPunchInOrOut()
        {
            totalHoursWorkedPage.ClickOnPunch();
        }

        [When(@"user clicks on the calendar icon")]
        public void WhenUserClicksOnTheCalendarIcon()
        {
            totalHoursWorkedPage.ClickOnCalendarIcon();
        }

        [When(@"user enters date")]
        public void WhenUserEntersDate()
        {
            Thread.Sleep(4000);
            totalHoursWorkedPage.ClickOnIndate();
        }


        [When(@"user enters time ""(.*)""")]
        public void WhenUserEntersTime(string Intime)
        {
            Thread.Sleep(2000);
            totalHoursWorkedPage.EnterIntime(Intime);
        }
        
        [When(@"user enters note ""(.*)""")]
        public void WhenUserEntersNote(string Note)
        {
            Thread.Sleep(2000);
            totalHoursWorkedPage.EnterNote(Note);
        }
        
        [When(@"user clicks on in")]
        public void WhenUserClicksOnIn()
        {
            Thread.Sleep(2000);
            totalHoursWorkedPage.ClickOnInbutton();
        }

        [When(@"user click on the calendar icon")]
        public void WhenUserClickOnTheCalendarIcon()
        {
            totalHoursWorkedPage.ClickOnCalendarIcon2();
        }

        [When(@"user enters the punch out date")]
        public void WhenUserEntersThePunchOutDate()
        {
            Thread.Sleep(4000);
            totalHoursWorkedPage.ClickOnOutdate();
        }


        [When(@"user enters out time ""(.*)""")]
        public void WhenUserEntersOutTime(string Outtime)
        {
            Thread.Sleep(2000);
            totalHoursWorkedPage.EnterOuttime(Outtime);
        }

        [When(@"user enters out note ""(.*)""")]
        public void WhenUserEntersOutNote(string Note2)
        {
            Thread.Sleep(2000);
            totalHoursWorkedPage.EnterNote2(Note2);
        }


        [When(@"user clicks on out")]
        public void WhenUserClicksOnOut()
        {
            Thread.Sleep(2000);
            totalHoursWorkedPage.ClickOnOutbutton();
        }
        
        [When(@"user clicks on my records")]
        public void WhenUserClicksOnMyRecords()
        {
            totalHoursWorkedPage.ClickOnRecords();
        }
        
        [When(@"user clicks the calendar")]
        public void WhenUserClicksTheCalendar()
        {
            totalHoursWorkedPage.ClickOnDatepicker();
        }

        [When(@"user selects a date from calendar")]
        public void WhenUserSelectsADateFromCalendar()
        {
            totalHoursWorkedPage.ClickOnDate2();
        }


        [Then(@"data should be saved successfully")]
        public void ThenDataShouldBeSavedSuccessfully()
        {
            Thread.Sleep(3000);
            Assert.That(totalHoursWorkedPage.IsInDisplayed);
        }
        
        [Then(@"user should see total number of hours worked")]
        public void ThenUserShouldSeeTotalNumberOfHoursWorked()
        {
            Thread.Sleep(3000);
            Assert.That(totalHoursWorkedPage.IsValidatePunchDisplayed);
        }
    }
}
