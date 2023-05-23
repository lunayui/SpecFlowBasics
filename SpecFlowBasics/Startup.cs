using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using SpecFlowBasics.Drivers;
using SpecFlowBasics.Pages;
using SpecFlowBasics.Support;

namespace SpecFlowBasics
{

   
    public class Startup
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateService()
        {
            var services = new ServiceCollection();
            services.AddSingleton(new Settings
            {
                ApplicationUrl = new Uri("http://eaapp.somee.com")
            });
            services.AddScoped<IDriverFixture, DriverFixture > ();
            services.AddScoped<IHomePage, HomePage>();
            services.AddScoped<ILoginPage, LoginPage>();


            return services;
        }
    }
}
