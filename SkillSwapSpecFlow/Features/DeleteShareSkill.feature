Feature: DeleteShareSkill
	Simple calculator for adding two numbers

@DeleteShareSkill
Scenario: Delete Share Skill 
	Given User is logged in to Skill Swap
	When Delete Share Skill 
	Then Share SKill details should be Deleted 