Feature:Education

Seller is able to add Education to profile page

@mytag
Scenario Outline: Add Education to Profile
	Given Navigate to Education tab
	When I add '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' to Education tab
	Then The '<Country>' and '<University>' and '<Title>' and '<Degree>' and '<Year>' should be created successfully.

Examples: 
	| Country | University| Title  | Degree                         | Year |
	| India   | UC        | B.Tech | Computer Science Engineering   | 2016 |
	