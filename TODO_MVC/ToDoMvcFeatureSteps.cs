using System;
using TechTalk.SpecFlow;

namespace TODO_MVC
{
    [Binding]
    public class ToDoMvcFeatureSteps
    {
        [Given(@"I am navigated to the TODO MVC Landing page")]
        public void GivenIAmNavigatedToTheTODOMVCLandingPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am on the TODO MVC Landing page")]
        public void GivenIAmOnTheTODOMVCLandingPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am on the TODO MVC page")]
        public void GivenIAmOnTheTODOMVCPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I added Todo Items")]
        public void GivenIAddedTodoItems()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I add a Todo itema")]
        public void GivenIAddATodoItema()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I Completed the task by selecting the Todo Item")]
        public void GivenICompletedTheTaskBySelectingTheTodoItem(Table table)
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I examine the Landing page")]
        public void WhenIExamineTheLandingPage()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I add following items")]
        public void WhenIAddFollowingItems(Table table)
        {
			//ScenarioContext.Current.Pending();
		}

		[When(@"I add an item to the list")]
        public void WhenIAddAnItemToTheList(Table table)
        {
			//ScenarioContext.Current.Pending();
		}

		[When(@"I select any of the Todo Items")]
        public void WhenISelectAnyOfTheTodoItems(Table table)
        {
			//ScenarioContext.Current.Pending();
		}

		

		[When(@"I click on All filter option")]
        public void WhenIClickOnAllFilterOption()
        {
			//ScenarioContext.Current.Pending();
		}

		[When(@"I Completed the task by selecting the Todo Item")]
        public void WhenICompletedTheTaskBySelectingTheTodoItem(Table table)
        {
			//ScenarioContext.Current.Pending();
		}

		[When(@"I click on Active filter option")]
        public void WhenIClickOnActiveFilterOption()
        {
			//ScenarioContext.Current.Pending();
		}

		[When(@"I click on Clear Completed")]
        public void WhenIClickOnClearCompleted()
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see a title as ""(.*)""")]
        public void ThenISeeATitleAs(string p0)
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see a text box with text as ""(.*)""")]
        public void ThenISeeATextBoxWithTextAs(string p0)
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see footer text as ""(.*)""")]
        public void ThenISeeFooterTextAs(string p0)
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see a footer links as")]
        public void ThenISeeAFooterLinksAs(Table table)
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see items are added to the List")]
        public void ThenISeeItemsAreAddedToTheList()
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see Items Count Left is incremented")]
        public void ThenISeeItemsCountLeftIsIncremented()
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see filter options as")]
        public void ThenISeeFilterOptionsAs(Table table)
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see the selected item is striked off and disabled")]
        public void ThenISeeTheSelectedItemIsStrikedOffAndDisabled()
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see a filter option ""(.*)""")]
		public void ThenISeeAFilterOption(string p0)
		{
			//ScenarioContext.Current.Pending();
		}


		[Then(@"I see an additional filter option")]
        public void ThenISeeAnAdditionalFilterOption(Table table)
        {
			//ScenarioContext.Current.Pending();
		}

		[When(@"I click on ""(.*)"" filter option")]
		public void WhenIClickOnFilterOption(string filterOption)
		{
			//ScenarioContext.Current.Pending();
		}

		[Given(@"I add ""(.*)"" items into todo list")]
		public void GivenIAddItemsIntoTodoList(int numberOfItems)
		{
			for (int i = 1; i < numberOfItems; i++)
			{
				//create a random string  assadasd, sasadasd, assad,

				// code to type : random string

				// press enter
			}
		}


		[When(@"I marked one todo item as completed")]
		public void WhenIMarkedOneTodoItemAsCompleted()
		{
			//ScenarioContext.Current.Pending();

			// Get the total number of items in the list - Using selenium Ex: 10
			// Choose number bewteen 1 and total items - Ex: 4

			//Mark item as completed
			
		}


		[Then(@"I see the ""(.*)"" Todo item")]
		public void ThenISeeTheTodoItem(string filter)
		{
			//ScenarioContext.Current.Pending();
		}


		[Then(@"I see all added items")]
        public void ThenISeeAllAddedItems()
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see following items")]
        public void ThenISeeFollowingItems(Table table)
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see selected item is disappeared from Completed filter option")]
        public void ThenISeeSelectedItemIsDisappearedFromCompletedFilterOption()
        {
			//ScenarioContext.Current.Pending();
		}

		[Then(@"I see Clear Completed filter Option is also disappeared")]
        public void ThenISeeClearCompletedFilterOptionIsAlsoDisappeared()
        {
			//ScenarioContext.Current.Pending();
		}
	}
}
