Feature: Login

@smoke
Scenario: Test login functionality of EA APP
	Given I navigate to EA App
	When I click login button
	Then I enter username and password
