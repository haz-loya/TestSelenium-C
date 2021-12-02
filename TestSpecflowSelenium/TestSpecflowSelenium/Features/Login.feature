Feature: Login

@Login
Scenario: User tries to create a new facebook account without email
	Given User navigates to Facebook using "Chrome"
	Given User clicks on "Create new account" button
	And User adds the following new user data:
	| FirstName | LastName | Email | Birthday    | Gender |
	| Jorge     | Sanchez  |       | Jul/12/1986 | Male   |
	When User clicks on "Sign Up" button
	Then User validates Warining sign on "" textbox
