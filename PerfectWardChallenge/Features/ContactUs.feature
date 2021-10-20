Feature: ContactUs
	Complete Contact us form and submit

@mytag
Scenario: Complete Contact us form and submit
	Given a user has selected a "Contact" on the Perfect Ward Website
	When types "Name", "Last Name", "email@here.com" and "01702  5987541"
	And  Selects a Nurse from the dropdown options
	And  Selects a Clinic from the dropdown options
	And enters "Organisation"
	And Chooses Google from the How did you hear about us dropdown 
	And Clicks Submit 
	Then the user should see "Sorry, there was an error submitting the form. Please try again." 