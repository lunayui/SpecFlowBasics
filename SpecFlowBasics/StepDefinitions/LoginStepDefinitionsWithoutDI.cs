using OpenQA.Selenium;
using SpecFlowBasics.Drivers;
using SpecFlowBasics.Support;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitionsWithoutDI
    {
        private readonly DriverFixture _driverFixture;
        public LoginStepDefinitionsWithoutDI()
        {
            Settings settings = new Settings()
            {
                ApplicationUrl = new Uri("http://eaapp.somee.com")
            };
            //_driverFixture = new DriverFixture(settings); 
        }
   /*     [Given(@"I navigate to EA App")]
        public void GivenINavigateToEAApp()
        {
           // _driverFixture.Driver.Navigate().GoToUrl("http://eaapp.somee.com");
        }

        [When(@"I click login button")]
        public void WhenIClickLoginButton()
        {
            _driverFixture.Driver.FindElement(By.LinkText("Login")).Click();
        }

        [Then(@"I enter username and password")]
        public void ThenIEnterUsernameAndPassword()
        {
            _driverFixture.Driver.FindElement(By.Id("UserName")).SendKeys("admin");
            _driverFixture.Driver.FindElement(By.Id("Password")).SendKeys("password");
            _driverFixture.Driver.FindElement(By.CssSelector(".btn-default")).Click();
        }*/
    }
}
