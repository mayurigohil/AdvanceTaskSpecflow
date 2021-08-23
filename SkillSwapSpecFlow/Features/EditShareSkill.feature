Feature: EditShareSkill
	Simple calculator for adding two numbers

@EditShareSkill
Scenario: Edit Share Skill - Skill Exchange - Active
	Given User is logged in to ShareSkill
	When Edit Share Skill with Skill Exhcange
	And Update Share Skill as Active
	Then Active Share SKill details should be Updated 
	And Share Skill should be Updated to Skill Exchange

@EditShareSkill
Scenario: Edit Share Skill - Skill Exchange - Hide
	Given User is logged in to ShareSkill
	When Edit Share Skill with Skill Exhcange
	And Update Share Skill as Hidden
	Then Share SKill details should be Updated as Hidden 
	And Share Skill should be Updated to Skill Exchange
@EditShareSkill
Scenario: Edit Share Skill - Credit - Active
	Given User is logged in to ShareSkill
	When Edit Share Skill with Credit
	And Update Share Skill as Active
	Then Active Share SKill details should be Updated 
	And Share Skill should be Updated to Credit
@EditShareSkill
Scenario: Edit Share Skill - Credit - Hide
	Given User is logged in to ShareSkill
	When Edit Share Skill with Credit
	And Update Share Skill as Hidden
	Then Share SKill details should be Updated as Hidden 
	And Share Skill should be Updated to Credit