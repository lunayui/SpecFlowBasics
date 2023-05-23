using Mono.Unix;
using OpenQA.Selenium;
using SpecFlowBasics.Drivers;
using SpecFlowBasics.Pages;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public sealed class LoginStepDefinitions
    {
        private readonly IDriverFixture driverFixture;
        private readonly IHomePage homePage;
        private readonly ILoginPage loginPage;
        public LoginStepDefinitions(IDriverFixture driverFixture,IHomePage homePage,ILoginPage loginPage)
        {

            this.driverFixture = driverFixture; 
            this.homePage = new HomePage(driverFixture);
            this.loginPage = new LoginPage(driverFixture);

        }
        [Given(@"I navigate to EA App")]
        public void GivenINavigateToEAApp()
        {
           driverFixture.Driver.Navigate().GoToUrl("http://eaapp.somee.com");
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            homePage.ClickLogin();
        }

        [Then(@"I enter username and password")]
        public void ThenIEnterUsernameAndPassword()
        {
            loginPage.PerformLogin("admin", "password");
        }
    }
}
