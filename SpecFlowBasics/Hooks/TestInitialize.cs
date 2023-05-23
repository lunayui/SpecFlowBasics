using TechTalk.SpecFlow;

namespace SpecFlowBasics.Hooks
{
    [Binding]
    public sealed class TestInitialize
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeTestRun]
        public static void BeforeTest() => Console.WriteLine("This line is execure from before Test");

        [BeforeFeature]
        public static void BeforeFeatureTest() => Console.WriteLine("This Line is execute before Feature");
       
        [BeforeScenario("@mytag")]
        public void BeforeScenarioWithTag() => Console.WriteLine("This line is execure from before scenario with Tag");

        [AfterScenario]
        public void AfterScenario() =>  Console.WriteLine("This line is executed after escenario");
    }
}