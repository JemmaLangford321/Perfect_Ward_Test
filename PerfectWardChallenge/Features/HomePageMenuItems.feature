Feature: HomePageMenuItems
Check all the top level menus are accessible

@mytag
Scenario Outline: Check all the top level menus are accessible
	Given a user navigates to the Perfect Ward Website
	When selects a "<Menu Item>"
	Then the correct page will display "<Page>"

	Examples: 
	| Menu Item    | Page         |
	| IPC          | ipc          |
	| Features     | features     |
	| Our Solution | our-solution |
	| Resources    | resources    |
	| Contact      | contact      |