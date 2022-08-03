Feature: CreateAccount
	Create amazon account

	 @mytag
	 @DataSource:CustomerDetails.xlsx
Scenario: Create second account of amazon using excel
	Given Navigate to amazon url
	When Click on the sign in link
	Then user should be able to view the sign in text
	Then Navigate to create account page
	Then user provide the <Full Name> full name of customer
	Then user provide the email using <Full Name> in correct format	
	Then user provide the <Mobile> mobile number of customer
	Then user provide the <Password> password for customer
	And user click on create button
