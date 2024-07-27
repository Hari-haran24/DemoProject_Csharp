Feature: I want to shop and purchase items from Ajio application

A short summary of the feature

Scenario: Selecting a jeans and added to cart and checkout it
	Given user must launch the Url 
	When user select the Mens for selecting items
	And user click the men in gender
	And user click the jeans in  category
	And user selecting U.S polo jean
	And user must click  size
	And user move on the selected jean in added to Bag
	And user click go to bag
	And user click proceded to shipping for proceding the item
	Then user enter the mobile number
