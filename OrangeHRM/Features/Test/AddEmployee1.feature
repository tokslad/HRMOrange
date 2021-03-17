Feature: Add Employee
	In order to add employee 
	I need to first register

@mytag
Scenario: Add Employee
	Given a user nagivate to the website
	And user enter the username
	And user enter the password
	When user click on login
	And user click on PIM
	And user click on add employee
	And user enter the firstname
	And user enter the middlename
	And user enter the surname
	And user enter employee number
	And user click on choose file "\man.jpg"
	When user check the box for create login details
	And user enter the username 
	And user enter the password
	And user enter confirm password
	And user select enabled for status 
	And user click on save
	And user confirm
	Then the result should be 120