using NUnit.Framework;
using OrangeHRM.PageObject;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace OrangeHRM.StepDefinition
{
    [Binding]
    public class ApproveTimesheetSteps
    { 

        ApproveTimesheetPage approveTimesheetPage;

    public ApproveTimesheetSteps()
    {
        approveTimesheetPage = new ApproveTimesheetPage();
    }




        [Given(@"user navigates to ""(.*)""")]
        public void GivenUserNavigatesTo(string url)
        {
            approveTimesheetPage.NavigateToWebsite(url);
        }

        [Given(@"I enter admin username ""(.*)""")]
        public void GivenIEnterAdminUsername(string uname)
        {
            approveTimesheetPage.EnterUsername(uname);
        }
        
        [Given(@"I enter admin password ""(.*)""")]
        public void GivenIEnterAdminPassword(string pword)
        {
            approveTimesheetPage.EnterPassword(pword);
        }

        [Given(@"user clicks on Login")]
        public void GivenUserClicksOnLogin()
        {
            approveTimesheetPage.ClickOnAdminlogin();
        }


        [Given(@"user clicks on PIM")]
        public void GivenUserClicksOnPIM()
        {
            approveTimesheetPage.ClickOnPim();
        }


        [Given(@"i click on Add Employee")]
        public void GivenIClickOnAddEmployee()
        {
            Thread.Sleep(3000); 
            approveTimesheetPage.ClickOnAddemp();
        }
        
        [Given(@"I enter first name ""(.*)""")]
        public void GivenIEnterFirstName(string fname)
        {
            approveTimesheetPage.EnterFirstname(fname);
        }
        
        [Given(@"I enter last name ""(.*)""")]
        public void GivenIEnterLastName(string lname)
        {
            approveTimesheetPage.EnterLastname(lname);
        }


        [Given(@"I upload profile picture ""(.*)""")]
        public void GivenIUploadProfilePicture(string file)
        {
            Thread.Sleep(5000);
            approveTimesheetPage.ClickOnChooseFile(file);
            ScenarioContext.Current["file"] = file;
        }

        [Given(@"I check the box for create login details")]
        public void GivenICheckTheBoxForCreateLoginDetails()
        {
            approveTimesheetPage.ClickOnCheckbox();
        }
        
        [Given(@"I enter username ""(.*)""")]
        public void GivenIEnterUsername(string eusername)
        {
            approveTimesheetPage.EnterEmpusername(eusername);
        }
        
        [Given(@"I enter password ""(.*)""")]
        public void GivenIEnterPassword(string epassword)
        {
            approveTimesheetPage.EnterEmpassword(epassword);
        }
        
        [Given(@"I confirm password ""(.*)""")]
        public void GivenIConfirmPassword(string conpass)
        {
            approveTimesheetPage.EnterConfirm(conpass);
        }

        [When(@"user clicks the save button")]
        public void WhenUserClicksTheSaveButton()
        {
            approveTimesheetPage.ClickOnSave();
        }



        [Then(@"employee should be added successfully")]
        public void ThenEmployeeShouldBeAddedSuccessfully()
        {
            Thread.Sleep(3000);
            Assert.That(approveTimesheetPage.IsValidatenameDisplayed);
        }


        [When(@"I click on welcome")]
        public void WhenIClickOnWelcome()
        {
            Thread.Sleep(5000); 
            approveTimesheetPage.ClickOnWelcome();
        }

        [When(@"I click on logout")]
        public void WhenIClickOnLogout()
        {
            Thread.Sleep(5000); 
            approveTimesheetPage.ClickOnLogout();
        }

        [When(@"user enters employee username ""(.*)""")]
        public void WhenUserEntersEmployeeUsername(string eusername2)
        {
            approveTimesheetPage.EnterEmpusername2(eusername2);
        }

        [When(@"user enters employee password ""(.*)""")]
        public void WhenUserEntersEmployeePassword(string epassword2)
        {
            approveTimesheetPage.EnterEmpassword2(epassword2);
        }

        [When(@"user clicks on login")]
        public void WhenUserClicksOnLogin()
        {
            approveTimesheetPage.ClickOnUserlogin();
        }

        [When(@"user clicks on my timesheet")]
        public void WhenUserClicksOnMyTimesheet()
        {
            approveTimesheetPage.ClickOnTimesheet();
        }

        [When(@"user cliks on add timesheet")]
        public void WhenUserCliksOnAddTimesheet()
        {
            Thread.Sleep(4000);
            approveTimesheetPage.ClickOnAddtimesheet();
        }

        [When(@"user clicks on calendar")]
        public void WhenUserClicksOnCalendar()
        {
            Thread.Sleep(4000);
            approveTimesheetPage.ClickOnCalendar();
        }

        [When(@"user selects month")]
        public void WhenUserSelectsMonth()
        {
            Thread.Sleep(5000);
            approveTimesheetPage.SelectMonth();
        }


        [When(@"user selects a date in the past")]
        public void WhenUserSelectsADateInThePast()
        {
            Thread.Sleep(4000); 
            approveTimesheetPage.ClickOnDate();
        }


        [When(@"user clicks okay")]
        public void WhenUserClicksOkay()
        {
            Thread.Sleep(2000); 
            approveTimesheetPage.ClickOnOkay();
        }

        [When(@"user clicks on edit")]
        public void WhenUserClicksOnEdit()
        {
            Thread.Sleep(5000);
            approveTimesheetPage.ClickOnEdit();
        }

        [When(@"user clicks on projectbox")]
        public void WhenUserClicksOnProjectbox()
        {
            Thread.Sleep(5000);
            approveTimesheetPage.ClickOnProjectbox();
        }


        [When(@"user enters project name ""(.*)""")]
        public void WhenUserEntersProjectName(string project)
        {
            approveTimesheetPage.EnterProjectname(project);
        }

        [When(@"user selects project name")]
        public void WhenUserSelectsProjectName()
        {
            Thread.Sleep(3000);
            approveTimesheetPage.ClickOnProjectname2();
        }

        [When(@"user selects activity name")]
        public void WhenUserSelectsActivityName()
        {
            Thread.Sleep(3000);
            approveTimesheetPage.SelectActivity();
        }

        [When(@"user enters monday hours ""(.*)""")]
        public void WhenUserEntersMondayHours(string mday)
        {
            approveTimesheetPage.EnterMonday(mday);
        }

        [When(@"user enters tuesday hours ""(.*)""")]
        public void WhenUserEntersTuesdayHours(string tday)
        {
          approveTimesheetPage.EnterTuesday(tday);
        }

        [When(@"user enters wednesday hours ""(.*)""")]
        public void WhenUserEntersWednesdayHours(string wday)
        {
            approveTimesheetPage.EnterWednesday(wday);
        }

        [When(@"user enters thursday hours ""(.*)""")]
        public void WhenUserEntersThursdayHours(string thday)
        {
            approveTimesheetPage.EnterThursday(thday);
        }

        [When(@"user enters friday hours ""(.*)""")]
        public void WhenUserEntersFridayHours(string fday)
        {
            approveTimesheetPage.EnterFriday(fday);
        }

        [When(@"user clicks on save")]
        public void WhenUserClicksOnSave()
        {
            approveTimesheetPage.ClickOnSavetime();
        }

        [When(@"user clicks on submit")]
        public void WhenUserClicksOnSubmit()
        {
            Thread.Sleep(3000);
            approveTimesheetPage.ClickOnSubmit();
        }

        [Then(@"timesheet should be submitted successfully")]
        public void ThenTimesheetShouldBeSubmittedSuccessfully()
        {
            Assert.That(approveTimesheetPage.IsValidateTimesheetDisplayed);
        }


        [When(@"I enter admin username ""(.*)""")]
        public void WhenIEnterAdminUsername(string uname2)
        {
            approveTimesheetPage.EnterUsername2(uname2);
        }

        [When(@"I enter admin password ""(.*)""")]
        public void WhenIEnterAdminPassword(string pword2)
        {
            approveTimesheetPage.EnterPassword2(pword2);
        }

        [When(@"I click on Login")]
        public void WhenIClickOnLogin()
        {
            approveTimesheetPage.ClickOnAdminlogin2();
        }

        [When(@"I click on time")]
        public void WhenIClickOnTime()
        {
            Thread.Sleep(4000);
            approveTimesheetPage.ClickOnTime();
        }


        [When(@"I click on timesheet")]
        public void WhenIClickOnTimesheet()
        {
            approveTimesheetPage.ClickOnTimesheet2();
        }

        [When(@"I select employee timesheets")]
        public void WhenISelectEmployeeTimesheets()
        {
            approveTimesheetPage.ClickOnEmptimesheet();
        }

        [When(@"I click employee name textbox")]
        public void WhenIClickEmployeeNameTextbox()
        {
            approveTimesheetPage.ClickOnNamebox();
        }

        [When(@"I type employee name ""(.*)""")]
        public void WhenITypeEmployeeName(string ename)
        {
            approveTimesheetPage.EnterEmpname(ename);
        }

        [When(@"I click on view")]
        public void WhenIClickOnView()
        {
            approveTimesheetPage.ClickOnView();
        }

        [When(@"i select timesheet date")]
        public void WhenISelectTimesheetDate()
        {
            approveTimesheetPage.SelectDateRange();
        }


        [When(@"I click on approve")]
        public void WhenIClickOnApprove()
        {
            Thread.Sleep(5000);
            approveTimesheetPage.ClickOnApprove();
        }

        [Then(@"timesheet should be approved successfully")]
        public void ThenTimesheetShouldBeApprovedSuccessfully()
        {
            Assert.That(approveTimesheetPage.IsApproveTimeDisplayed);
        }

        [When(@"admin clicks on PIM")]
        public void WhenAdminClicksOnPIM()
        {
            approveTimesheetPage.ClickOnPim();
        }

        [When(@"admin clicks on employee list")]
        public void WhenAdminClicksOnEmployeeList()
        {
            Thread.Sleep(3000); 
            approveTimesheetPage.ClickOnEmployeeList();
        }

        [When(@"admin clicks on employee name box")]
        public void WhenAdminClicksOnEmployeeNameBox()
        {
            Thread.Sleep(3000);
            approveTimesheetPage.ClickOnEmployeeBox();
        }

        [When(@"admin enters employee name ""(.*)""")]
        public void WhenAdminEntersEmployeeName(string Employeename)
        {
            Thread.Sleep(3000);
            approveTimesheetPage.EnterEmployeeName(Employeename);
        }

        [When(@"admin clicks on search")]
        public void WhenAdminClicksOnSearch()
        {
            Thread.Sleep(3000); 
            approveTimesheetPage.ClickOnSearch();
        }

        [When(@"admin selects employee")]
        public void WhenAdminSelectsEmployee()
        {
            Thread.Sleep(3000); 
            approveTimesheetPage.ClickOnCheckEmployee();
        }

        [When(@"admin clicks on delete")]
        public void WhenAdminClicksOnDelete()
        {
            Thread.Sleep(3000); 
            approveTimesheetPage.ClickOnDelete();
        }

        [When(@"admin clicks on ok")]
        public void WhenAdminClicksOnOk()
        {
            Thread.Sleep(3000);
            approveTimesheetPage.ClickOnOk();
        }







    }
}
