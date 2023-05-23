using OpenQA.Selenium;
using SpecFlowBasics.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasics.Pages
{
    public class HomePage : IHomePage
    {
        private readonly IDriverFixture driverFixture;
        public HomePage(IDriverFixture driverFixture)
        {
            this.driverFixture = driverFixture;
        }

        IWebElement lnkLogin => driverFixture.Driver.FindElement(By.LinkText("Login"));

        public void ClickLogin() => lnkLogin.Click();
    }

    public interface IHomePage
    {
        void ClickLogin();
    }
}
