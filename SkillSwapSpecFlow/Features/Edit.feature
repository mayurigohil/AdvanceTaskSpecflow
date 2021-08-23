Feature: EditProfile
	Editing Profile Details

@Edit
Scenario: Edit Existing Languages
	Given User logs in
	When Edit and save Language
	Then Updated Language is saved

@Edit
Scenario: Edit Existing Skills
	Given User logs in
	When Edit and save skill
	Then Updated skill is saved

@Edit
Scenario: Edit Existing Education
	Given User logs in
	When Edit and save Education
	Then Updated Education is saved

@Edit
Scenario: Edit Existing Certification
	Given User logs in
	When Edit and save Certification
	Then Updated Certification is saved


