using NUnit.Framework;

namespace MyLibrary
{
    [TestFixture]
    public class CustomerNUnitTest
    {
        [Test]
        public void FullName_ReturnEmpty()
        {
            //Arrange
            Customer customer = new();

            //Act
            string result = customer.FullName;

            //Assert
            Assert.That(result, Is.WhiteSpace);

        }

        [Test]
        public void FullName_ReturnFullName()
        {

            Customer customer = new()
            {

                FirstName = "John",
                LastName = "Doe"

            };

            string result = customer.FullName;

            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result, Does.Contain(" "));
            Assert.That(result, Does.EndWith("Doe"));
            Assert.That(result, Does.StartWith("John"));
        }
    }
}
