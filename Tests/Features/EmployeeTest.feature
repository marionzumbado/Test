Feature: EmployeeTest

@mytag
Scenario: As an Admin I can Log In
	Given I am in Log In page
	And I have entered Username and Password
	| UserName | Password |
	| Admin    | Admin    |
	When I press Log In
	Then I am authenticated
