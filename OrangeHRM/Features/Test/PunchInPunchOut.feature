Feature: PunchInPunchOut
	punch in and punch out as newly created employee

@mytag
Scenario: PunchIn PunchOut
	Given i navigate to Website https://opensource-demo.orangehrmlive.com/
	And i enter new employee username "BorisJohnson"
	And i enter new employee password "EnglishPM20"
	And i click on login button
	And i click on Time
	And i click on Attendance
	And i click on PunchIn/PunchOut
	And i enter Note "Boris is able to punch in and out"
	When i click on In
	Then i should be checked in
	When i click on Out
	Then confirm i have checked out