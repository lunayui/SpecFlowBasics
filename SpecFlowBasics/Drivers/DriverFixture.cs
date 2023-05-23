using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowBasics.Drivers
{
    /*  public interface IDriverFixture
      {
          IWebDriver Driver { get; }
      }
      public class DriverFixture : IDriverFixture
      {
          private readonly IWebDriver webDriver;

          public DriverFixture(Settings settings)
          {
              this.webDriver = GetWebDriver();
              webDriver.Navigate().GoToUrl(settings.ApplicationUrl);
          }

          public IWebDriver Driver => webDriver;

          private IWebDriver GetWebDriver()
          {
              new DriverManager().SetUpDriver(new ChromeConfig());
              return new ChromeDriver();
          }
      }*/

    public class DriverFixture : IDisposable, IDriverFixture
    {
        private readonly IWebDriver webDriver;

        public DriverFixture()
        {
            webDriver = GetWebDriver();

        }
        public IWebDriver Driver => webDriver;

        private IWebDriver GetWebDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());

            return new ChromeDriver();
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }

}
