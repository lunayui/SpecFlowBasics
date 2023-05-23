using Microsoft.VisualBasic;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
           Console.WriteLine($"{nameof(GivenTheFirstNumberIs)}: {number}");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)}: {number}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");
        }

        [Then(@"the result should be ""([^""]*)""")]
        public void ThenTheResultShouldBe(string result)
        {
            Console.WriteLine($"{nameof(ThenTheResultShouldBe)}: {result}");
        }

        [Given(@"I input following numbers to the calculator")]
        public void GivenIInputFollowingNumbersToTheCalculator(Table table)
        {
            dynamic datas = table.CreateDynamicSet();
            //var data = table.CreateSet<Calculation>();

            foreach (var row in datas)
            {
                Console.WriteLine($"The numbers are {row.Numbers}");
            }     
        }

        [Then(@"I see the result and few more details")]
        public void ThenISeeTheResultAndFewMoreDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Console.WriteLine($"The result is going to hold the value {data.Results} with logo {data.Logo}");
        }

/*        public record Calculation
        {
            public int Numbers { get; set; }
        }*/


    }
}