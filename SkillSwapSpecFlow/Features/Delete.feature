Feature: DeleteProfile
	Simple calculator for adding two numbers


@Delete
Scenario: Delete Languages
	Given  User logged in to Mars
	Then Deletes the Language

@Delete
Scenario: Delete skill
	Given User logged in to Mars
	Then Deletes the Skill

@Delete
Scenario: Delete Certification
	Given User logged in to Mars
	When Delete Certification
	Then skill is Certification

@Delete
Scenario: Delete Education
	Given User logged in to Mars
	When Delete Education
	Then skill is Education