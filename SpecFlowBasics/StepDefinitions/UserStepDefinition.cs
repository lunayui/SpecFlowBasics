using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public sealed class UserStepDefinition
    {
        [Given(@"I enter random user data")]
        public void GivenIEnterRandomUserData()
        {
            //var person = new Fixture().Create<User>();
            var person = new Fixture().Build<User>().
                With(x=> x.Email,"lunayui@gmail.com").
                Create();

            Console.WriteLine($"The User {person.Name} has email { person.Email} and his Address {person.Address} with Phone Number {person.Phone}");
        }

        [Given(@"I input dynamic domain for (.* email)")]
        public void GivenIInputDynamicDomainForLunayuiGmail_ComInEmail(string email)
        {
            Console.WriteLine($"The random email address is :{email}");
        }

    }
    public record User
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

    }
}
