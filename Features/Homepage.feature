Feature: Homepage
	Homepage for amazon

	Background:
	Given Navigate to amazon url

	@Tag1
Scenario Outline: Search for different items 	
	When Search for a text <Search Text>
	Then user click on the Search button
	And user should be able to see the reuslts for the  <Search Text>

	Examples: 
	| Search Text |
	| Badminton   |
	| Mobile      |
	| Wardrobe    |
	| Clothes     |
	| Toys        |
	| Camera      |
	| jewellery   |
	| Laptop      |
	| Basketball  |


	@Tag2
Scenario: Navigate through all the values present in Search dropdown
	Then user should be able to select each value present in search dropdown

	@Tag2
Scenario: Navigate to Amazon Pay and verify it contains the various optins or not
	Given amazon homepage toolbar contains the following values 
	| Toolbar Values  |
	| Best Sellers    |
	| Today's Deals   |
	| Mobiles         |
	| Customer Service|
	| Books           |
	| Electronics     |
	| Amazon Pay      |
	When user click on AmazonPay 
	Then user should see be able the following header values
	| Header Values  |
	| Recharges, Bill Payments    |
	| Travel and insurance    |
	| Rewards         |
	| Gift Cards & Vouchers |
	
	
	
	
