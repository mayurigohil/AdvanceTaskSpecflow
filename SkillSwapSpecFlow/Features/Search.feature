Feature: Search
	Simple calculator for adding two numbers

@Search
Scenario: Validate Search Functionality using Category
	Given User logs in to ShareSkill
	Then Enter Search Category & Category data is loaded

@Search
Scenario: Validate Search Functionality using SubCategory
	Given User logs in to ShareSkill
	Then Enter Search SubCategory & SubCategory data is loaded