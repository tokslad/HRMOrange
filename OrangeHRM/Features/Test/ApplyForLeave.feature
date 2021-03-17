Feature: Apply for Leave
	Add employee & employee entitlement

@mytag
Scenario: Add Employee
	Given a user navigates to https://opensource-demo.orangehrmlive.com/
	And the user enters admin username "Admin"
	And the user enters admin password "admin123"
	And the user clicks the log in button
	And the user clicks on PIM
	And the user clicks on Add Employee
	And the user enters first name "Boris"
	And the user enters last name "Johnson"
	And the user enters Employee number "1"
	#And the user clicks on Choose file
	And the user ticks the create Log in Details box
	And the user enters username "BorisJohnson"
	And the user enters password "EnglishPM20"
	And the user confirms password "EnglishPM20"
	And the user selects the Enabled option for Status
	And I click the save button
	And I click on Leave
	And I click on Entitlement
	And I clicks on Add Entitlement
	And I enter employee name "Boris"
	And I select Leave type chosen
	And I select Leave Period
	And I enter number of days for entitlement "26"
	And I click on Save
	And I click confirm button
	And I click on Profile name
	When I click on Log out
	Then I should be logged out to the login page
	




	
	
	

	
	
	


	

