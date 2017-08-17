
Feature: ToDoMvcFeature

@ToDo_LandingpageItems
Scenario: Verify landing page elements
Given I am navigated to the TODO MVC Landing page
When I examine the Landing page
Then I see a title as "todos"
And I see a text box with text as "What needs to be done?"
And I see footer text as "Double-click to edit a todo"
And I see a footer links as 
|	Footer links		|
|	Christoph Burgdorf	|	
|	Eric Bidelman		|	
|	Jacob Mumm			|	
|	Igor Minar			|	
|	TodoMVC				|


@Todo_Add
Scenario:Verify adding a new todo
Given I am on the TODO MVC Landing page
When I add following items
|	Todo Item	|
|	TODO1		|
| 	TODO2		|
| 	TODO3		|
| 	TODO4		|
Then I see items are added to the List


@Todo_Count_Listoptions
Scenario:Verify count of added items along with list options
Given I am on the TODO MVC page
When I add an item to the list
|	Todo Item	|
|	TODO1		|
Then I see Items Count Left is incremented
And I see filter options as 
|	Filters   |
|	 All      |
|	Active    |
|	Completed |


@Todo_ItemSelection
Scenario:Verify Item Selection
Given I am on the TODO MVC page
And I added Todo Items
When I select any of the Todo Items
|	Todo Item	|
|	TODO1		|
Then I see the selected item is striked off and disabled
And I see a filter option "Clear completed" 



@Todo_Completed
Scenario:Verify Completed List Option
Given I am on the TODO MVC page
And I add a Todo itema
And I Completed the task by selecting the Todo Item
|	Todo Item	|
|	TODO1		|
When I click on "Completed" filter option
Then I see the "Completed" Todo item

 
@Todo_All @ignore
Scenario:Verify All List Option
Given I am on the TODO MVC page
When I add following items
|	Todo Item	|
|	TODO1		|
| 	TODO2		|
| 	TODO3		|
| 	TODO4		|
When I click on "All" filter option
Then I see all added items

@Todo_Active
Scenario:Verify Active List Option
Given I am on the TODO MVC page
When I add following items
|	Todo Item	|
|	TODO1		|
| 	TODO2		|
| 	TODO3		|
| 	TODO4		|
And I marked one todo item as completed
#Given I add "10" items into todo list
When I click on "Active" filter option
Then I see following items
|	Todo Item	|
| 	TODO2		|
| 	TODO3		|
| 	TODO4		|


@Todo_Clear Completed
Scenario:Verify Clear Completed List Option
Given I am on the TODO MVC page
When I add following items
|	Todo Item	|
|	TODO1		|
| 	TODO2		|
| 	TODO3		|
| 	TODO4		|
And I Completed the task by selecting the Todo Item
|	Todo Item	|
|	TODO1		|
And I click on Clear Completed
Then I see selected item is disappeared from Completed filter option
And I see Clear Completed filter Option is also disappeared

