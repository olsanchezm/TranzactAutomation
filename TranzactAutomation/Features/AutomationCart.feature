Feature: AutomationCart

@TEST
Scenario: Create user and buy 3 products
	Given User open website and is sent to login
	When User access to register page
	And User creates an account and logs in 
	Then add random products to cart
	And User check cart
	Then User starts checkout
	And User fill shipping information
	Then  User pay order
