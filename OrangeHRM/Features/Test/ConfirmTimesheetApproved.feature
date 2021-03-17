Feature: ConfirmTimesheetApproved
	In order to confirm timesheet, first admin needs to add employee
	Then employee needs to create a timesheen, then admin must approve timesheet

@mytag
Scenario: Approve Timesheet
	Given I navigate to "https://opensource-demo.orangehrmlive.com/index.php/auth/login"
	And I enter admin username "Admin"
	And I enter admin password "admin123"
	And I click on Login
	And I click on PIM
	And i click on Add Employee
	And I enter first name "Lenora"
	And I enter last name "Williams"
	And I upload profile picture "\man.jpg"
	And I check the box for create login details 
	And I enter username "Lennywilly"
	And I enter password "Lenny2021"
	And I confirm password "Lenny2021"
	When I click on save
	Then employee should be added successfully
	When I click on welcome
	And I click on logout
	And user enters employee username "Lennywilly"
	And user enters employee password "Lenny2021"
	And user clicks on login
	And user clicks on my timesheet
	And user cliks on add timesheet
	And user clicks on calendar
	And user selects month
	And user selects a date in the past 
	And user clicks okay
	And user clicks on edit
	And user clicks on projectbox
	And user enters project name "Glo"
	And user selects project name 
	And user selects activity name 
	And user enters monday hours "8"
	And user enters tuesday hours "8"
	And user enters wednesday hours "8"
	And user enters thursday hours "8"
	And user enters friday hours "8"
	And user clicks on save 
	When user clicks on submit
	Then timesheet should be submitted successfully
	When I click on welcome
	And I click on logout
	And I enter admin username "Admin"
	And I enter admin password "admin123"
	And I click on Login
	And I click on time
	And I click on timesheet 
	And I select employee timesheets
	And I click employee name textbox
	And I type employee name "Lenora Williams"
	And I click on view 
	And i select timesheet date
	When I click on approve 
	Then timesheet should be approved successfully

	Scenario: Confirm Timesheet Approval
	Given I navigate to "https://opensource-demo.orangehrmlive.com/index.php/auth/login"
	When user enters employee username "Lennywilly"
	And user enters employee password "Lenny2021"
	And user clicks on login
	And user clicks on time
	And user clicks on timesheet
	And user clicks on my timesheets
	When user selects date
	Then user should be able to confirm status of timesheet