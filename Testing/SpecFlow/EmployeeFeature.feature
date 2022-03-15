Feature: EmployeeFeature

I would like to login to the TurnUp portal and go to employee home page and create new employee recorde and do editing to the newly created record and delete the record

@tag1
Scenario: Creating Employee record with valid data
	Given I have successfully login to the TurnUp portal with valid credentials
	And I navigated to the Employee home page
	When I was creating new Emplyee record with vallid data
	Then I could create it successfully



	Scenario Outline: Editting the Created Employee record with valid credentials
	Given I have successfully login to the TurnUp portal with valid credentials
	And I navigated to the Employee home page
	When I updated the '<Name>' on Employees page
	Then I could edit the '<Name>' employee record

	Examples: 

	| Name  |
	| Red   |
	| Green |
	| Blue  |



