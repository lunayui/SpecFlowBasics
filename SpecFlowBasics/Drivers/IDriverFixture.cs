using OpenQA.Selenium;

namespace SpecFlowBasics.Drivers
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }

        void Dispose();
    }
}