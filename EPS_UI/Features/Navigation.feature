Feature: Navigation

@mytag
Scenario: Navigation - Test Runner
	Given I am on the Endpoint homepage
	When I select Test Runner
	Then I am taken to the test runner page

Scenario: Navigation - Manage
	Given I am on the Endpoint homepage
	When I select Manage
	Then the manage options are expanded

Scenario: Navigateion - Reporting
	Given I am on the Endpoint homepage
	When I select Reporting
	Then the reporting options are expanded


