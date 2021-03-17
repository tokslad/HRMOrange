Feature: TotalHoursWorked
	In order for employee to see the total number of hours worked
	Employee first needs to be registered by admin 
	Then employee can punch in and punch out

@mytag
Scenario: Add Employee
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



Scenario: Employee Punch In
	Given I navigate to "https://opensource-demo.orangehrmlive.com/index.php/auth/login"
	When user enters employee username "Lennywilly"
	And user enters employee password "Lenny2021"
	And user clicks on login
	And user clicks on time 
	And user clicks on attendance
	And user clicks on punch in or out
	And user clicks on the calendar icon
	And user selects month
	And user enters date
	And user enters time "12:00"
	And user enters note "Punch In"
	And user clicks on in
	And user click on the calendar icon
	And user selects month
	And user enters the punch out date
	And user enters out time "20:00"
	And user enters out note "Punch out"
	When user clicks on out
	Then data should be saved successfully




Scenario: Total Hours Worked
	Given I navigate to "https://opensource-demo.orangehrmlive.com/index.php/auth/login"
	When user enters employee username "Lennywilly"
	And user enters employee password "Lenny2021"
	And user clicks on login
	And user clicks on time 
	And user clicks on attendance
	And user clicks on my records 
	And user clicks the calendar
	And user selects month
	When user selects a date from calendar
	Then user should see total number of hours worked 







	