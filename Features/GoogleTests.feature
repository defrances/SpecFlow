Feature: GoogleTests

Scenario Outline: Check google search
Given The user open google page
When  The user start search '<Items>'

Examples: 
| Items			 |
| First example  |
| Second example |