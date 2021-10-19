using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    [TestFixture]
    public class CustomerNUnitTests
    {
        private Customer customer;
        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        public void CombineName_InputFirstAndLastName_ReturnFullName()
        {
           // var customer = new Customer();
            //Arrange

            //Act
           string fullName = customer.GreetAndCombineNames("Mustafa", "Ali");

            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(fullName, "Hello, Mustafa Ali");
                Assert.That(fullName, Is.EqualTo("Hello, Mustafa Ali"));
                Assert.That(fullName, Does.Contain("mustafa ali").IgnoreCase);
                Assert.That(fullName, Does.StartWith("Hello,"));
                Assert.That(fullName, Does.EndWith("Ali"));
                Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+"));
                Assert.IsNotNull(fullName);
            });


        }

    }
}
