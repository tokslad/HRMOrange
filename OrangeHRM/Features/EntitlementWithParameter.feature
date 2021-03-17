Feature: EntitlementWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Entitlement With Parameter
	Given I navigate to "https://opensource-demo.orangehrmlive.com/"
	And I enter Username "Admin"
	And I enter Password "admin123"
	And I click on Login
	And I click on PIM
	And I click on Add Employee
	And I enter First name "Modupe"
	And I enter Last name "Bashorun"
	And I enter Employee Id "1234"
	And I upload Choose file "\licence.jpg"
	And Check the box for create login detail
	And I enter employee username "Bimpe"
	And I enter employee password "Jawdan21"
	And I enter confirm password "Jawdan21"
	And I select Enabled
	When I click on save
	Then I should be able to add employee successfully