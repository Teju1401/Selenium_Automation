Feature: TMFeature

I would like to login into TurnUp portal and create Time and Material page and do edit and delete the page


Scenario: Create Time and Material Record with valid data
	Given I Logged into turnup portal successfully
	And  I navigate through TIme and Material page
	When I create Time and Material page
	Then The Record should be created successfully


	Scenario Outline: Edit Time and Material Record with valid data
	Given I Logged into turnup portal successfully
	And  I navigate through TIme and Material page
	When I update '<Description>'on an Time and Material page
	Then The Record should have the updateed '<Description>'

	Examples: 
	| Description |
	| Feb2022     |
	| Months      |
	| Years       |