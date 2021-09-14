Feature: SpecTest1
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Add two numbers
	Given the first number is '<a>' and total is '<total>'

	Examples:
	| a | total |
	| 1 | 101   |
	| 2 | 102   |
	| 3 | 103   |
	| 4 | 104   |
	| 5 | 105   |
	| 6 | 106   |