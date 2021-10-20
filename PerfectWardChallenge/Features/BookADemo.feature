Feature: BookADemo
	Book a demo button is available and enabled 

@mytag
#This lands on the page directly, leaving out any additional clicks and confirms the button is active, clickable and directs to the relivant URL
Scenario Outline: Book a demo button is available and enabled
	Given a user has selected a "<Page>" on the Perfect Ward Website
	When the user clicks the Book a Demo button
	Then the shoud be redirected to "<Booking Page>"

	Examples: 
	| Page         | Booking Page |
	| ipc          | book-a-demo  |
	| features     | book-a-demo  |
	| our-solution | book-a-demo  |
	| resources    | book-a-demo  |
	| contact      | book-a-demo  |


	#This lands on the page directly, leaving out any additional clicks and confirms the button is active, and the Book my demo button is present 
	
	Scenario Outline: "Book My Demo" button is visible
	Given a user has selected a "<Page>" on the Perfect Ward Website
	When the user clicks the Book a Demo button
	Then the "Book my demo!" button is present 
	Examples: 
	| Page         |
	| ipc          |
	| features     |
	| our-solution |
	| resources    |
	| contact      |