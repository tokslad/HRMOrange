Feature: Leave Application
Login to apply for leave

@mytag
Scenario: Apply for Leave
	Given the user navigates to https://opensource-demo.orangehrmlive.com/
	And if user enters username "BorisJohnson"
	And if user enters password "EnglishPM20"
	And if user clicks the log in button
	And if user clicks on Leave
	And the user click on apply
	And if user selects Leave type
	And the user selects from date
	And the user selects to date
	And the user selects partial days
	And the user writes a comment "I have completed my task"
	And the user clicks on apply
	And if user clicks on Profile name
	When the user clicks on Log out
	Then the user should be logged out to the login page



















