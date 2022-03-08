Feature: Login
	As a seller I want to login to the skillswap website

@mytag
Scenario Outline: I Login to the Skillswap website with valid credentials
	Given I logged in to the skillswap website using my '<Email>' and '<Password>' successfully
	Examples: 
	| Email                    | Password        |
	| reemarobin1993@gmail.com | Marsproject143@ |