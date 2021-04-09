Feature: NewUser
	AS a user on Giftrete website (www.giftrete.com)
I want to register with my details
So that I can have a registered account


@CreateAnAccountAsNewUser
Scenario: Create an account
	Given that I am a user on Giftrete website ( www.giftrete.com)
	And User click on create account button
	And User enter email address
	And User enter first name
	And User enter last name
	And User enter phone number
	And User enter password
	And User re-enter password to confirm password
	When User click on register now!
	Then User must be successfully registered               