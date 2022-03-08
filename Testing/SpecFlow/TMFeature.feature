Feature: TMFeature

I would like to login into TurnUp portal and create Time and Material page and do edit and delete the page


Scenario: Create Time and Material Record with valid data
	Given Loging into the Time and Material Page
	And  navigating through Time and Material page
	When I created Time and Material page
	Then The Record should be created
