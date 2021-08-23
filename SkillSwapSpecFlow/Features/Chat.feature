Feature: ChatHistory
	Simple calculator for adding two numbers

@Chat
Scenario: Validate Chat History
	Given User Logged in to Share Skill
	When Clicked on Chat History
	Then Chat History should be displayed