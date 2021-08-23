Feature: AddShareSkill
	Simple calculator for adding two numbers

@AddShareSkill
Scenario: Add Share Skill - Skill Exchange - Active
	Given User is logged in to Share Skill
	When Add Share Skill with Skill Exhcange
	And Select Share Skill as Active
	Then Active Share SKill details should be saved 
	And Share Skill should be Skill Exchange
@AddShareSkill
Scenario: Add Share Skill - Skill Exchange - Hide
	Given User is logged in to Share Skill
	When Add Share Skill with Skill Exhcange
	And Select Share Skill as Hide
	Then Share SKill details should be Hidden 
	And Share Skill should be Skill Exchange
@AddShareSkill
Scenario: Add Share Skill - Credit - Active
	Given User is logged in to Share Skill
		When Add Share Skill with Credit
	And Select Share Skill as Active
	Then Active Share SKill details should be saved 
	And Share Skill should be Credit
@AddShareSkill
Scenario: Add Share Skill - Credit - Hide
	Given User is logged in to Share Skill
	When Add Share Skill with Credit
	And Select Share Skill as Hide
	Then Share SKill details should be Hidden 
	And Share Skill should be Credit