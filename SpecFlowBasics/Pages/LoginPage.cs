using OpenQA.Selenium;
using SpecFlowBasics.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasics.Pages
{
    public class LoginPage : ILoginPage
    {
        private readonly IDriverFixture driverFixture;
        public LoginPage(IDriverFixture driverFixture)
        {
            this.driverFixture = driverFixture;
        }

        IWebElement txtUserName => driverFixture.Driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => driverFixture.Driver.FindElement(By.Id("Password"));
        IWebElement btnLogin => driverFixture.Driver.FindElement(By.CssSelector(".btn-default"));

        public void PerformLogin(string userName, string password)
        {

            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Click();

        }
    }
    public interface ILoginPage
    {
        void PerformLogin(string userName, string password);
    }
}
